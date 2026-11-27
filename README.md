# Royal Nile — Store Simulator

A desktop store simulation built with **F# and Windows Forms**. The application allows users to browse a product catalog, manage a shopping cart, and complete a simulated checkout.

## Features

- **Product Catalog:** Browse a collection of Egyptian-inspired products with names, descriptions, and prices.
- **Live Search:** Filter products by name or description.
- **Shopping Cart:** Add products, remove selected items, and view quantities and subtotals.
- **Order Summary:** Calculate the cart total and review the order before checkout.
- **Checkout:** Display a receipt with product details, quantities, subtotals, and the final amount.

## Interface

The application features a custom Windows Forms interface with a Royal Plum and Lavender theme, including a product catalog, cart panel, and checkout receipt.

## Built With

- **F#** — Application logic and data management.
- **.NET 10** — Runtime and framework.
- **Windows Forms** — Desktop user interface.

## Functional Programming Concepts

The project applies several F# concepts, including:

- **Immutable data:** Product and cart data are represented using immutable records and collections.
- **Pattern matching:** Used to handle cart operations.
- **Higher-order functions:** Collection operations such as `List.map`, `List.filter`, and `List.groupBy` support data processing.
- **Pure functions:** Core store operations separate business logic from the user interface.

## Getting Started

**Requirements:** .NET 10 SDK and Windows.

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
