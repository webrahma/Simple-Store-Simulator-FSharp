# Royal Nile — Store Simulator

A desktop store simulation built with **F# and Windows Forms**. Royal Nile allows users to browse an Egyptian-inspired product catalog, manage a shopping cart, and complete a simulated checkout.

## Features

- **Product Catalog:** Browse 10 Egyptian-inspired products with their names, descriptions, and prices.
- **Live Search:** Filter products by name or description.
- **Product Preview:** View the selected product's details and price.
- **Shopping Cart:** Add products, remove selected items, and track the cart's item count.
- **Cart Summary:** View grouped products, quantities, unit prices, subtotals, and the overall total.
- **Checkout:** Review a dated receipt and confirm the purchase. Completing checkout clears the cart.

## User Interface

The application uses a custom Windows Forms interface with a Royal Plum and Lavender color scheme. It includes a product catalog, shopping cart panel, cart summary, and checkout receipt.

## Implementation

The project uses F# features and collection operations to handle store data and cart management:

- **Records:** Represent products and cart line items.
- **Maps:** Store and retrieve catalog products.
- **Lists:** Represent cart contents and support cart operations.
- **Pattern Matching and Recursion:** Handle removing individual items from the cart.
- **Collection Operations:** Use `List.choose`, `List.groupBy`, and `List.sortBy` to retrieve and organize cart data.
- **Filtering:** Search the catalog by matching product names and descriptions.

## Technologies

- **F#** — Application logic and data management.
- **.NET 10** — Runtime and framework.
- **Windows Forms** — Desktop user interface.

## Getting Started

**Requirements:** Windows and the .NET 10 SDK.

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

   ```
