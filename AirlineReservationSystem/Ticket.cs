using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Ticket : Form
    {
        AirlineReservationDBEntities db;
        Customer thisTraveler;
        Flight travelers_flight;
        string passengerName;
        string confirmNum;
        public Ticket(string passengerName1, string confirmNum1)
        {
            InitializeComponent();

            db = new AirlineReservationDBEntities();
            passengerName = passengerName1;
            confirmNum = confirmNum1;
        }

        private void generateBarcode(string barCodeText)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barcodePictureBox.Image = barCode.Draw(barCodeText, 60);
            }
            catch (Exception) { }
        }

        private void pickButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Seats seatsPage = new Seats(thisTraveler, travelers_flight, confirmNum);
            seatsPage.ShowDialog();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            //generate Confirmation Number Barcode
            generateBarcode(confirmNum);

            //find this traveler in database
            thisTraveler = db.Customers.Where(a => a.FullName == passengerName && a.FlightConfirmNumber == confirmNum).SingleOrDefault();

            //find this traveler's flight
            travelers_flight = db.Flights.Where(a => a.Id == thisTraveler.FlightID).SingleOrDefault();

            /********* Display Airline & Flight # *******/
            airlineAndFlightNum.Text = travelers_flight.Airline + " " + travelers_flight.Flight_Number;

            /********* display departure and arrival locations *******/
            departLocation.Text = travelers_flight.Departure;
            arrivalLocation.Text = travelers_flight.Arrival;

            /********* Times *******/
            DateTime tempDepartTime = (DateTime)travelers_flight.Departure_Time;
            DateTime tempArrivalTime = (DateTime)travelers_flight.Arrival_Time;
            //departure time
            departDate.Text = tempDepartTime.ToString("ddd, dd MMM yyyy");
            departureTime.Text = tempDepartTime.ToString("hh:mm tt");
            //arrival time
            arrivalDateText.Text = "Arrives " + tempArrivalTime.ToString("ddd, dd MMM yyyy");
            arrivalTime.Text = tempArrivalTime.ToString("hh:mm tt");
            //Total flight time
            TimeSpan totalFlightTime = TimeSpan.FromMilliseconds(tempArrivalTime.Subtract(tempDepartTime).TotalMilliseconds);
            tripTime.Text = totalFlightTime.Hours + "h " + totalFlightTime.Minutes + "m";
            /********* Times *******/

            /* ******* Traveler Information ********** */
            travelerNameLabel.Text = thisTraveler.FullName;
            emailLabel.Text = thisTraveler.Email;
            ageLabel.Text = thisTraveler.Age.ToString();
            /* ******* Traveler Information ********** */

            /* ******* Price Summary ********** */
            if (thisTraveler.typeOfTicket == 1)
            {
                ecoOrfirstclass.Text = "Traveler 1 : Economy";
            }
            else if (thisTraveler.typeOfTicket == 2)
            {
                ecoOrfirstclass.Text = "Traveler 1 : First-Class";
            }
            travalerPrice.Text = "$ " + thisTraveler.TicketPrice;
            flightPrice.Text = "$ " + thisTraveler.TicketPrice;
            tripTotalPrice.Text = "$ " + thisTraveler.TicketPrice;
            /* ******* Price Summary ********** */


            /* ******* Check for picking a seat ********** */
            DateTime nowPlus1day = DateTime.Now.AddDays(1);
            int hourdiff = (int)Math.Floor(nowPlus1day.Subtract(tempDepartTime).TotalHours);
            if (thisTraveler.SeatNum == null || thisTraveler.SeatNum == "")   //if the traveler not pick a seat yet
            {
                if (hourdiff >= 0)  //allow to pick seat starting NOW (24 hours before departure)
                {
                    pickButton.Show(); //allow to pick seat starting NOW
                    finalSeatNum.Hide();
                    warningMsg.Hide();
                }
                else //not able to pick seat at this time
                {
                    pickButton.Hide();
                    finalSeatNum.Show();
                    warningMsg.Show();
                }
            }
            else //already have a seat
            {
                finalSeatNum.Text = thisTraveler.SeatNum;
                pickButton.Hide();
                finalSeatNum.Show();
                warningMsg.Hide();
            }
            /* ******* Check for picking a seat ********** */
        }
    }
}
