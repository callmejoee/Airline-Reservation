namespace Airline_Reservation
{
    partial class userHome
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
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(497, 363);
            button6.Name = "button6";
            button6.Size = new Size(140, 23);
            button6.TabIndex = 21;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(317, 363);
            button5.Name = "button5";
            button5.Size = new Size(140, 23);
            button5.TabIndex = 20;
            button5.Text = "Book a ticket";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(125, 363);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 19;
            button3.Text = "View Flights";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 9);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 18;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 17;
            label1.Text = "Home";
            // 
            // userHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button3;
        private Label label2;
        private Label label1;
    }
}