namespace Real_Major
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Color = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Adress = new Label();
            Price = new Label();
            label2 = new Label();
            House = new Label();
            Description = new Label();
            HousePicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HousePicture).BeginInit();
            SuspendLayout();
            // 
            // Color
            // 
            Color.AutoSize = true;
            Color.Location = new Point(727, 381);
            Color.Name = "Color";
            Color.Size = new Size(168, 20);
            Color.TabIndex = 1;
            Color.Text = "Size:  360 square meters";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 153);
            label4.Name = "label4";
            label4.Size = new Size(316, 66);
            label4.TabIndex = 15;
            label4.Text = "Cartier Estate";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(79, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(87, 31);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3, 0);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(919, 272);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-3, -11);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 160);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // Adress
            // 
            Adress.AutoSize = true;
            Adress.Location = new Point(448, 361);
            Adress.Name = "Adress";
            Adress.Size = new Size(145, 20);
            Adress.TabIndex = 25;
            Adress.Text = "3750 Tuxedo Rd NW";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(727, 361);
            Price.Name = "Price";
            Price.Size = new Size(79, 20);
            Price.TabIndex = 26;
            Price.Text = "$6,000,000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 431);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 28;
            // 
            // House
            // 
            House.AutoSize = true;
            House.Location = new Point(53, 285);
            House.Name = "House";
            House.Size = new Size(85, 20);
            House.TabIndex = 29;
            House.Text = "Description";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(63, 431);
            Description.Name = "Description";
            Description.Size = new Size(831, 20);
            Description.TabIndex = 30;
            Description.Text = "Step into the epitome of luxury living with this majestic brick estate nestled in the prestigious neighborhood of Tuxedo Park. ";
            // 
            // HousePicture
            // 
            HousePicture.Location = new Point(563, 0);
            HousePicture.Margin = new Padding(3, 4, 3, 4);
            HousePicture.Name = "HousePicture";
            HousePicture.Size = new Size(352, 272);
            HousePicture.TabIndex = 31;
            HousePicture.TabStop = false;
            HousePicture.Click += pictureBox1_Click_1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 600);
            Controls.Add(HousePicture);
            Controls.Add(Description);
            Controls.Add(House);
            Controls.Add(label2);
            Controls.Add(Price);
            Controls.Add(Adress);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Color);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)HousePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Color;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label Adress;
        private Label Price;
        private Label label2;
        private Label House;
        private Label Description;
        private PictureBox HousePicture;
    }
}