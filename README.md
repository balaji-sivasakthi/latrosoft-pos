
<p align="center">
  <img  width="100px" height="100px" src="https://res.cloudinary.com/dh6gxe3jq/image/upload/v1689581034/1547934_hvhffi.png">
  <h4 align="center">Latrosoft's Point of Sale (POS)</h4>
</p>

## Table of Contents
  - [Table of Contents](#table-of-contents)
  - [Description](#description)
  - [Features](#features)
  - [Installation](#installation)
  - [Usage](#usage)
  - [Configuration](#configuration)
  - [License](#license)

## Description

Latrosoft POS is a user-friendly Point of Sale (POS) software designed to help businesses manage their sales and inventory efficiently. This software provides an intuitive interface and essential features to streamline your business operations.

## Features

- User-friendly interface for smooth navigation.
- Product Management: Add, edit, and delete products from the inventory.
- Inventory Management: Track product quantities and receive low stock alerts.
- Sales Processing: Process sales, calculate total amounts, and generate receipts.
- Reporting: Generate basic sales reports for a specific date range.
- User Authentication: Secure access with username and password.

## Installation

Before you begin, ensure that you have the following prerequisites installed on your system:

- Microsoft Visual Studio (C# development environment)
- Microsoft SQL Server (Express Edition or higher)
- .NET Framework (compatible with your Visual Studio version)

To install Latrosoft POS, follow these steps:

1. Clone or download the project files from our GitHub repository.
2. Open the solution file (.sln) in Microsoft Visual Studio.
3. Restore the NuGet packages used in the project.
4. Build the solution to ensure there are no errors.
5. Create a new SQL Server database to store the application data.
6. Run the SQL scripts provided in the repository to create the necessary tables and initial data (if any).

## Usage

Here's a quick guide on how to use Latrosoft POS:

1. **Login:** Launch the application and log in using your credentials.
2. **Dashboard:** After logging in, you'll see the main dashboard with options for managing products, inventory, and sales.
3. **Product Management:** Add new products, edit existing ones, or remove items from the inventory.
4. **Inventory Management:** Keep track of product quantities and receive alerts for low stock levels.
5. **Sales Processing:** Select products and quantities for a sale, and the application will calculate the total amount. Generate and print receipts for customers.
6. **Reporting:** Generate sales reports for a specific date range to assess business performance.

## Configuration

Before running the application, you need to configure the database connection string. Locate the `app.config` file in the project and update the connection string with your SQL Server credentials and the database name.

```xml
<connectionStrings>
    <add name="LatrosoftPOSConnectionString" connectionString="Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```
## License
Latrosoft POS is licensed under the MIT License. Please review the LICENSE file in the GitHub repository for more details.
