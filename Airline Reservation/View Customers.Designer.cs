namespace Airline_Reservation
{
    partial class View_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Customers));
            label8 = new Label();
            label1 = new Label();
            pass_list = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            firstName = new TextBox();
            label2 = new Label();
            lastName = new TextBox();
            label3 = new Label();
            passIDt = new TextBox();
            passengerID = new Label();
            label6 = new Label();
            label7 = new Label();
            ssn = new TextBox();
            label10 = new Label();
            label4 = new Label();
            city = new TextBox();
            label11 = new Label();
            country = new TextBox();
            label12 = new Label();
            label5 = new Label();
            date = new DateTimePicker();
            gender = new TextBox();
            nationality = new TextBox();
            email = new TextBox();
            label9 = new Label();
            password = new TextBox();
            button1 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pass_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(922, 9);
            label8.Name = "label8";
            label8.Size = new Size(31, 29);
            label8.TabIndex = 72;
            label8.Text = "X";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(356, 20);
            label1.Name = "label1";
            label1.Size = new Size(215, 29);
            label1.TabIndex = 61;
            label1.Text = "View Passengers";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pass_list
            // 
            pass_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pass_list.Location = new Point(55, 428);
            pass_list.Name = "pass_list";
            pass_list.RowTemplate.Height = 25;
            pass_list.Size = new Size(823, 274);
            pass_list.TabIndex = 81;
            pass_list.CellContentClick += pass_list_CellContentClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(705, 368);
            button4.Name = "button4";
            button4.Size = new Size(132, 42);
            button4.TabIndex = 80;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(549, 368);
            button3.Name = "button3";
            button3.Size = new Size(132, 42);
            button3.TabIndex = 79;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(399, 368);
            button2.Name = "button2";
            button2.Size = new Size(132, 42);
            button2.TabIndex = 78;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(222, 104);
            firstName.Name = "firstName";
            firstName.Size = new Size(132, 23);
            firstName.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(86, 104);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 99;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lastName
            // 
            lastName.Location = new Point(222, 133);
            lastName.Name = "lastName";
            lastName.Size = new Size(132, 23);
            lastName.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(86, 138);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 101;
            label3.Text = "Last name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // passIDt
            // 
            passIDt.Location = new Point(222, 53);
            passIDt.Name = "passIDt";
            passIDt.Size = new Size(109, 23);
            passIDt.TabIndex = 102;
            // 
            // passengerID
            // 
            passengerID.AutoSize = true;
            passengerID.BackColor = Color.Transparent;
            passengerID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passengerID.ImageAlign = ContentAlignment.TopCenter;
            passengerID.Location = new Point(86, 58);
            passengerID.Name = "passengerID";
            passengerID.Size = new Size(109, 18);
            passengerID.TabIndex = 103;
            passengerID.Text = "Passenger ID";
            passengerID.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(86, 315);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 104;
            label6.Text = "Gender";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(516, 261);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 105;
            label7.Text = "Nationality";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // ssn
            // 
            ssn.Location = new Point(222, 280);
            ssn.Name = "ssn";
            ssn.Size = new Size(132, 23);
            ssn.TabIndex = 108;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.TopCenter;
            label10.Location = new Point(86, 285);
            label10.Name = "label10";
            label10.Size = new Size(42, 18);
            label10.TabIndex = 107;
            label10.Text = "SSN";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(516, 91);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 120;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // city
            // 
            city.Location = new Point(222, 178);
            city.Name = "city";
            city.Size = new Size(132, 23);
            city.TabIndex = 109;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(86, 183);
            label11.Name = "label11";
            label11.Size = new Size(37, 18);
            label11.TabIndex = 110;
            label11.Text = "City";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // country
            // 
            country.Location = new Point(222, 212);
            country.Name = "country";
            country.Size = new Size(132, 23);
            country.TabIndex = 111;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(86, 217);
            label12.Name = "label12";
            label12.Size = new Size(67, 18);
            label12.TabIndex = 112;
            label12.Text = "Country";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(516, 193);
            label5.Name = "label5";
            label5.Size = new Size(101, 18);
            label5.TabIndex = 113;
            label5.Text = "Date of birth";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // date
            // 
            date.Location = new Point(654, 193);
            date.Name = "date";
            date.Size = new Size(183, 23);
            date.TabIndex = 114;
            // 
            // gender
            // 
            gender.Location = new Point(222, 315);
            gender.Name = "gender";
            gender.Size = new Size(132, 23);
            gender.TabIndex = 115;
            // 
            // nationality
            // 
            nationality.Location = new Point(654, 256);
            nationality.Name = "nationality";
            nationality.Size = new Size(132, 23);
            nationality.TabIndex = 116;
            // 
            // email
            // 
            email.Location = new Point(654, 63);
            email.Name = "email";
            email.Size = new Size(132, 23);
            email.TabIndex = 117;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(516, 68);
            label9.Name = "label9";
            label9.Size = new Size(50, 18);
            label9.TabIndex = 118;
            label9.Text = "Email";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // password
            // 
            password.Location = new Point(654, 92);
            password.Name = "password";
            password.Size = new Size(132, 23);
            password.TabIndex = 119;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(248, 368);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 121;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(99, 368);
            button5.Name = "button5";
            button5.Size = new Size(132, 42);
            button5.TabIndex = 122;
            button5.Text = "Select";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(868, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // View_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 725);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(label9);
            Controls.Add(email);
            Controls.Add(nationality);
            Controls.Add(gender);
            Controls.Add(date);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(country);
            Controls.Add(label11);
            Controls.Add(city);
            Controls.Add(ssn);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(passengerID);
            Controls.Add(passIDt);
            Controls.Add(label3);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(pass_list);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Customers";
            Load += View_Customers_Load;
            ((System.ComponentModel.ISupportInitialize)pass_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label1;
        private DataGridView pass_list;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox firstName;
        private Label label2;
        private TextBox lastName;
        private Label label3;
        private TextBox passIDt;
        private Label passengerID;
        private Label label6;
        private Label label7;
        private TextBox ssn;
        private Label label10;
        private Label label4;
        private TextBox city;
        private Label label11;
        private TextBox country;
        private Label label12;
        private Label label5;
        private DateTimePicker date;
        private TextBox gender;
        private TextBox nationality;
        private TextBox email;
        private Label label9;
        private TextBox password;
        private Button button1;
        private Button button5;
        private PictureBox pictureBox1;
    }
}