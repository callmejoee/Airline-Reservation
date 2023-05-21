namespace Airline_Reservation
{
    partial class addAircraft
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
            planeID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            model = new TextBox();
            label5 = new Label();
            airline = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(387, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 3;
            label1.Text = "Add Aircraft";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // planeID
            // 
            planeID.Location = new Point(163, 69);
            planeID.Name = "planeID";
            planeID.Size = new Size(132, 23);
            planeID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(9, 63);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 8;
            label2.Text = "Plane ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(9, 140);
            label3.Name = "label3";
            label3.Size = new Size(86, 29);
            label3.TabIndex = 10;
            label3.Text = "Model";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // model
            // 
            model.Location = new Point(163, 146);
            model.Name = "model";
            model.Size = new Size(132, 23);
            model.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(9, 213);
            label5.Name = "label5";
            label5.Size = new Size(88, 29);
            label5.TabIndex = 14;
            label5.Text = "Airline";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // airline
            // 
            airline.Location = new Point(163, 213);
            airline.Name = "airline";
            airline.Size = new Size(132, 23);
            airline.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(424, 431);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(908, 9);
            label4.Name = "label4";
            label4.Size = new Size(31, 29);
            label4.TabIndex = 16;
            label4.Text = "X";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // addAircraft
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 533);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(airline);
            Controls.Add(label3);
            Controls.Add(model);
            Controls.Add(label2);
            Controls.Add(planeID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addAircraft";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addAircraft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox planeID;
        private Label label2;
        private Label label3;
        private TextBox model;
        private Label label5;
        private TextBox airline;
        private Button button1;
        private Label label4;
    }
}