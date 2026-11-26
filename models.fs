namespace SimpleStore
module Models =


    type Product =
        { Name: string
          Price: decimal
          Description: string }


    type CartLineItem =
        { Product: Product
          Quantity: int
          Subtotal: decimal }

    
    let formatEgp (amount: decimal) : string =
        sprintf "EGP %s" (amount.ToString("N2", System.Globalization.CultureInfo.InvariantCulture))


    let initialCatalog: Map<string, Product> =
        [ { Name = "Egyptian Cotton Bedsheet Set"
            Price = 1850.00m
            Description = "100% long-staple Egyptian cotton, soft breathable weave." }
          { Name = "Siwa Extra Virgin Olive Oil"
            Price = 420.00m
            Description = "Cold-pressed organic olive oil from Siwa Oasis, 500ml." }
          { Name = "Khan El-Khalili Brass Lantern"
            Price = 680.00m
            Description = "Handcrafted traditional Egyptian brass lantern with warm geometric cutouts." }
          { Name = "Fayoum Handmade Ceramic Mug Set"
            Price = 350.00m
            Description = "Artisanal hand-painted pottery mugs from Tunis Village, Fayoum." }
          { Name = "Sinai Mountain Wild Honey"
            Price = 540.00m
            Description = "Pure raw wildflower honey harvested from Saint Catherine, Sinai." }
          { Name = "Aswan Premium Karkadeh Box"
            Price = 190.00m
            Description = "Whole sun-dried crimson hibiscus petals from Aswan." }
          { Name = "Nubian Handwoven Tote Bag"
            Price = 490.00m
            Description = "Colorful handcrafted cotton tote woven by Nubian artisans." }
          { Name = "Egyptian Musk Perfume Oil"
            Price = 320.00m
            Description = "Long-lasting alcohol-free concentrated musk oil, 30ml." }
          { Name = "Fayoum Natural Rosewater Mist"
            Price = 210.00m
            Description = "Pure distilled rosewater facial mist from Fayoum rose farms." }
          { Name = "Egyptian Spiced Arabic Coffee"
            Price = 260.00m
            Description = "Freshly roasted medium-blend coffee with cardamom, 250g." } ]
        |> List.map (fun product -> product.Name, product)
        |> Map.ofList