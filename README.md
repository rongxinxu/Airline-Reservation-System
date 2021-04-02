# Airline-Reservation-System
**Language:** C# .NET

**Version 1.0.0**

## Project Definition
The task is to create a mini airline reservation system. The system must be able to handle two types of users: Customers and Administrators.

## Administrator
Setup a flight to be reserved with:
- Seating capacity of the plane
- Price of 1st class and economy ticket
- Departure airport for the flight
- Arrival airport for the flight
- Departure time
- Arrival time

## Features to be supported
- Display list of all flights available
- Allow user to pick a flight from list of all flights available and enter basic info (their name and age).
- Seating chart must be displayed to the client when it is time to pick their seat.

## Classes
- [Admin](AirlineReservationSystem/Admin.cs)
- [Customer](AirlineReservationSystem/Customer.cs)
- [Flight](AirlineReservationSystem/Flight.cs)

## Test Cases
* [Test Case 1 (line 34-91)](AirlineReservationSystem/Program.cs) Display all available flights that has at least one seat left AND departing in 1 hour or later. 
* [Test Case 2 (line 101-152)](AirlineReservationSystem/Program.cs) Economy or First-Class Tickets/Seats are FULL
* [Test Case 3 (line 162-225)](AirlineReservationSystem/Program.cs) Time for Picking a seat. Seat selection is ONLY available within the 24 hours before the flight departure time.

## Demo
[Demo Video](https://youtu.be/CMaVxHRfCc8)

## Contributors
- Vincent Xu <rongxinxu@email.arizona.edu>

## License & Copyright
&copy; Vincent Xu, University of Arizona

