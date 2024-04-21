namespace Real_Major
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            updateButton = new Button();
            label = new Label();
            countryBox = new TextBox();
            countryButton = new RadioButton();
            townButton = new RadioButton();
            houseButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(543, 396);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(103, 43);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(295, 25);
            label5.Name = "label5";
            label5.Size = new Size(316, 66);
            label5.TabIndex = 15;
            label5.Text = "Cartier Estate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(769, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(85, 501);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(102, 41);
            button3.TabIndex = 17;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(406, 396);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(103, 43);
            updateButton.TabIndex = 18;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(285, 212);
            label.Name = "label";
            label.Size = new Size(88, 20);
            label.TabIndex = 19;
            label.Text = "placeholder";
            label.Click += label2_Click;
            // 
            // countryBox
            // 
            countryBox.Location = new Point(406, 209);
            countryBox.Margin = new Padding(3, 4, 3, 4);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(114, 27);
            countryBox.TabIndex = 20;
            // 
            // countryButton
            // 
            countryButton.AutoSize = true;
            countryButton.Location = new Point(251, 292);
            countryButton.Name = "countryButton";
            countryButton.Size = new Size(81, 24);
            countryButton.TabIndex = 21;
            countryButton.TabStop = true;
            countryButton.Text = "Country";
            countryButton.UseVisualStyleBackColor = true;
            countryButton.CheckedChanged += countryButton_CheckedChanged;
            // 
            // townButton
            // 
            townButton.AutoSize = true;
            townButton.Location = new Point(403, 292);
            townButton.Name = "townButton";
            townButton.Size = new Size(65, 24);
            townButton.TabIndex = 22;
            townButton.TabStop = true;
            townButton.Text = "Town";
            townButton.UseVisualStyleBackColor = true;
            townButton.CheckedChanged += townButton_CheckedChanged;
            // 
            // houseButton
            // 
            houseButton.AutoSize = true;
            houseButton.Location = new Point(543, 292);
            houseButton.Name = "houseButton";
            houseButton.Size = new Size(72, 24);
            houseButton.TabIndex = 23;
            houseButton.TabStop = true;
            houseButton.Text = "House";
            houseButton.UseVisualStyleBackColor = true;
            houseButton.CheckedChanged += houseButton_CheckedChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(917, 544);
            Controls.Add(houseButton);
            Controls.Add(townButton);
            Controls.Add(countryButton);
            Controls.Add(countryBox);
            Controls.Add(label);
            Controls.Add(updateButton);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Button deleteButton;
        private TextBox townBox;
        private Label label3;
        private Label label4;
        private TextBox houseBox;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button3;
        private Button updateButton;
        private Label label;
        private TextBox countryBox;
        private RadioButton countryButton;
        private RadioButton townButton;
        private RadioButton houseButton;
    }
}