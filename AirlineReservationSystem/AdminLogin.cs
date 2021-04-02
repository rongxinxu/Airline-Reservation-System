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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            AirlineReservationDBEntities db = new AirlineReservationDBEntities();
            if(usernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                var admin = db.Admins.Where(a => a.Username.Equals(usernameTextBox.Text)).SingleOrDefault();
                if(admin != null)
                {
                    if (admin.Password.Equals(PasswordTextBox.Text))
                    {
                        //MessageBox.Show("Login Successfully!");
                        this.Close();
                        this.Hide();

                        //open new form for admin to setup a flight
                        setupFlights setupFlight = new setupFlights();
                        setupFlight.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password. :( ");
                    }
                }
                else
                {
                    MessageBox.Show("This admin account does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username & Password!");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
