# Artemis
Moon Phase Calculator: Project Artemis
About:
	Where this project came from was that me and my family like to stargaze or look at the moon. We like to know what moon phase it is on the day we look up or days later to find what the next moon phase is. I decided to craft my capstone project around that.

Features:

    • Enter in your desired date and the moon phase.
    • The results are displayed by finding the next moon phase by calculating when that moon phase occurs after the entered date
    • Simple easy to use UI

Technical:

Entities:
	There exists three entities in this program.
		1 Date→ Holds the Day, and Year entered or stored
		2 Moon → Holds the Moon Phase , and a Date object reference.
		3 Moon Results→ Holds the Moon , and Date data of the found moon phase and date.

Database:
	There exists two databases→ 
		1 The moon phase database, this contains the moon phase data from the API call to the U.S. Naval Observatory.
		2 All results→ This is for debugging and logging purposes to show all the results found with the app.


Technical Cont:

	User Interface:
	Two versions of the Interface will be made:
		Version 0→  console version that will allow users to enter in the desired moon phase and date.			
		Version 1→ Web App Mudblazor→ 
					Web App with all the underneath 							features implemented interfaced with 						Mudblazor.

Technical Cont:

Technologies and APIs:
	Languages:
		C#
	Tools:
		VS Studio 2022
	Frameworks:
		EFCore for entities and Database Management
		SQLite for Storing Entities
		Mudblazor for User Interface

Task List:

    • Phase 1
      Basic Logic and entity types implemented
	Console App for the aforementioned features in the about section. 
    • Phase 2
          Program functionalities listed that require EF Core implemented
	    Database Implemented
	    Begin work on UI integration
    • Phase 3
	    Testing phase 
	     Make sure that it works on other computers
    • Phase 4:
		UI and Functions fully implemented
		Release to Code Louisville
	
	
Capstone Project Feature To Be Implemented

Based on what is needed and the functionalities of the project I have determined this will meet the following.


Feature         |                Difficulty
CRUD(Create, Read, and Update)- Medium/Hard
Three Unit Tests -Easy
Comments -Easy
Two or more Tables -Hard
List or Dictionary added -Easy
Regex - Medium
