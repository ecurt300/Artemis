# Moon Phase Calculator: Project Artemis
>## About:
>	Where this project came from was that me and my family like to stargaze or look at the moon. We like to know what moon phase it is on the day we look up or days later to find what the next moon phase is. I decided to craft my capstone project around that.

Features:

   > * Enter in your desired date and the moon phase.
   > * The results are displayed by finding the next moon phase by calculating when that moon phase occurs after the entered date
   > * Simple easy to use UI

> # Technical:

Entities:
> There exists one entity in this program.	
>	1. Moon → Holds the Moon Phase , and a Date object reference.

Database:
	There exists one database:
> * 1. The moon phase database, this contains the moon phase data from the API call to the U.S. Naval Observatory.

> * Two versions of the Interface will be made:
> * 	Version 0 console version that will allow users to enter in the desired moon phase and date.			
> * 	Version 1 Winui3 Web App with all the underneath features implemented interfaced with Mudblazor.

> # Technologies and APIs:
	Languages:
		C#
	Tools:
		VS Studio 2022
	Frameworks:
> * EFCore for entities and Database Management
> *		SQLite for Storing Entities
> *		WINUI3 for User Interface

Task List:

    • Phase 1:
      Basic Logic and entity types implemented
	Console App for the aforementioned features in the about section. 
    • Phase 2:
          Program functionalities listed that require EF Core implemented
	    Database Implemented
	    Begin work on UI integration
    • Phase 3:
	    Testing phase 
	     Make sure that it works on other computers
    • Phase 4:
	    UI and Functions fully implemented
	    Release to Code Louisville
	
	
Capstone Project Feature To Be Implemented

Based on what is needed and the functionalities of the project I have determined this will meet the following:


>---
> | Feature | Difficulty |
>--
>   CRUD(Create, Read, and Update) -Medium/Hard
>   Three Unit Tests -Easy
>   Comments -Easy
>   List or Dictionary added -Easy
>
>   --
>
How to run:
* Download the VS Studio 2022 solution and clone to your desktop.
* Run the vs studio 2022 command line run the following:
* dotnet ef migrations add InitialCreate to create the migration
* dotnet ef database update to create the database
#make sure you have the Moons.db in your userpath 
Running the app:
* Run the program by running ArtemisUI in the app
* The UI is not the pretteist atm. But there exists two buttons
<img widt<img width="224" alt="RunArtemis" src="https://github.com/user-attachments/assets/6b665020-f70d-4097-ac6d-9ff6ef1ef70c" />
h="236" alt="Instructions" src="https://github.com/user-attachments/assets/ff330a9b-743a-430d-97d3-1b5126ea0f65" />
Make sure to use db browser to ensure the database is filled.

Make sure you have the following packages:

<img width="563" alt="Nuget1" src="https://github.com/user-attachments/assets/9f353b40-1e95-4a7b-a59b-ab2c4845f7ba" />
<img width="563" alt="nuget2" src="https://github.com/user-attachments/assets/88a33725-8620-46aa-974a-8da6197327a2" />
