namespace Airline_Reservation
{
    partial class addFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFlight));
            button1 = new Button();
            label5 = new Label();
            destination = new TextBox();
            label4 = new Label();
            source = new TextBox();
            label3 = new Label();
            label2 = new Label();
            flightID = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            available_seats = new TextBox();
            dep_date = new DateTimePicker();
            arrival_date = new DateTimePicker();
            label9 = new Label();
            planeID = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(373, 376);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 25;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(21, 267);
            label5.Name = "label5";
            label5.Size = new Size(144, 29);
            label5.TabIndex = 24;
            label5.Text = "Destination";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // destination
            // 
            destination.Location = new Point(175, 273);
            destination.Name = "destination";
            destination.Size = new Size(132, 23);
            destination.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(20, 199);
            label4.Name = "label4";
            label4.Size = new Size(96, 29);
            label4.TabIndex = 22;
            label4.Text = "Source";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // source
            // 
            source.Location = new Point(175, 205);
            source.Name = "source";
            source.Size = new Size(132, 23);
            source.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(21, 130);
            label3.Name = "label3";
            label3.Size = new Size(112, 29);
            label3.TabIndex = 20;
            label3.Text = "Plane ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 18;
            label2.Text = "Flight ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // flightID
            // 
            flightID.Location = new Point(175, 59);
            flightID.Name = "flightID";
            flightID.Size = new Size(132, 23);
            flightID.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 16;
            label1.Text = "Add Flight";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(426, 132);
            label6.Name = "label6";
            label6.Size = new Size(87, 29);
            label6.TabIndex = 27;
            label6.Text = "Arrival";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(426, 64);
            label7.Name = "label7";
            label7.Size = new Size(129, 29);
            label7.TabIndex = 29;
            label7.Text = "Departure";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(381, 215);
            label8.Name = "label8";
            label8.Size = new Size(193, 29);
            label8.TabIndex = 31;
            label8.Text = "Available Seats";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // available_seats
            // 
            available_seats.Location = new Point(580, 221);
            available_seats.Name = "available_seats";
            available_seats.Size = new Size(132, 23);
            available_seats.TabIndex = 30;
            available_seats.TextChanged += textBox7_TextChanged;
            // 
            // dep_date
            // 
            dep_date.Location = new Point(561, 70);
            dep_date.Name = "dep_date";
            dep_date.Size = new Size(200, 23);
            dep_date.TabIndex = 32;
            // 
            // arrival_date
            // 
            arrival_date.Location = new Point(561, 130);
            arrival_date.Name = "arrival_date";
            arrival_date.Size = new Size(200, 23);
            arrival_date.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(758, 9);
            label9.Name = "label9";
            label9.Size = new Size(31, 29);
            label9.TabIndex = 35;
            label9.Text = "X";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Click += label9_Click;
            // 
            // planeID
            // 
            planeID.Location = new Point(175, 130);
            planeID.Name = "planeID";
            planeID.Size = new Size(132, 23);
            planeID.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(704, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 486);
            Controls.Add(pictureBox1);
            Controls.Add(planeID);
            Controls.Add(label9);
            Controls.Add(arrival_date);
            Controls.Add(dep_date);
            Controls.Add(label8);
            Controls.Add(available_seats);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(destination);
            Controls.Add(label4);
            Controls.Add(source);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flightID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addFlight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addFlight";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox destination;
        private Label label4;
        private TextBox source;
        private Label label3;
        private Label label2;
        private TextBox flightID;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox available_seats;
        private DateTimePicker dep_date;
        private DateTimePicker arrival_date;
        private Label label9;
        private TextBox planeID;
        private PictureBox pictureBox1;
    }
}