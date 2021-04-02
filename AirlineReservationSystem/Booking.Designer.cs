namespace AirlineReservationSystem
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.FlightsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EcoRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstClassRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.EnterInformation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.selectedFlightAirlineLabel = new System.Windows.Forms.Label();
            this.selectedFlightNumberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.depLocation = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.arrivalLocation = new System.Windows.Forms.Label();
            this.flightTimeLabel = new System.Windows.Forms.Label();
            this.depatureTime = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Flights Available For Reservation";
            // 
            // FlightsDataGridView
            // 
            this.FlightsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FlightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FlightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FlightsDataGridView.Location = new System.Drawing.Point(12, 55);
            this.FlightsDataGridView.Name = "FlightsDataGridView";
            this.FlightsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FlightsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FlightsDataGridView.RowTemplate.Height = 30;
            this.FlightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightsDataGridView.Size = new System.Drawing.Size(1275, 343);
            this.FlightsDataGridView.TabIndex = 1;
            this.FlightsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightsDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passenger\'s Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // EcoRadioButton
            // 
            this.EcoRadioButton.AutoSize = true;
            this.EcoRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EcoRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcoRadioButton.Location = new System.Drawing.Point(914, 702);
            this.EcoRadioButton.Name = "EcoRadioButton";
            this.EcoRadioButton.Size = new System.Drawing.Size(95, 23);
            this.EcoRadioButton.TabIndex = 5;
            this.EcoRadioButton.TabStop = true;
            this.EcoRadioButton.Text = "Economy";
            this.EcoRadioButton.UseVisualStyleBackColor = true;
            this.EcoRadioButton.CheckedChanged += new System.EventHandler(this.EcoRadioButton_CheckedChanged);
            // 
            // FirstClassRadioButton
            // 
            this.FirstClassRadioButton.AutoSize = true;
            this.FirstClassRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstClassRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstClassRadioButton.Location = new System.Drawing.Point(1020, 702);
            this.FirstClassRadioButton.Name = "FirstClassRadioButton";
            this.FirstClassRadioButton.Size = new System.Drawing.Size(104, 23);
            this.FirstClassRadioButton.TabIndex = 6;
            this.FirstClassRadioButton.TabStop = true;
            this.FirstClassRadioButton.Text = "First-Class";
            this.FirstClassRadioButton.UseVisualStyleBackColor = true;
            this.FirstClassRadioButton.CheckedChanged += new System.EventHandler(this.FirstClassRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(780, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ticket :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(377, 494);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(222, 26);
            this.nameTextBox.TabIndex = 9;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(377, 537);
            this.age.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(51, 22);
            this.age.TabIndex = 10;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(377, 585);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(222, 26);
            this.emailTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addressTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(377, 631);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(222, 26);
            this.addressTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(780, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Flight # :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(781, 750);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ticket Price :";
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPriceLabel.Location = new System.Drawing.Point(910, 743);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(224, 26);
            this.ticketPriceLabel.TabIndex = 16;
            this.ticketPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterInformation
            // 
            this.EnterInformation.AutoSize = true;
            this.EnterInformation.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInformation.Location = new System.Drawing.Point(252, 424);
            this.EnterInformation.Name = "EnterInformation";
            this.EnterInformation.Size = new System.Drawing.Size(256, 24);
            this.EnterInformation.TabIndex = 17;
            this.EnterInformation.Text = "Passenger\'s Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(832, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Selected Flight Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(780, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Airline :";
            // 
            // selectedFlightAirlineLabel
            // 
            this.selectedFlightAirlineLabel.BackColor = System.Drawing.SystemColors.Info;
            this.selectedFlightAirlineLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFlightAirlineLabel.Location = new System.Drawing.Point(920, 475);
            this.selectedFlightAirlineLabel.Name = "selectedFlightAirlineLabel";
            this.selectedFlightAirlineLabel.Size = new System.Drawing.Size(192, 23);
            this.selectedFlightAirlineLabel.TabIndex = 20;
            this.selectedFlightAirlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFlightNumberLabel
            // 
            this.selectedFlightNumberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.selectedFlightNumberLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFlightNumberLabel.Location = new System.Drawing.Point(920, 516);
            this.selectedFlightNumberLabel.Name = "selectedFlightNumberLabel";
            this.selectedFlightNumberLabel.Size = new System.Drawing.Size(192, 23);
            this.selectedFlightNumberLabel.TabIndex = 21;
            this.selectedFlightNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(405, 729);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(815, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Departure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(1054, 568);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Arrival";
            // 
            // depLocation
            // 
            this.depLocation.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depLocation.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.depLocation.Location = new System.Drawing.Point(787, 622);
            this.depLocation.Name = "depLocation";
            this.depLocation.Size = new System.Drawing.Size(135, 31);
            this.depLocation.TabIndex = 26;
            this.depLocation.Text = "N/A";
            this.depLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::AirlineReservationSystem.Properties.Resources.rightarrow_50x30;
            this.label14.Location = new System.Drawing.Point(928, 623);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 27;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrivalLocation
            // 
            this.arrivalLocation.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalLocation.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.arrivalLocation.Location = new System.Drawing.Point(1017, 622);
            this.arrivalLocation.Name = "arrivalLocation";
            this.arrivalLocation.Size = new System.Drawing.Size(135, 31);
            this.arrivalLocation.TabIndex = 28;
            this.arrivalLocation.Text = "N/A";
            this.arrivalLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flightTimeLabel
            // 
            this.flightTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightTimeLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flightTimeLabel.Location = new System.Drawing.Point(919, 604);
            this.flightTimeLabel.Name = "flightTimeLabel";
            this.flightTimeLabel.Size = new System.Drawing.Size(99, 19);
            this.flightTimeLabel.TabIndex = 29;
            this.flightTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depatureTime
            // 
            this.depatureTime.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depatureTime.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.depatureTime.Location = new System.Drawing.Point(787, 660);
            this.depatureTime.Name = "depatureTime";
            this.depatureTime.Size = new System.Drawing.Size(135, 21);
            this.depatureTime.TabIndex = 31;
            this.depatureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTime.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.arrivalTime.Location = new System.Drawing.Point(1017, 660);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(135, 21);
            this.arrivalTime.TabIndex = 32;
            this.arrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1299, 805);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.depatureTime);
            this.Controls.Add(this.flightTimeLabel);
            this.Controls.Add(this.arrivalLocation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.depLocation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedFlightNumberLabel);
            this.Controls.Add(this.selectedFlightAirlineLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EnterInformation);
            this.Controls.Add(this.ticketPriceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstClassRadioButton);
            this.Controls.Add(this.EcoRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlightsDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FlightsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EcoRadioButton;
        private System.Windows.Forms.RadioButton FirstClassRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.Label EnterInformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label selectedFlightNumberLabel;
        private System.Windows.Forms.Label selectedFlightAirlineLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label depLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label arrivalLocation;
        private System.Windows.Forms.Label flightTimeLabel;
        private System.Windows.Forms.Label depatureTime;
        private System.Windows.Forms.Label arrivalTime;
    }
}