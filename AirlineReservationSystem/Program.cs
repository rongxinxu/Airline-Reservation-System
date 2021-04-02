using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AirlineReservationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AirlineReservationDBEntities db = new AirlineReservationDBEntities();
            //Remove previous data
            db.Flights.RemoveRange(db.Flights);
            db.Customers.RemoveRange(db.Customers);
            //reset Id Increment (start with 1)
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Customer', RESEED, 0);");
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Flight', RESEED, 0);");
            db.SaveChanges();


            /**************************** TEST CASE 1 *****************************/
            /*************************************************/
            /*        Display All Flights available          */
            /*     1) At least one seat left                 */
            /* AND 2) Departing in 1 hour or later           */
            /*************************************************/
            //Flight newflight1 = new Flight();
            //newflight1.Airline = "American Airlines";
            //newflight1.Flight_Number = "AA123";
            //newflight1.Seat_Capacity = 50;
            //newflight1.Seat_Left = 50;
            //newflight1.Departure = "TUS";
            //newflight1.Arrival = "LAX";
            //newflight1.Departure_Time = new DateTime(2021, 4, 8, 9, 0, 0);   //2021/4/8 9:00:00 AM
            //newflight1.Arrival_Time = new DateTime(2021, 4, 8, 10, 45, 0);   //2021/4/8 10:45:00 AM
            //newflight1.Economy_Price = Convert.ToDecimal(99.99); // $99.99
            //newflight1.FirstClass_Price = Convert.ToDecimal(189.99); // $189.99

            //Flight newflight2 = new Flight();
            //newflight2.Airline = "Delta Air Lines";
            //newflight2.Flight_Number = "DL4440";
            //newflight2.Seat_Capacity = 30;
            //newflight2.Seat_Left = 1;   //ONLY ONE SEAT LEFT
            //newflight2.Departure = "TUS";
            //newflight2.Arrival = "PHX";
            //newflight2.Departure_Time = new DateTime(2021, 4, 8, 13, 0, 0);   //2021/4/8 1:00:00 PM
            //newflight2.Arrival_Time = new DateTime(2021, 4, 8, 13, 57, 0);   //2021/4/8 1:57:00 PM
            //newflight2.Economy_Price = Convert.ToDecimal(89.99); // $99.99
            //newflight2.FirstClass_Price = Convert.ToDecimal(149.99); // $189.99

            //// THIS FLIGHT SHOULD NOT DISPLAY ON THE LIST
            //// This no more seats/tickets left, but the departue time is still ON-TIME
            //Flight newflight3 = new Flight();
            //newflight3.Airline = "JetBlue Airways";
            //newflight3.Flight_Number = "B6123";
            //newflight3.Seat_Capacity = 45;
            //newflight3.Seat_Left = 0;    //there are no more seats/tickets left
            //newflight3.Departure = "SFO";
            //newflight3.Arrival = "PHX";
            //newflight3.Departure_Time = new DateTime(2021, 4, 8, 16, 5, 0);   //2021/4/8 4:05:00 PM
            //newflight3.Arrival_Time = new DateTime(2021, 4, 8, 19, 50, 0);   //2021/4/8 7:50:00 PM
            //newflight3.Economy_Price = Convert.ToDecimal(129.99); // $99.99
            //newflight3.FirstClass_Price = Convert.ToDecimal(205.49); // $189.99

            //// THIS FLIGHT SHOULD NOT DISPLAY ON THE LIST
            //// Some seats/tickets left, but the Departure time has passed OR Departing within the next 1 hour.
            //// So, this flight is not available to book/buy
            //Flight newflight4 = new Flight();
            //newflight4.Airline = "Southwest Airlines";
            //newflight4.Flight_Number = "SW2021";
            //newflight4.Seat_Capacity = 40;
            //newflight4.Seat_Left = 18;    //some seats/tickets left
            //newflight4.Departure = "SFO";
            //newflight4.Arrival = "PHX";
            //newflight4.Departure_Time = new DateTime(2021, 4, 2, 3, 00, 0);   //2021/4/2 2:30:00 PM
            //newflight4.Arrival_Time = new DateTime(2021, 4, 2, 15, 50, 0);     //2021/4/2 15:50:00 PM
            //newflight4.Economy_Price = Convert.ToDecimal(129.99); // $99.99
            //newflight4.FirstClass_Price = Convert.ToDecimal(205.49); // $189.99

            //db.Flights.Add(newflight1);
            //db.Flights.Add(newflight2);
            //db.Flights.Add(newflight3);
            //db.Flights.Add(newflight4);
            //db.SaveChanges();
            /**************************** TEST CASE 1 *****************************/




            /**************************** TEST CASE 2 *****************************/
            /**********************************************************************/
            /*        Test: Seats/Tickets are FULL for Economy or 1stClass        */
            /**********************************************************************/
            //Flight newflight1 = new Flight();
            //newflight1.Airline = "American Airlines";
            //newflight1.Flight_Number = "AA123";
            //newflight1.Seat_Capacity = 20;   //(FOR TESTING) ONLY 2 tickects are economy
            //newflight1.Seat_Left = 18;   //ONLY First-Class left (By default, every plane open 18 tickets/seats for 1stClass)
            //newflight1.Departure = "TUS";
            //newflight1.Arrival = "LAX";
            //newflight1.Departure_Time = new DateTime(2021, 4, 8, 9, 0, 0);   //2021/4/8 9:00:00 AM
            //newflight1.Arrival_Time = new DateTime(2021, 4, 8, 10, 45, 0);   //2021/4/8 10:45:00 AM
            //newflight1.Economy_Price = Convert.ToDecimal(99.99); // $99.99
            //newflight1.FirstClass_Price = Convert.ToDecimal(189.99); // $189.99

            //Flight newflight2 = new Flight();
            //newflight2.Airline = "Delta Air Lines";
            //newflight2.Flight_Number = "DL4440";
            //newflight2.Seat_Capacity = 30;
            //newflight2.Seat_Left = 30;
            //newflight2.Departure = "TUS";
            //newflight2.Arrival = "PHX";
            //newflight2.Departure_Time = new DateTime(2021, 4, 8, 13, 0, 0);   //2021/4/8 1:00:00 PM
            //newflight2.Arrival_Time = new DateTime(2021, 4, 8, 13, 57, 0);   //2021/4/8 1:57:00 PM
            //newflight2.Economy_Price = Convert.ToDecimal(89.99); // $99.99
            //newflight2.FirstClass_Price = Convert.ToDecimal(149.99); // $189.99

            //Customer newCustomer1 = new Customer();
            //newCustomer1.FullName = "Customer1";
            //newCustomer1.Age = 20;
            //newCustomer1.Email = "newCustomer1@email.com";
            //newCustomer1.address = "newCustomer1 Address";
            //newCustomer1.SeatNum = "";
            //newCustomer1.typeOfTicket = 1; //Economy class
            //newCustomer1.FlightConfirmNumber = "ABC12";
            //newCustomer1.TicketPrice = "99.99";
            //newCustomer1.FlightID = 1;  // Link to newflight1 object

            //Customer newCustomer2 = new Customer();
            //newCustomer2.FullName = "Customer2";
            //newCustomer2.Age = 22;
            //newCustomer2.Email = "newCustomer2@email.com";
            //newCustomer2.address = "newCustomer2 Address";
            //newCustomer2.SeatNum = "";
            //newCustomer2.typeOfTicket = 1; //Economy class
            //newCustomer2.FlightConfirmNumber = "ABC23";
            //newCustomer2.TicketPrice = "99.99";
            //newCustomer2.FlightID = 1;  // Link to newflight1 object

            //db.Flights.Add(newflight1);
            //db.Flights.Add(newflight2);
            //db.SaveChanges();
            //db.Customers.Add(newCustomer1);
            //db.Customers.Add(newCustomer2);
            //db.SaveChanges();
            /**************************** TEST CASE 2 *****************************/



            /**************************** TEST CASE 3 **********************************/
            /***************************************************************************/
            /*                    Test: Time for Picking a seat                        */
            /*  Seat selection is only available within the 24 hours before departure  */
            /***************************************************************************/
            //Flight newflight1 = new Flight();
            //newflight1.Airline = "American Airlines";
            //newflight1.Flight_Number = "AA123";
            //newflight1.Seat_Capacity = 30;
            //newflight1.Seat_Left = 10;   // randomly typed in (useless in this test case)
            //newflight1.Departure = "TUS";
            //newflight1.Arrival = "LAX";
            //newflight1.Departure_Time = new DateTime(2021, 4, 3, 9, 0, 0);   //2021/4/3 9:00:00 AM
            //newflight1.Arrival_Time = new DateTime(2021, 4, 3, 10, 45, 0);   //2021/4/3 10:45:00 AM
            //newflight1.Economy_Price = Convert.ToDecimal(99.99); // $99.99
            //newflight1.FirstClass_Price = Convert.ToDecimal(189.99); // $189.99

            //Flight newflight2 = new Flight();
            //newflight2.Airline = "Delta Air Lines";
            //newflight2.Flight_Number = "DL4440";
            //newflight2.Seat_Capacity = 30;
            //newflight2.Seat_Left = 15; // randomly typed in (useless in this test case)
            //newflight2.Departure = "TUS";
            //newflight2.Arrival = "PHX";
            //newflight2.Departure_Time = new DateTime(2021, 4, 3, 20, 0, 0);   //2021/4/3 8:00:00 PM
            //newflight2.Arrival_Time = new DateTime(2021, 4, 3, 20, 57, 0);   //2021/4/3 8:57:00 PM
            //newflight2.Economy_Price = Convert.ToDecimal(89.99); // $99.99
            //newflight2.FirstClass_Price = Convert.ToDecimal(149.99); // $189.99

            //Customer newCustomer1 = new Customer();
            //newCustomer1.FullName = "Test1";
            //newCustomer1.Age = 20;
            //newCustomer1.Email = "newCustomer1@email.com";
            //newCustomer1.address = "newCustomer1 Address";
            //newCustomer1.SeatNum = "";
            //newCustomer1.typeOfTicket = 1; //Economy class
            //newCustomer1.FlightConfirmNumber = "ASD12";
            //newCustomer1.TicketPrice = "99.99";
            //newCustomer1.FlightID = 1;  // Link to newflight1 object

            //Customer newCustomer2 = new Customer();
            //newCustomer2.FullName = "Test2";
            //newCustomer2.Age = 22;
            //newCustomer2.Email = "newCustomer2@email.com";
            //newCustomer2.address = "newCustomer2 Address";
            //newCustomer2.SeatNum = "";
            //newCustomer2.typeOfTicket = 1; //Economy class (1) First-Class (2)
            //newCustomer2.FlightConfirmNumber = "ASD23";
            //newCustomer2.TicketPrice = "99.99";
            //newCustomer2.FlightID = 1;  // Link to newflight1 object

            //Customer newCustomer3 = new Customer();
            //newCustomer3.FullName = "Test3";
            //newCustomer3.Age = 22;
            //newCustomer3.Email = "newCustomer2@email.com";
            //newCustomer3.address = "newCustomer2 Address";
            //newCustomer3.SeatNum = "";
            //newCustomer3.typeOfTicket = 2; //First class
            //newCustomer3.FlightConfirmNumber = "QWE12";
            //newCustomer3.TicketPrice = "149.99";
            //newCustomer3.FlightID = 2;  // Link to newflight2 object

            //db.Flights.Add(newflight1);
            //db.Flights.Add(newflight2);
            //db.SaveChanges();
            //db.Customers.Add(newCustomer1);
            //db.Customers.Add(newCustomer2);
            //db.Customers.Add(newCustomer3);
            //db.SaveChanges();
            /**************************** TEST CASE 3 **********************************/


            /**************************** Run the Application **************************/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
