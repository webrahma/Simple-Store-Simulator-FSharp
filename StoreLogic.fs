namespace SimpleStore

open System
open SimpleStore.Models

module StoreLogic =

    type Cart = string list

    let emptyCart: Cart = []

    let addToCart (catalog: Map<string, Product>) (productName: string) (cart: Cart) : Cart =
        match Map.tryFind productName catalog with
        | Some _ -> productName :: cart
        | None -> cart

    let rec removeOneFromCart (productName: string) (cart: Cart) : Cart =
        match cart with
        | [] -> []
        | head :: tail when head = productName -> tail
        | head :: tail -> head :: removeOneFromCart productName tail

    let getCartProducts (catalog: Map<string, Product>) (cart: Cart) : Product list =
        cart
        |> List.choose (fun name -> Map.tryFind name catalog)

    let getCartSummary (catalog: Map<string, Product>) (cart: Cart) : CartLineItem list =
        cart
        |> List.choose (fun name -> Map.tryFind name catalog)
        |> List.groupBy (fun product -> product.Name)
        |> List.map (fun (_, group) ->
            let product = List.head group
            let qty = List.length group
            let subtotal = group |> List.sumBy (fun item -> item.Price)
            { Product = product
              Quantity = qty
              Subtotal = subtotal })
        |> List.sortBy (fun line -> line.Product.Name)

    let calculateTotal (catalog: Map<string, Product>) (cart: Cart) : decimal =
        cart
        |> getCartProducts catalog
        |> List.sumBy (fun product -> product.Price)

    let cartItemCount (cart: Cart) : int = List.length cart

    let filterCatalog (query: string) (catalog: Map<string, Product>) : Map<string, Product> =
        match query.Trim() with
        | "" -> catalog
        | q ->
            catalog
            |> Map.filter (fun _ product ->
                product.Name.Contains(q, StringComparison.OrdinalIgnoreCase)
                || product.Description.Contains(q, StringComparison.OrdinalIgnoreCase))

    let getCatalogList (catalog: Map<string, Product>) : Product list =
        catalog
        |> Map.toList
        |> List.map snd
        |> List.sortBy (fun product -> product.Name)
