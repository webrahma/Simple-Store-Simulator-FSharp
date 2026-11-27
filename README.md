# Royal Nile — Simple Store Simulator

A desktop store simulation built with **F#** and **Windows Forms (.NET 10)**. Royal Nile allows users to browse an Egyptian-inspired product catalog priced in EGP, manage a shopping cart, and complete a simulated checkout.

## Features

- **Product Catalog:** Browse 10 Egyptian-inspired products with their names, descriptions, and prices in EGP.
- **Live Search:** Filter products dynamically by name or description.
- **Product Preview:** View the selected product's full details and price.
- **Shopping Cart:** Add products by name, remove selected items, and track the live cart item count.
- **Cart Summary:** View grouped products, quantities, unit prices, subtotals, and the overall total.
- **Checkout:** Review a dated itemized receipt and confirm the purchase, which clears the cart upon completion.

## User Interface

The application features a custom **Windows Forms** interface designed with a **Royal Plum and Lavender** theme, including a product catalog table, live search bar, shopping cart panel, cart summary dialog, and checkout receipt.

## Functional Programming Concepts

The core logic is implemented in F# following core Functional Programming principles:

- **Immutability:** Store data uses immutable structures—`Record` types for products, an F# `Map<string, Product>` for the catalog, and an immutable `string list` for the shopping cart (adding or removing items returns a new list without mutating existing state).
- **Pattern Matching & Recursion:** `match` expressions handle `Map.tryFind` lookups safely and recursively remove a single occurrence of an item from the cart.
- **First-Class Functions & Pipelines:** Higher-order collection functions (`List.choose`, `List.groupBy`, `List.sortBy`, `List.sumBy`, and `Map.filter`) are combined with the pipe operator (`|>`) to search products, organize cart items, and calculate totals.

## Project Structure

```text
Simple-Store-Simulator-FSharp/
├── SimpleStore.fsproj   # .NET 10 Windows Forms project configuration
├── Models.fs            # Product record definition and Egyptian product catalog (Map)
├── StoreLogic.fs        # Pure functional cart operations, search, and total calculation
├── UI.fs                # Custom Royal Plum & Lavender Windows Forms interface
├── Program.fs           # Application entry point
└── README.md            # Project documentation
```

## Technologies

- **F#** — Functional application logic and data modeling.
- **.NET 10** — Runtime and framework.
- **Windows Forms** — Desktop graphical user interface.

## Getting Started

**Requirements:** Windows and the [.NET 10 SDK](https://dotnet.microsoft.com/download).

1. Clone the repository:

   ```bash
   git clone https://github.com/webrahma/Simple-Store-Simulator-FSharp.git
   ```

2. Navigate to the project directory:

   ```bash
   cd Simple-Store-Simulator-FSharp
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

