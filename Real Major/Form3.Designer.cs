namespace Real_Major
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            countryComboBox = new ComboBox();
            townComboBox = new ComboBox();
            countryLabel = new Label();
            townLabel = new Label();
            houseLabel = new Label();
            changeInfoButton = new Button();
            backButton = new Button();
            showButton = new Button();
            houseComboBox = new ComboBox();
            backgroundPictureBox = new PictureBox();
            cityPictureBox = new PictureBox();
            logoPictureBox = new PictureBox();
            changeHouseInfoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(118, 313);
            countryComboBox.Margin = new Padding(3, 4, 3, 4);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(146, 28);
            countryComboBox.TabIndex = 0;
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(376, 313);
            townComboBox.Margin = new Padding(3, 4, 3, 4);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(146, 28);
            townComboBox.TabIndex = 1;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = Color.WhiteSmoke;
            countryLabel.Location = new Point(153, 279);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(63, 20);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.BackColor = Color.WhiteSmoke;
            townLabel.Location = new Point(423, 279);
            townLabel.Name = "townLabel";
            townLabel.Size = new Size(47, 20);
            townLabel.TabIndex = 4;
            townLabel.Text = "Town:";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.BackColor = Color.WhiteSmoke;
            houseLabel.Location = new Point(657, 279);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new Size(54, 20);
            houseLabel.TabIndex = 5;
            houseLabel.Text = "House:";
            // 
            // changeInfoButton
            // 
            changeInfoButton.Location = new Point(363, 427);
            changeInfoButton.Margin = new Padding(3, 4, 3, 4);
            changeInfoButton.Name = "changeInfoButton";
            changeInfoButton.Size = new Size(174, 32);
            changeInfoButton.TabIndex = 4;
            changeInfoButton.Text = "Change Information";
            changeInfoButton.UseVisualStyleBackColor = true;
            changeInfoButton.Click += changeInfoButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(67, 525);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 31);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // showButton
            // 
            showButton.Location = new Point(363, 372);
            showButton.Margin = new Padding(3, 4, 3, 4);
            showButton.Name = "showButton";
            showButton.Size = new Size(174, 33);
            showButton.TabIndex = 3;
            showButton.Text = "Show House";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // houseComboBox
            // 
            houseComboBox.FormattingEnabled = true;
            houseComboBox.Location = new Point(625, 313);
            houseComboBox.Margin = new Padding(3, 4, 3, 4);
            houseComboBox.Name = "houseComboBox";
            houseComboBox.Size = new Size(146, 28);
            houseComboBox.TabIndex = 2;
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = (Image)resources.GetObject("backgroundPictureBox.Image");
            backgroundPictureBox.Location = new Point(1, 251);
            backgroundPictureBox.Margin = new Padding(2, 3, 2, 3);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(919, 347);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.TabIndex = 19;
            backgroundPictureBox.TabStop = false;
            // 
            // cityPictureBox
            // 
            cityPictureBox.Image = (Image)resources.GetObject("cityPictureBox.Image");
            cityPictureBox.Location = new Point(1, 1);
            cityPictureBox.Margin = new Padding(2, 3, 2, 3);
            cityPictureBox.Name = "cityPictureBox";
            cityPictureBox.Size = new Size(923, 259);
            cityPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cityPictureBox.TabIndex = 20;
            cityPictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(754, 439);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(160, 160);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 21;
            logoPictureBox.TabStop = false;
            // 
            // changeHouseInfoButton
            // 
            changeHouseInfoButton.Location = new Point(363, 483);
            changeHouseInfoButton.Margin = new Padding(3, 4, 3, 4);
            changeHouseInfoButton.Name = "changeHouseInfoButton";
            changeHouseInfoButton.Size = new Size(174, 32);
            changeHouseInfoButton.TabIndex = 5;
            changeHouseInfoButton.Text = "Change House Information";
            changeHouseInfoButton.UseVisualStyleBackColor = true;
            changeHouseInfoButton.Click += HouseInformation_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(changeHouseInfoButton);
            Controls.Add(logoPictureBox);
            Controls.Add(houseComboBox);
            Controls.Add(countryLabel);
            Controls.Add(countryComboBox);
            Controls.Add(houseLabel);
            Controls.Add(townLabel);
            Controls.Add(townComboBox);
            Controls.Add(showButton);
            Controls.Add(changeInfoButton);
            Controls.Add(backButton);
            Controls.Add(backgroundPictureBox);
            Controls.Add(cityPictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox countryComboBox;
        private ComboBox townComboBox;
        private Label countryLabel;
        private Label townLabel;
        private Label houseLabel;
        private Button changeInfoButton;
        private Button backButton;
        private Button showButton;
        private ComboBox houseComboBox;
        private PictureBox backgroundPictureBox;
        private PictureBox cityPictureBox;
        private PictureBox logoPictureBox;
        private Button changeHouseInfoButton;
    }
}