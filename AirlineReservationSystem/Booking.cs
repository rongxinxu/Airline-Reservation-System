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
    public partial class Booking : Form
    {
        //global variables
        AirlineReservationDBEntities db;
        public Booking()
        {
            InitializeComponent();
            db = new AirlineReservationDBEntities();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            //autoSize for headers and each row cell's text alignment = middlerCenter
            FlightsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            FlightsDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DateTime now = DateTime.Now;
            DateTime nowPlus60Mins = now.AddMinutes(60);
            //ONLY return the Flights departing in 1 hour or later AND there are some seats left
            FlightsDataGridView.DataSource = db.Flights.Where(a => a.Departure_Time.Value > nowPlus60Mins && a.Seat_Left > 0).ToList();
            //change price format
            FlightsDataGridView.Columns[3].DefaultCellStyle.Format = "C";
            FlightsDataGridView.Columns[4].DefaultCellStyle.Format = "C";

            //Hide ID and Customer column
            FlightsDataGridView.Columns["Id"].Visible = false;
            FlightsDataGridView.Columns["Customers"].Visible = false;
        }

        /*           Update Flight number when selecting different row       */
        private void FlightsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var flightAirline = FlightsDataGridView.SelectedRows[0].Cells[1].Value;
            var flightNum = FlightsDataGridView.SelectedRows[0].Cells[2].Value;
            selectedFlightAirlineLabel.Text = flightAirline.ToString();
            selectedFlightNumberLabel.Text = flightNum.ToString();

            if (EcoRadioButton.Checked)
            {
                ticketPriceLabel.Text = "$ " + FlightsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }else if (FirstClassRadioButton.Checked)
            {
                ticketPriceLabel.Text = "$ " + FlightsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }

            //calculate & get total flight time
            var flightDepTime = DateTime.Parse(FlightsDataGridView.SelectedRows[0].Cells[9].Value.ToString());
            var flightArrivalTime = DateTime.Parse(FlightsDataGridView.SelectedRows[0].Cells[10].Value.ToString());
            TimeSpan totalFlightTime = TimeSpan.FromMilliseconds(flightArrivalTime.Subtract(flightDepTime).TotalMilliseconds);
            flightTimeLabel.Text = totalFlightTime.Hours + "h " + totalFlightTime.Minutes + "m";
            //display departure & arrival time
            depatureTime.Text = FlightsDataGridView.SelectedRows[0].Cells[9].FormattedValue.ToString();
            arrivalTime.Text = FlightsDataGridView.SelectedRows[0].Cells[10].FormattedValue.ToString();

            //display departure & arrival location
            depLocation.Text = FlightsDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            arrivalLocation.Text = FlightsDataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void EcoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ticketPriceLabel.Text = "$ " + FlightsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void FirstClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ticketPriceLabel.Text = "$ " + FlightsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        //BOOK Button
        private void button1_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "")
            {
                //if there is no flight selected
                if(selectedFlightAirlineLabel.Text == "" 
                    || (!EcoRadioButton.Checked && !FirstClassRadioButton.Checked))
                {
                    MessageBox.Show("Please Select Your Flight And Type of Ticket!");
                }
                else // add Customer and update flight information
                {
                    int selectedFlightId = Convert.ToInt32(FlightsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    var selectedFlight = db.Flights.Where(a => a.Id == selectedFlightId).SingleOrDefault();

                    Customer newPassenger = new Customer();
                    newPassenger.FullName = nameTextBox.Text;
                    newPassenger.Age = (int)age.Value;
                    newPassenger.Email = emailTextBox.Text;
                    newPassenger.address = addressTextBox.Text;
                    newPassenger.SeatNum = "";   //not able to select seat yet

                    //newPassenger.FlightNumber = selectedFlightNumberLabel.Text;
                    newPassenger.FlightConfirmNumber = generateConfirmNum(5);
                    if (EcoRadioButton.Checked) //ticket: 1 = economy, 2 = firstClass
                    {
                        var allTravelersWithEco = db.Customers.Where(a => a.FlightID == selectedFlightId && a.typeOfTicket == 1).ToList();
                        if(allTravelersWithEco.Count() == (selectedFlight.Seat_Capacity - 18))  //Economy Ticket Full
                        {
                            MessageBox.Show("Sorry. There are no more Economy ticket left!" + Environment.NewLine
                                            + "Try upgrade to First-Class ticket.");
                            return;
                        }
                        newPassenger.typeOfTicket = 1; //Economy Ticket
                        newPassenger.TicketPrice = FlightsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    }
                    else if (FirstClassRadioButton.Checked)
                    {
                        var allTravelersWith1stClass = db.Customers.Where(a => a.FlightID == selectedFlightId && a.typeOfTicket == 2).ToList();
                        if (allTravelersWith1stClass.Count() == 18) //First Class ticket Full
                        {
                            MessageBox.Show("Sorry. There are no more First-Class ticket left!" + Environment.NewLine
                                            + "Try select Economy ticket.");
                            return;
                        }
                        newPassenger.typeOfTicket = 2; //1st Class ticket
                        newPassenger.TicketPrice = FlightsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    }
                    
                    newPassenger.FlightID = selectedFlightId;
                    //add new traveler (customer)
                    db.Customers.Add(newPassenger);
                    db.SaveChanges();

                    //find this selected flight and update seat capacity
                    selectedFlight.Seat_Left -= 1;
                    db.SaveChanges();

                    //Success msg
                    MessageBox.Show("Thank you! You successfully booked a flight!" + Environment.NewLine
                                    + "Airline: " + selectedFlight.Airline + Environment.NewLine
                                    + "Flight Number: " + selectedFlight.Flight_Number + Environment.NewLine
                                    + "Departure: " + selectedFlight.Departure + Environment.NewLine
                                    + "Departure Time: " + selectedFlight.Departure_Time.ToString() + Environment.NewLine
                                    + "Arrival: " + selectedFlight.Arrival + Environment.NewLine
                                    + "Arriavl Time: " + selectedFlight.Arrival_Time.ToString() + Environment.NewLine
                                    + "CONFIRMATION NUMBER : " + newPassenger.FlightConfirmNumber);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Out Passenger's Information!");
            }
        }
        
        //EXIT Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Generate Random Flight Confirmation Number
        private string generateConfirmNum(int size)
        {
            Random rand = new Random();
            const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = pool[rand.Next(pool.Length)];
            }
            return new string(chars);
        }
    }
}
