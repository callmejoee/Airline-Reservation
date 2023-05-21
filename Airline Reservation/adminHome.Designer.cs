namespace Airline_Reservation
{
    partial class adminHome
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(397, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(872, 9);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(79, 339);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Passenger";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(648, 339);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 3;
            button2.Text = "Add Aircraft";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(448, 339);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 4;
            button3.Text = "View Flights";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(266, 339);
            button4.Name = "button4";
            button4.Size = new Size(164, 23);
            button4.TabIndex = 5;
            button4.Text = "Add flight";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(252, 392);
            button5.Name = "button5";
            button5.Size = new Size(140, 23);
            button5.TabIndex = 6;
            button5.Text = "Book a ticket";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(448, 392);
            button6.Name = "button6";
            button6.Size = new Size(140, 23);
            button6.TabIndex = 7;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(79, 392);
            button7.Name = "button7";
            button7.Size = new Size(148, 23);
            button7.TabIndex = 8;
            button7.Text = "View Passengers";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // adminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 491);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}