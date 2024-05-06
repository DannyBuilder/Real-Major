namespace Real_Major
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            passwordBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordBox2 = new TextBox();
            Button2 = new Button();
            logoPictureBox = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            button1 = new Button();
            pictureBox2 = new PictureBox();
            userPictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            passwordPictureBox2 = new PictureBox();
            label1 = new Label();
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(608, 239);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(153, 27);
            passwordBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(608, 177);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(153, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordBox2
            // 
            passwordBox2.Location = new Point(608, 292);
            passwordBox2.Margin = new Padding(3, 4, 3, 4);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.Size = new Size(153, 27);
            passwordBox2.TabIndex = 2;
            // 
            // Button2
            // 
            Button2.Location = new Point(608, 400);
            Button2.Margin = new Padding(3, 4, 3, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(125, 37);
            Button2.TabIndex = 3;
            Button2.Text = "Sign up";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click_1;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(27, 163);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(376, 376);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 19;
            logoPictureBox.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(27, 547);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(87, 31);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(415, -1);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(503, 603);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.WhiteSmoke;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(557, 169);
            userPictureBox.Margin = new Padding(2, 3, 2, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(32, 32);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 22;
            userPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.BackColor = Color.WhiteSmoke;
            passwordPictureBox.Image = (Image)resources.GetObject("passwordPictureBox.Image");
            passwordPictureBox.Location = new Point(557, 232);
            passwordPictureBox.Margin = new Padding(2, 3, 2, 3);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(32, 32);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPictureBox.TabIndex = 23;
            passwordPictureBox.TabStop = false;
            // 
            // passwordPictureBox2
            // 
            passwordPictureBox2.BackColor = Color.WhiteSmoke;
            passwordPictureBox2.Image = (Image)resources.GetObject("passwordPictureBox2.Image");
            passwordPictureBox2.Location = new Point(557, 285);
            passwordPictureBox2.Margin = new Padding(2, 3, 2, 3);
            passwordPictureBox2.Name = "passwordPictureBox2";
            passwordPictureBox2.Size = new Size(32, 32);
            passwordPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPictureBox2.TabIndex = 24;
            passwordPictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 29F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(397, 81);
            label1.TabIndex = 25;
            label1.Text = "Cartier Estate";
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 600);
            Controls.Add(label1);
            Controls.Add(passwordPictureBox2);
            Controls.Add(passwordPictureBox);
            Controls.Add(userPictureBox);
            Controls.Add(Button2);
            Controls.Add(passwordBox2);
            Controls.Add(passwordBox);
            Controls.Add(usernameTextBox);
            Controls.Add(button1);
            Controls.Add(logoPictureBox);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal TextBox passwordBox;
        internal TextBox usernameTextBox;
        internal TextBox passwordBox2;
        internal Button Button2;
        private PictureBox logoPictureBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox userPictureBox;
        private PictureBox passwordPictureBox2;
        private PictureBox passwordPictureBox;
        private Label label1;
        private ErrorProvider errorProvider3;
    }
}