namespace Real_Major
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Label2 = new Label();
            TextBox2 = new TextBox();
            Label1 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            Button2 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(312, 257);
            Label2.Name = "Label2";
            Label2.Size = new Size(70, 20);
            Label2.TabIndex = 14;
            Label2.Text = "Password";
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(394, 247);
            TextBox2.Margin = new Padding(3, 4, 3, 4);
            TextBox2.Name = "TextBox2";
            TextBox2.PasswordChar = '*';
            TextBox2.Size = new Size(153, 27);
            TextBox2.TabIndex = 13;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(312, 189);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 20);
            Label1.TabIndex = 12;
            Label1.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(394, 185);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(153, 27);
            usernameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 311);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 16;
            label3.Text = "Repeat Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(394, 300);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(153, 27);
            textBox3.TabIndex = 15;
            // 
            // Button2
            // 
            Button2.Location = new Point(394, 408);
            Button2.Margin = new Padding(3, 4, 3, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(125, 37);
            Button2.TabIndex = 17;
            Button2.Text = "Sign up";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 24);
            label4.Name = "label4";
            label4.Size = new Size(316, 66);
            label4.TabIndex = 18;
            label4.Text = "Cartier Estate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(767, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(81, 499);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Button2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(Label2);
            Controls.Add(TextBox2);
            Controls.Add(Label1);
            Controls.Add(usernameTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label Label2;
        internal TextBox TextBox2;
        internal Label Label1;
        internal TextBox usernameTextBox;
        internal Label label3;
        internal TextBox textBox3;
        internal Button Button2;
        private Label label4;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Button button1;
    }
}