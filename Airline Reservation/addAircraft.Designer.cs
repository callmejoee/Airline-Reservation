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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAircraft));
            label1 = new Label();
            planeID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            model = new TextBox();
            label5 = new Label();
            airline = new TextBox();
            button1 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(270, 35);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 3;
            label1.Text = "Add Aircraft";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // planeID
            // 
            planeID.Location = new Point(388, 122);
            planeID.Name = "planeID";
            planeID.Size = new Size(132, 23);
            planeID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(217, 116);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 8;
            label2.Text = "Plane ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(217, 168);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 10;
            label3.Text = "Model";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // model
            // 
            model.Location = new Point(388, 170);
            model.Name = "model";
            model.Size = new Size(132, 23);
            model.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(217, 220);
            label5.Name = "label5";
            label5.Size = new Size(73, 26);
            label5.TabIndex = 14;
            label5.Text = "Airline";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // airline
            // 
            airline.Location = new Point(388, 219);
            airline.Name = "airline";
            airline.Size = new Size(132, 23);
            airline.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(315, 311);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(527, 9);
            label4.Name = "label4";
            label4.Size = new Size(31, 29);
            label4.TabIndex = 16;
            label4.Text = "X";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-4, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 410);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(48, 224);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 5;
            label7.Text = "from there.";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(15, 195);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 4;
            label6.Text = "You can add Aircarft";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addAircraft
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 380);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
    }
}