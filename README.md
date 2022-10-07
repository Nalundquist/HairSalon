# Eau Claire Hair Salon Admin Interface

### Created by Noah Lundquist in October of 2022

## Links

* [Repository](https://github.com/nalundquist/HairSalon)

## Description

A web interface for administrative tracking of stylists and clients at the Eau Claire Hair Salon.  Uses a MySQL database, a One-to-Many relationship (one stylist per a variety of clients), and the Entity framework.  

## Features

* Stores information and on stylists and clients.
* Can list clients on a per-stylist basis.


## Technologies Used

* Built in VS Code (v.1.70.1) using the following languages:
	* C#
	* HTML
	* CSS

* ASP.Net Core
* MySQL Database
* MySQL Workbench
* Entity Framework

## Installation

* Download [Git Bash](https://git-scm.com/downloads)
* Input the following into Git Bash to clone this repository onto your computer:

		>git clone https://github.com/nalundquist/HairSalon



* Enter the cloned project folder "HairSalon/HairSalon" and type:

		>dotnet restore

followed by

		>dotnet build

* Next, download [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) and install/configure them.

* After this, go into MySQL Workbench and click "Data Import/Restore"

* Select the "Import from Self-Contained File" option in the tab that appears

* In the field next to this, type "[directory repo was cloned into]/HairSalon/noah_lundquist.sql".  Note that the specified file is in the bottom-most root folder and not HairSalon/HairSalon.

*After this, create an appsettings.json file in the root HairSalon/ folder (sub in your own set username and password for the bracketed bits)

		{
  		"ConnectionStrings": {
      	"DefaultConnection": "Server=localhost;Port=3306;database=bestrestaurants;uid=[USERNAME];pwd=[PASSWORD];"
  		}
		}

* Finally, navigate to HairSalon/HairSalon in git bash (if you navigated away) and type  

		>dotnet run

Follwing this you can navigate to http://localhost:5000 in the browser of your choice to navigate around the interface.  

## Known Bugs

Search functionality is WIP; any query will return an accurate length of the amount of results in the URL (implying the query goes fine) while the results page itself will display nothing.  Will work on it :).

## License

Licensed under [GNU GPL 3.0](https://www.gnu.org/licenses/gpl-3.0.en.html)