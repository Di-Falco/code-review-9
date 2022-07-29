# Hair Salon Stylist/Client database

#### Contributors: Anthony DiFalco

#### A site where E. Claire can keep track of her stylists and their clients

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MySQL
* HTML

## Description

This project uses ASP.NET Core to simulate a program that allows a hair salon to keep track of their employees and each employees clients.

The home page links to a list of stylists, a list of clients, and seperate forms to add new stylists or clients. On the list pages, each stylist/client links to their respective details page. For stylists, this page displays each of their clients with links to their respective details pages.

Some of the functionality includes:

Create:
  * Clients are assigned a name and a stylist
  * Stylists are assigned a name

Edit:
  * Clients can be renamed or assigned to different stylists
  * Stylists can be renamed

Delete:
  * Clients can be deleted
  * Stylists can be deleted. Any remaining clients of theirs are deleted with them, so reassign any clients beforehand.

## Setup/Installation Requirements

Installation from GitHub:

* To run this program you will need to install VSCode, along with C# and .NET
* From your terminal run&emsp;`git clone https://github.com/Di-Falco/code-review-9`
* From the HairSalon directory run&emsp;`dotnet restore`

SQL setup:

* In the HairSalon directory, create an appsetting.json file. The terminal command for this is&emsp;`touch appsetting.json`
* Within appsetting.json, insert the following:

`"ConnectionStrings": {`

&emsp;`  "DefaultConnection": "Server=localhost;Port=3306;database=anthony_difalco;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"`

`}`
* Replace&ensp;`[YOUR-USERNAME-HERE]`&ensp;and&ensp;`[YOUR-PASSWORD-HERE]`&ensp;with your username and password for MySqlWorkbench
* Launch MySQLWorkbench
* From the administration tab, select&ensp;`Data Import/Restore`
* Select&ensp;`Import from Self-Contained File`
* From the field on the right, navigate to the location of&ensp;`anthony_difalco.sql`&ensp;in this project's&ensp;`/HairSalon`&ensp;directory on your computer
* Under&ensp;`Default Schema to be Imported`&ensp;select&ensp;`New`
* Name the schema `anthony_difalco` and click `OK`
* Click&ensp;`Start Import`&ensp; at the bottom of the menu

To Run the Program:
* Navigate to the&ensp;`/HairSalon`&ensp;directory from your terminal
* Enter the command `dotnet run`
* The program should launch on&ensp;`localhost:5000`

## Known Bugs

* Deleted clients/stylists occaisonally seem to stay in the database despite being correctly removed from the site's display

## License

## Contact Information