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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            available_seats = new TextBox();
            dep_date = new DateTimePicker();
            arrival_date = new DateTimePicker();
            label9 = new Label();
            planeID = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(358, 559);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(151, 56);
            button1.TabIndex = 25;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(23, 375);
            label5.Name = "label5";
            label5.Size = new Size(165, 39);
            label5.TabIndex = 24;
            label5.Text = "Destination";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // destination
            // 
            destination.Location = new Point(248, 386);
            destination.Margin = new Padding(3, 4, 3, 4);
            destination.Name = "destination";
            destination.Size = new Size(150, 27);
            destination.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(23, 289);
            label4.Name = "label4";
            label4.Size = new Size(109, 39);
            label4.TabIndex = 22;
            label4.Text = "Source";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // source
            // 
            source.Location = new Point(248, 300);
            source.Margin = new Padding(3, 4, 3, 4);
            source.Name = "source";
            source.Size = new Size(150, 27);
            source.TabIndex = 21;
            source.TextChanged += source_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(23, 203);
            label3.Name = "label3";
            label3.Size = new Size(127, 39);
            label3.TabIndex = 20;
            label3.Text = "Plane ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(136, 39);
            label2.TabIndex = 18;
            label2.Text = "Flight ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // flightID
            // 
            flightID.Location = new Point(248, 128);
            flightID.Margin = new Padding(3, 4, 3, 4);
            flightID.Name = "flightID";
            flightID.Size = new Size(150, 27);
            flightID.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(469, 173);
            label6.Name = "label6";
            label6.Size = new Size(109, 39);
            label6.TabIndex = 27;
            label6.Text = "Arrival";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(468, 93);
            label7.Name = "label7";
            label7.Size = new Size(152, 39);
            label7.TabIndex = 29;
            label7.Text = "Departure";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(23, 461);
            label8.Name = "label8";
            label8.Size = new Size(218, 39);
            label8.TabIndex = 31;
            label8.Text = "Available Seats";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // available_seats
            // 
            available_seats.Location = new Point(248, 472);
            available_seats.Margin = new Padding(3, 4, 3, 4);
            available_seats.Name = "available_seats";
            available_seats.Size = new Size(150, 27);
            available_seats.TabIndex = 30;
            available_seats.TextChanged += textBox7_TextChanged;
            // 
            // dep_date
            // 
            dep_date.Location = new Point(641, 93);
            dep_date.Margin = new Padding(3, 4, 3, 4);
            dep_date.Name = "dep_date";
            dep_date.Size = new Size(228, 27);
            dep_date.TabIndex = 32;
            // 
            // arrival_date
            // 
            arrival_date.Location = new Point(641, 173);
            arrival_date.Margin = new Padding(3, 4, 3, 4);
            arrival_date.Name = "arrival_date";
            arrival_date.Size = new Size(228, 27);
            arrival_date.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(866, 12);
            label9.Name = "label9";
            label9.Size = new Size(37, 36);
            label9.TabIndex = 35;
            label9.Text = "X";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Click += label9_Click;
            // 
            // planeID
            // 
            planeID.Location = new Point(248, 214);
            planeID.Margin = new Padding(3, 4, 3, 4);
            planeID.Name = "planeID";
            planeID.Size = new Size(150, 27);
            planeID.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(314, 35);
            label1.Name = "label1";
            label1.Size = new Size(216, 36);
            label1.TabIndex = 38;
            label1.Text = "Add flight";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(484, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // addFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 648);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "addFlight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addFlight";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox available_seats;
        private DateTimePicker dep_date;
        private DateTimePicker arrival_date;
        private Label label9;
        private TextBox planeID;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}