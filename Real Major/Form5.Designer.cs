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
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.countryButton = new System.Windows.Forms.RadioButton();
            this.townButton = new System.Windows.Forms.RadioButton();
            this.houseButton = new System.Windows.Forms.RadioButton();
            this.newCountryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 396);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 43);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(543, 396);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 43);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(295, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 52);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cartier Estate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 501);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(406, 396);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 43);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(285, 168);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 15);
            this.label.TabIndex = 19;
            this.label.Text = "placeholder";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(406, 165);
            this.countryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(114, 23);
            this.countryBox.TabIndex = 20;
            // 
            // countryButton
            // 
            this.countryButton.AutoSize = true;
            this.countryButton.Location = new System.Drawing.Point(251, 292);
            this.countryButton.Name = "countryButton";
            this.countryButton.Size = new System.Drawing.Size(68, 19);
            this.countryButton.TabIndex = 21;
            this.countryButton.TabStop = true;
            this.countryButton.Text = "Country";
            this.countryButton.UseVisualStyleBackColor = true;
            this.countryButton.CheckedChanged += new System.EventHandler(this.countryButton_CheckedChanged);
            // 
            // townButton
            // 
            this.townButton.AutoSize = true;
            this.townButton.Location = new System.Drawing.Point(403, 292);
            this.townButton.Name = "townButton";
            this.townButton.Size = new System.Drawing.Size(53, 19);
            this.townButton.TabIndex = 22;
            this.townButton.TabStop = true;
            this.townButton.Text = "Town";
            this.townButton.UseVisualStyleBackColor = true;
            this.townButton.CheckedChanged += new System.EventHandler(this.townButton_CheckedChanged);
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Location = new System.Drawing.Point(543, 292);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(59, 19);
            this.houseButton.TabIndex = 23;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.CheckedChanged += new System.EventHandler(this.houseButton_CheckedChanged);
            // 
            // newCountryBox
            // 
            this.newCountryBox.Location = new System.Drawing.Point(406, 223);
            this.newCountryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newCountryBox.Name = "newCountryBox";
            this.newCountryBox.Size = new System.Drawing.Size(114, 23);
            this.newCountryBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(285, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Update to";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 544);
            this.Controls.Add(this.newCountryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.townButton);
            this.Controls.Add(this.countryButton);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox newCountryBox;
        private Label label2;
    }
}