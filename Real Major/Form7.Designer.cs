namespace Real_Major
{
    partial class Form7
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
            descriptionLabel = new Label();
            priceLabel = new Label();
            adressLabel = new Label();
            colorLabel = new Label();
            descriptionTextBox = new TextBox();
            priceTextBox = new TextBox();
            adressTextBox = new TextBox();
            colorTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(419, 285);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(471, 61);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 21;
            priceLabel.Text = "Price:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new Point(298, 61);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(65, 20);
            adressLabel.TabIndex = 20;
            adressLabel.Text = "Address:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(98, 61);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 20);
            colorLabel.TabIndex = 19;
            colorLabel.Text = "Color:";
            colorLabel.Click += label1_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(419, 309);
            descriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(383, 27);
            descriptionTextBox.TabIndex = 18;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(471, 85);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(114, 27);
            priceTextBox.TabIndex = 17;
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(298, 85);
            adressTextBox.Margin = new Padding(3, 4, 3, 4);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(114, 27);
            adressTextBox.TabIndex = 16;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(98, 85);
            colorTextBox.Margin = new Padding(3, 4, 3, 4);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(114, 27);
            colorTextBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(98, 243);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 169);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(98, 192);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(174, 28);
            button2.TabIndex = 13;
            button2.Text = "Upload Picture";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(98, 499);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(96, 37);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(descriptionLabel);
            Controls.Add(priceLabel);
            Controls.Add(adressLabel);
            Controls.Add(colorLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(adressTextBox);
            Controls.Add(colorTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(backButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private Label priceLabel;
        private Label adressLabel;
        private Label colorLabel;
        private TextBox descriptionTextBox;
        private TextBox priceTextBox;
        private TextBox adressTextBox;
        private TextBox colorTextBox;
        private PictureBox pictureBox1;
        private Button button2;
        private Button backButton;
    }
}