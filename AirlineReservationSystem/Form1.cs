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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            Booking bookingPage = new Booking();
            bookingPage.ShowDialog();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginPage = new AdminLogin();
            adminLoginPage.ShowDialog();
        }

        private void CheckMyFlightBtn_Click_1(object sender, EventArgs e)
        {
            checkMyFlight checkMyFlightPage = new checkMyFlight();
            checkMyFlightPage.ShowDialog();
        }
    }
}
