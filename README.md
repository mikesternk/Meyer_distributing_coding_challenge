# Coding Challenge

**By Michael Kimani**

## Coding Challenge Requirements:

The following code changes were applied to meet the requirements of the coding challenge:

### Code Implementations

1. **Total Sales, Returns, and Profit Calculation:**

- **Location**: `CustomerBase` class.
- **Description**: Added methods to calculate `GetTotalSales()`, `GetTotalReturns()`, and `GetTotalProfit()`.

  - **GetTotalSales()**: Sums up the selling prices of all products within each order for a customer.
  - **GetTotalReturns()**: Calculates the total value of all returned products within each return for a customer.
  - **GetTotalProfit()**: Computes the profit by subtracting total returns from total sales

2. Record Purchase Timestamp:

- **Location**: `Order` class.
- **Description**: A new timestamp field `PurchaseDate` was added to record the date and time when each order is created. This is initialized to the current date and time upon order creation, thus tracking the purchase time.

### Bug Fixes

1. **Meyer Truck Equipment's Returns Not Being Processed**:

- **Issue**: Returns were not being displayed or processed for _Meyer Truck Equipment_.
- **Fix**: Adjusted the logic in the `ProcessTruckAccessoriesExample` method to ensure returns are correctly created, recorded, and displayed in the console output for `TruckAccessoriesCustomer`.

2. **Incorrect Totals for Ruxer Ford Lincoln, Inc.**:

- **Issue**: The totals (sales, returns, profit) for _Ruxer Ford Lincoln, Inc._ were accumulating incorrectly over multiple runs.
- **Fix**: Added logic to reset the total sales, returns, and profit values before calculating them each time in the `ConsoleWriteLineResults` method. This prevents residual values from previous calculations from affecting the current output.
