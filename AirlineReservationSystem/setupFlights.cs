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
    public partial class setupFlights : Form
    {
        AirlineReservationDBEntities db;
        public setupFlights()
        {
            InitializeComponent();
            //database
            db = new AirlineReservationDBEntities();
            clearTxtBox();
        }

        

        //Exit Button Clicked
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ADD Button Clicked
        private void button1_Click(object sender, EventArgs e)
        {
        
            if(AirlineTextBox.Text != "" && FlightNumtextBox.Text != ""
                && depTextBox.Text != "" && arrivalTextBox.Text != "")
            {
                //FIXME (Can't setup a flight that departed within the next 2 hours)
                DateTime nowPlus2hours = DateTime.Now.AddHours(2);
                if(depDateTimePicker.Value < nowPlus2hours) //not able to add new flight
                {
                    MessageBox.Show("The Departure time of the new flight must be at least 2 hours later.");
                }
                else   //departure time at least 2 hours later
                {
                    int dateTimeCompareResult = DateTime.Compare(arrivalDateTimePicker.Value, depDateTimePicker.Value);
                    int minutesDiff = (int)Math.Ceiling(arrivalDateTimePicker.Value.Subtract(depDateTimePicker.Value).TotalMinutes);
                    // if departure time is earlier than arrival time
                    // and minutes different >= 15 mins (allow to add flight)
                    if (dateTimeCompareResult > 0 && minutesDiff >= 15)
                    {
                        bool ableToAdd = true;
                        //flights with the same airlne and same flight number
                        var flights = db.Flights.Where(a => a.Flight_Number.Equals(FlightNumtextBox.Text)
                                                    && a.Airline.Equals(AirlineTextBox.Text)).ToList();
                        //check time conflicts of these flights
                        foreach (var flight in flights)
                        {
                            //if there is no time conflict (same flight can be set in 30 mins)
                            if (flight.Departure_Time.Value.Subtract(arrivalDateTimePicker.Value).TotalMinutes >= 30     //case 1 (before the exist flight)
                                    || (depDateTimePicker.Value.Subtract(flight.Arrival_Time.Value).TotalMinutes >= 30)) //case 2 (after the exist flight)
                            {
                                ableToAdd = true;
                            }
                            else
                            {
                                ableToAdd = false;
                                break;
                            }
                        }
                        if (ableToAdd)
                        {
                            //create a new flight class
                            Flight newFlight = new Flight();
                            newFlight.Airline = AirlineTextBox.Text;
                            newFlight.Flight_Number = FlightNumtextBox.Text;
                            newFlight.Economy_Price = ecoPrice.Value;
                            newFlight.FirstClass_Price = firstClassPrice.Value;
                            newFlight.Seat_Capacity = Convert.ToInt32(Math.Round(seatValue.Value, 0));
                            newFlight.Seat_Left = Convert.ToInt32(Math.Round(seatValue.Value, 0));
                            newFlight.Departure = depTextBox.Text;
                            newFlight.Arrival = arrivalTextBox.Text;
                            newFlight.Departure_Time = depDateTimePicker.Value;
                            newFlight.Arrival_Time = arrivalDateTimePicker.Value;

                            // Add & update database
                            db.Flights.Add(newFlight);
                            db.SaveChanges();
                            MessageBox.Show("Successfully add a new flight to the database.");
                            clearTxtBox();  // reset
                        }
                        else
                        {
                            MessageBox.Show("Time conflict with a exist flight.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Check the Time of the Flight (>= 15 mins)!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Out the Form & Check the Time of the Flight (>= 15 mins)!");
            }

        }

        //clear textbox inputs
        public void clearTxtBox()
        {
            AirlineTextBox.Text = "";
            FlightNumtextBox.Text = "";
            depTextBox.Text = "";
            arrivalTextBox.Text = "";
            ecoPrice.Value = 0;
            firstClassPrice.Value = 0;
            seatValue.Value = 20; //minimum seats for every plane
            depDateTimePicker.Value = DateTime.Now;
            arrivalDateTimePicker.Value = DateTime.Now;
        }
    }
}
