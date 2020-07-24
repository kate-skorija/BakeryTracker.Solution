# Pierre's Bakery Vendor and Order Tracker

#### Basic Web Applications with C# Exercise for Epicodus 07.24.2020

### By Kate Skorija

## Description

This is a basic C# web application for Pierre's Bakery. It was built to help Pierre track the vendors that purchase baked goods from his business, and the orders belonging to those vendors.

## Specifications

**Behavior**: Program will the user to create a vendor.
  * Input: "Suzie's Cafe"
  * Output: Suzie's Cafe is now a new vendor object

**Behavior**: Program will allow the user to track specific orders for each vendor added.
  * Input: "Suzie's Cafe", "50 croissants a week"
  * Output: An order of 50 croissants is added to Suzie's Cafe vendor object

**Behavior**: Program will have a welcome page where users can choose to view the current list of vendors.
  * Input: *User clicks "View vendors"*
  * Output: User is taken to a page with a list of vendors

**Behavior**: Program will have a link to add a new vendor on the vendor list page. 
  * Input: *User clicks "Add a new vendor"*
  * Output: User is taken to a form to add a new vendor

**Behavior**: Program will return user to the vendor list page after submission of the vendor form. 
  * Input: *User submits new vendor form*
  * Output: User is taken to vendor list page

**Behavior**: Program will have a detail page for each vendor that list that vendor's orders.
  * Input: *User clicks "Suzie's Cafe"*
  * Output: User is taken to a page with a list of Suzie's Cafe's orders

**Behavior**: Program will have a link to add new orders to a vendor's detail page.
  * Input: *User clicks "Add new order"*
  * Output: User is taken to a page with a form to add another order for Suzie's Cafe

**Behavior**: Program will return user to the vendor detail page after submission of the order form. 
  * Input: *User submits new order form*
  * Output: User is taken to vendor detail page

## Setup/Installation Requirements

1.  Navigate to the [BakeryTracker.Solution respository](https://github.com/kate-skorija/BakeryTracker.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/BakeryTracker.Solution.git`

3. Navigate to the `BakeryTracker.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

5. If you wish to test the code, navigate to the BakeryTracker.Tests directory. In the terminal type `dotnet restore`, then `dotnet test`.

6. Within the project, navigate to the BakeryTracker directory, and type `dotnet restore`, then `dotnet build`. Once the build is complete, type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 