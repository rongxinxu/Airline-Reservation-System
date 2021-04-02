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
    public partial class Seats : Form
    {
        private Customer traveler;
        private Flight flight;
        private string confirmNum;
        AirlineReservationDBEntities db;
        public Seats(Customer traveler1, Flight flight1, string confirmNum1)
        {
            InitializeComponent();
            traveler = traveler1;
            flight = flight1;
            confirmNum = confirmNum1;
            db = new AirlineReservationDBEntities();
        }

        //Page Load
        private void Seats_Load(object sender, EventArgs e)
        {
            //Print Flight Info and traveler's name
            airlineAndFlightNum.Text = flight.Airline + " " + flight.Flight_Number;
            travelerName.Text = traveler.FullName;

            //flight total seat capacity
            int totalSeats = Convert.ToInt32(flight.Seat_Capacity);

            int firstClassSeat = 18; //set this default for every plane (assuming)
            int ecoSeats = totalSeats - firstClassSeat;

            //Load seating chart ( / update the chart)
            var allTravelerwithSamePlane = db.Customers.Where(a => a.FlightID == flight.Id).ToList();

            //get all takenSeats Number
            List<string> takenSeats = new List<string>();
            for (int i = 0; i < allTravelerwithSamePlane.Count(); i++)
            {
                //check to see if any seats already taken
                if(allTravelerwithSamePlane[i].SeatNum != "")
                {
                    takenSeats.Add(allTravelerwithSamePlane[i].SeatNum);
                }
            }

            if (traveler.typeOfTicket == 1)  // if economy ticket, display economy seating chart
            {
                seatingChartTitle.Text = "Economy Seating Chart";
                economyPanel.Show();
                firstClassPanel.Hide();
            }
            else if (traveler.typeOfTicket == 2) // if 1st-class ticket, display 1st-class seating chart
            {
                seatingChartTitle.Text = "First-Class Seating Chart";
                economyPanel.Hide();
                firstClassPanel.Show();
            }

            //Create Seating Chart

            /*******************   First Class Seating Chart  ********************/
            createSeatingChart(firstClassPanel, takenSeats, firstClassSeat);
            /*******************   First Class Seating Chart  ********************/

            /*******************   Economy Ticket Seating Chart  ********************/
            createSeatingChart(economyPanel, takenSeats, ecoSeats);
            /*******************   Economy Ticket Seating Chart  ********************/

        }

        private void createSeatingChart(Panel displayPanel, List<string> takenSeats, int numOfSeats)
        {
            int widthSpaces = 20;
            int xPos = 0;
            int yPos = 20;
            int count = 0;

            List<Label> labels = new List<Label>();

            //Creat seating chart
            for (int i = 0; i < numOfSeats; i++)
            {
                labels.Add(new Label());
                string seatNum = "";
                if (traveler.typeOfTicket == 2)  //1st Class
                {
                    seatNum = "A" + (i + 1);
                }
                else if (traveler.typeOfTicket == 1)   // economy
                {
                    seatNum = "B" + (i + 1);
                }

                labels[i].Text = seatNum;
                labels[i].Size = new Size(45, 40);
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                labels[i].Font = new Font("Arial", 10, FontStyle.Bold);
                labels[i].TextAlign = ContentAlignment.MiddleCenter;

                //Default, unselected seats are displayed in lightgreen
                labels[i].BackColor = Color.LightGreen;
                labels[i].Cursor = Cursors.Hand;
                //add event handlers
                labels[i].MouseEnter += new EventHandler(seats_MouseEnter);
                labels[i].MouseLeave += new EventHandler(seats_MouseLeave);
                labels[i].Click += new EventHandler(seats_Click);

                //find the taken seats and set thems to be gray
                if (takenSeats.Count() > 0)
                {
                    for (int j = 0; j < takenSeats.Count(); j++)
                    {
                        if (seatNum == takenSeats[j])    //the seats already taken
                        {
                            labels[i].BackColor = Color.LightGray;
                            labels[i].Cursor = Cursors.Default;
                            //remove event handlers
                            labels[i].MouseEnter -= seats_MouseEnter;
                            labels[i].MouseLeave -= seats_MouseLeave;
                            labels[i].Click -= seats_Click;
                        }
                    }
                }

                if (count == 4)
                {
                    count = 0;  //reset to 0
                    xPos = 0;
                    widthSpaces = 20;
                    yPos += 50;
                }
                labels[i].Location = new System.Drawing.Point(xPos + widthSpaces, yPos);

                displayPanel.Controls.Add(labels[i]);
                widthSpaces += 50;
                count++;
            }
        }

        private void seats_MouseEnter(object sender, System.EventArgs e)
        {
            ((Label)sender).BackColor = Color.LightBlue;
        }

        private void seats_MouseLeave(object sender, System.EventArgs e)
        {
            ((Label)sender).BackColor = Color.LightGreen;
        }

        private void seats_Click(object sender, System.EventArgs e)
        {
            seatNumLabel.Text = ((Label)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(seatNumLabel.Text != "")
            {
                var thisTraveler = db.Customers.Where(a => a.FullName == traveler.FullName 
                                && a.FlightConfirmNumber == confirmNum).SingleOrDefault();
                thisTraveler.SeatNum = seatNumLabel.Text;
                db.SaveChanges();   // update database
                MessageBox.Show("Successfully! Your seat number is : " + thisTraveler.SeatNum);
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select your seat!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Seats_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            //Re-open the Ticket form
            Ticket ticket = new Ticket(traveler.FullName, confirmNum);
            ticket.ShowDialog();
        }
    }
}
