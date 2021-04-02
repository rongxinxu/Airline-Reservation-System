namespace AirlineReservationSystem
{
    partial class Form1
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

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BookNowBtn;
        private System.Windows.Forms.Button AdminLoginBtn;
        private System.Windows.Forms.Button CheckMyFlightBtn;

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.BookNowBtn = new System.Windows.Forms.Button();
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.CheckMyFlightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(256, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(658, 125);
            this.Title.TabIndex = 0;
            this.Title.Text = "CheapAirTicket";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookNowBtn
            // 
            this.BookNowBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookNowBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BookNowBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.BookNowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookNowBtn.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.BookNowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.BookNowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.BookNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNowBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNowBtn.Location = new System.Drawing.Point(126, 237);
            this.BookNowBtn.Name = "BookNowBtn";
            this.BookNowBtn.Size = new System.Drawing.Size(151, 51);
            this.BookNowBtn.TabIndex = 1;
            this.BookNowBtn.Text = "Book Now";
            this.BookNowBtn.UseVisualStyleBackColor = false;
            this.BookNowBtn.Click += new System.EventHandler(this.BookNowBtn_Click);
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AdminLoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AdminLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AdminLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AdminLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLoginBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.Location = new System.Drawing.Point(126, 319);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(151, 51);
            this.AdminLoginBtn.TabIndex = 2;
            this.AdminLoginBtn.Text = "Admin Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = false;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // CheckMyFlightBtn
            // 
            this.CheckMyFlightBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckMyFlightBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckMyFlightBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckMyFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckMyFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckMyFlightBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckMyFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CheckMyFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckMyFlightBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMyFlightBtn.Location = new System.Drawing.Point(126, 398);
            this.CheckMyFlightBtn.Name = "CheckMyFlightBtn";
            this.CheckMyFlightBtn.Size = new System.Drawing.Size(151, 51);
            this.CheckMyFlightBtn.TabIndex = 3;
            this.CheckMyFlightBtn.Text = "CheckMyFlight";
            this.CheckMyFlightBtn.UseVisualStyleBackColor = false;
            this.CheckMyFlightBtn.Click += new System.EventHandler(this.CheckMyFlightBtn_Click_1);
            // 
            // Form1
            // 
            this.BackgroundImage = global::AirlineReservationSystem.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 742);
            this.Controls.Add(this.CheckMyFlightBtn);
            this.Controls.Add(this.AdminLoginBtn);
            this.Controls.Add(this.BookNowBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Airline Reservation System";
            this.ResumeLayout(false);

        }
    }
}

