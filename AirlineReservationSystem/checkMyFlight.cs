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
    public partial class checkMyFlight : Form
    {
        AirlineReservationDBEntities db;
        public checkMyFlight()
        {
            InitializeComponent();
            db = new AirlineReservationDBEntities();
        }

        //Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search Button
        private void button1_Click(object sender, EventArgs e)
        {
            if(passengerName.Text != "" && confirmNum.Text != "")
            {
                var result = db.Customers.Where(a => a.FullName.Equals(passengerName.Text)
                                            && a.FlightConfirmNumber.Equals(confirmNum.Text)).SingleOrDefault();
                if(result != null)  //found customer's ticket
                {
                    //close this form
                    this.Close();
                    this.Hide();

                    //open Ticket form
                    Ticket ticket = new Ticket(passengerName.Text, confirmNum.Text);
                    ticket.ShowDialog();
                }
                else
                {
                    MessageBox.Show("We can't find this ticket." + Environment.NewLine 
                        + "Please enter the correct confirmation number!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Passenger's Name and Comfirmation Number");
            }
        }
    }
}
