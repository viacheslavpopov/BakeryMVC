# Pierre's Bakery

#### Epicodus Coding School, Console Application Independent Project #9 with C# & ASP.NET Core MVC, 12.16.2020

#### By Danielle Thompson

## Description

Building upon the console application first built for Pierre's Bakery (see this project's first iteration, (Pierre's Bakery Console app)[https://github.com/dani-t-codes/PierresBakery.Solution]), Pierre would like an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Razor is used to display information on each page.

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".


This project is a C# console application made for a bakery and includes the following functionality:

- One class for Bread and one for Pastry.
- When the user runs the application, they receive a prompt with a welcome message, along with the cost for both Bread and Pastries for individual items and for discounted bulk.
  Pierre offers the following deals:
    - Bread: Buy 2, get 1 free. A single loaf costs $5.
    - Pastry: Buy 1 for \$2 or 3 for $5. 
- A user can specify how many loaves of Bread or how many Pastries they'd like.
- The total cost of the order is returned to the user. The discount price will automatically be applied to *every* 3rd loaf and *every* 3rd pastry when large orders are made.
- All functionality for the models is tested.

## Technologies Used

- Git
- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL
- Razor View Engine
- ASP.NET Core MVC
- RESTful Routing, CRUD, & HTTP
- Bootstrap Library
- CSHTML
- Green & black teas

## Color Theme
Eggshell #F2EFE9
Warm tan #BFAC95
Soft brown #8C7974
Deep slate #524D59
Chestnut #403A3F

## Installation Requirements

This project requires the technologies listed in the above 'Technologies Used' section. If you need to acquire any of the above technologies to access this project, please follow the instructions included below.

If you already have the necessary technologies on your local system, the commands necessary for running this console application and its tests will be found at the bottom of the instructions list. 

#### Installing Git
###### For Mac Users
- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users
- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems
- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/BakeryMVC.Solution], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/BakeryMVC.Solution.git`.


#### Installing C#, .NET, dotnet script, & MySQL
* Install C# and .Net according to your operating system below. 
###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder, PierresBakery.Solution, on your Terminal or CMD.
* Move to the PierresBakery subfolder, and `dotnet build` will get bin/ and obj/ folders downloaded for the program to run.
* Move to the PierresBakery.Tests subfolder via the terminal. Running `dotnet restore` will install other necessary packages listed in project's boilerplate. 
* When in the PierresBakery.Tests subfolder, `dotnet test` will allow you to run the test-driven-development tests for the project's Models. 
* In the main project folder, `dotnet run` will run the application in the console. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :----------------------------|
| **Welcome Page** | User accesses localhost:5000 | Output: "Welcome Message & Action List" |
| **Create New Vendor** | 'Create new vendor' chosen | Output: "New vendor added" |
| **View All Vendors** | 'View all vendors' chosen | Return: "All vendors" |
| **Create New Order** | 'Create new order' chosen | Output: "New vendor added" |
| **View All Order** | 'View all orders' chosen | Return: "All orders" |


### Pages & Roots: 
Welcome ('/')
--> root path: 
//Vendor Pages: 
Index.cshtml ('/vendors')
New.cshtml ('/vendors/new')
Show.cshtml ('/vendors/:id')
//Order Pages:
Index.cshtml ('/orders')
New.cshtml ('vendors/{parentId}/orders/new')
Show.cshtml ('vendors/{parentId}/orders/{orderId}')


Class: Vendor (parent)
* Dictionary { Vendor, Order}
* Constructor
  - VendorName
  - VendorId (auto-generated)
  - InvoicesOfOrders
  - BalanceDue // stretch

Class: Order (child)
* Constructor 
  {- VendorId, VendorName}
  - OrderId (auto-generated)
  - ItemDescription (bread || pastry)
  - OrderType (wholesale || retail) // stretch
  - OrderPrice 
    --> Nested classes: bread & pastry console app logic, create bread + pastry totals
  - OrderDate (format? 1-12 mo, 1-31 day, 2020+ yr)

## Stretch Goals
TBD

## Known bugs
 

### Legal, or License

_MIT_ Copyright (c) 2020 *_Danielle Thompson_**