namespace Real_Major
{
    partial class AdminChangeInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangeInformation));
            label1 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            backButton = new Button();
            updateButton = new Button();
            label = new Label();
            currentNameBox = new TextBox();
            countryButton = new RadioButton();
            townButton = new RadioButton();
            houseButton = new RadioButton();
            updateBox = new TextBox();
            updateLabel = new Label();
            logoLabel = new Label();
            label2 = new Label();
            backgroundPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 307);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(242, 396);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(103, 43);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(543, 396);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(103, 43);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(26, 490);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(102, 41);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(406, 396);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(103, 43);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.WhiteSmoke;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(285, 168);
            label.Name = "label";
            label.Size = new Size(87, 20);
            label.TabIndex = 19;
            label.Text = "Placeholder";
            // 
            // currentNameBox
            // 
            currentNameBox.Location = new Point(406, 165);
            currentNameBox.Margin = new Padding(3, 4, 3, 4);
            currentNameBox.Name = "currentNameBox";
            currentNameBox.Size = new Size(114, 27);
            currentNameBox.TabIndex = 0;
            // 
            // countryButton
            // 
            countryButton.AutoSize = true;
            countryButton.BackColor = Color.WhiteSmoke;
            countryButton.Location = new Point(251, 292);
            countryButton.Name = "countryButton";
            countryButton.Size = new Size(81, 24);
            countryButton.TabIndex = 2;
            countryButton.TabStop = true;
            countryButton.Text = "Country";
            countryButton.UseVisualStyleBackColor = false;
            countryButton.CheckedChanged += countryButton_CheckedChanged;
            // 
            // townButton
            // 
            townButton.AutoSize = true;
            townButton.BackColor = Color.WhiteSmoke;
            townButton.Location = new Point(403, 292);
            townButton.Name = "townButton";
            townButton.Size = new Size(65, 24);
            townButton.TabIndex = 3;
            townButton.TabStop = true;
            townButton.Text = "Town";
            townButton.UseVisualStyleBackColor = false;
            townButton.CheckedChanged += townButton_CheckedChanged;
            // 
            // houseButton
            // 
            houseButton.AutoSize = true;
            houseButton.BackColor = Color.WhiteSmoke;
            houseButton.Location = new Point(543, 292);
            houseButton.Name = "houseButton";
            houseButton.Size = new Size(72, 24);
            houseButton.TabIndex = 4;
            houseButton.TabStop = true;
            houseButton.Text = "House";
            houseButton.UseVisualStyleBackColor = false;
            houseButton.CheckedChanged += houseButton_CheckedChanged;
            // 
            // updateBox
            // 
            updateBox.Location = new Point(406, 223);
            updateBox.Margin = new Padding(3, 4, 3, 4);
            updateBox.Name = "updateBox";
            updateBox.Size = new Size(114, 27);
            updateBox.TabIndex = 1;
            // 
            // updateLabel
            // 
            updateLabel.AutoSize = true;
            updateLabel.BackColor = Color.WhiteSmoke;
            updateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            updateLabel.Location = new Point(285, 226);
            updateLabel.Name = "updateLabel";
            updateLabel.Size = new Size(76, 20);
            updateLabel.TabIndex = 24;
            updateLabel.Text = "Update to";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            logoLabel.Location = new Point(343, 70);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(200, 46);
            logoLabel.TabIndex = 15;
            logoLabel.Text = "Admin Page";
            logoLabel.Click += logoLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 29F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(242, -1);
            label2.Name = "label2";
            label2.Size = new Size(397, 81);
            label2.TabIndex = 25;
            label2.Text = "Cartier Estate";
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = (Image)resources.GetObject("backgroundPictureBox.Image");
            backgroundPictureBox.Location = new Point(187, 119);
            backgroundPictureBox.Margin = new Padding(2, 3, 2, 3);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(503, 364);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.TabIndex = 26;
            backgroundPictureBox.TabStop = false;
            backgroundPictureBox.Click += backgroundPictureBox_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(917, 544);
            Controls.Add(label2);
            Controls.Add(updateBox);
            Controls.Add(updateLabel);
            Controls.Add(houseButton);
            Controls.Add(townButton);
            Controls.Add(countryButton);
            Controls.Add(currentNameBox);
            Controls.Add(label);
            Controls.Add(updateButton);
            Controls.Add(backButton);
            Controls.Add(logoLabel);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(backgroundPictureBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load_1;
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Button deleteButton;
        private TextBox townBox;
        private Label label4;
        private TextBox houseBox;
        private Button backButton;
        private Button updateButton;
        private Label label;
        private TextBox currentNameBox;
        private RadioButton countryButton;
        private RadioButton townButton;
        private RadioButton houseButton;
        private TextBox updateBox;
        private Label updateLabel;
        private Label logoLabel;
        private Label label2;
        private PictureBox backgroundPictureBox;
    }
}