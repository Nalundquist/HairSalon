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

and finally

		>dotnet run

Follwing this you can navigate to http://localhost:5000 in the browser of your choice to navigate around the vendor/order interface.  

## Known Bugs

None at this point.

## License

Licensed under [GNU GPL 3.0](https://www.gnu.org/licenses/gpl-3.0.en.html)