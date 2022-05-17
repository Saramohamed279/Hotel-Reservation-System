# Hotel-Reservation-System
## This is an C# Form Applcation to an hotel system using orcal database and concepts of software engineering 

SRS for this project

Introduction:
A Hotel Booking System to facilitate the process of booking the accommodations to the user, its important since the user can know all the details of the hotel Rooms and book the accommodation by pressing a booking button or cancel it.
Functional Requirements:
•	Showing available Rooms according to the Room type:
- The user can choose a room and the according to the type chosen by the user the program will show the available room.
- Precondition: The user has to choose rooms. 
- Postcondition: According to the room, the type will appear.

•	Details for each room:
- The system will display the details of each room as its view, service, type, and the range of the prices.
- Precondition: The Room must be available to be displayed.
- Postcondition: The details of the room will be displayed.

•	Search Tool:
-The system includes a search tool to search for a certain room, it also includes searching by type, and price.
- Precondition: The user has to click on the tool and write what he wants to search for.
- Postcondition: The suitable room that the user searched for will be displayed.

•	Booking / Cancelation:
-The user can either book a room shown by the system or cancel a booked room.
- Precondition: The user must be registered, has chosen the accommodation and has enough money in the credit card (in Booking case).
- Postcondition: The accommodation chosen would be either booked or the booking would be canceled.

•	Hotel rating:
-The customer can rate the hotel after he had an experience with this hotel by booking a room through the system.
-Precondition: The customer must have booked an accommodation before to rate the hotel and checking out.
-Postcondition: The customer can rate the hotel in scale from 1 to 5 stars, and this rating will affect the average of the hotel’s rate.

•	Make Offers:
-The user can put an offer or a discount on the rooms.
-Precondition: The user has to specify the room offered.  
-Postcondition: The offer will be displayed on the room chosen.

•	Send Mails to customers
-The user can send mails to the customers through the system.
-Precondition: The user has to specify the user and enter his mail.
-Postcondition: The mail will be sent to the user.

•	Show Hotel Data
-The user can show & edit the data of the hotel if anything was updated.
-Precondition: Tab view icon to view and update his data.
-Postcondition: The hotel data will be updated and shown to the users.

Non-Functional Requirements:
•	Limit database usage to improve the speed 
-	The system will call the database once the system starts then it won’t use it again throughout the system process.

•	Null/Dummy Data Handling
-	The system will handle all dummy data.

•	Check-in Data constraints
-	There will be constraints on each data the user enters in registration process to make sure of the data correctness.

•	Check-out Data constraints
-	The Checked-out Room should return available again.

•	Fast system Learnability 
-	Users will be able to complete the main actions rapidly once they see the interface.

•	Simple interface (easy to use)
-	The system will have an easy interface that is clear enough to be understandable.

•	Saving Data 
-	Each user data will be saved and kept for each navigation in the system, at the end all users and hotel data will be committed to the database.

