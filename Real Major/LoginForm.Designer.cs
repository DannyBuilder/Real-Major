namespace Real_Major
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            SignUpButton = new Button();
            dontHaveLabel = new Label();
            LoginButton = new Button();
            passBox = new TextBox();
            usernameBox = new TextBox();
            logoLabel = new Label();
            logoPictureBox = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            backgroundPictureBox = new PictureBox();
            userPictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(617, 473);
            SignUpButton.Margin = new Padding(3, 4, 3, 4);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(125, 40);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += Button2_Click;
            // 
            // dontHaveLabel
            // 
            dontHaveLabel.AutoSize = true;
            dontHaveLabel.BackColor = Color.WhiteSmoke;
            dontHaveLabel.Location = new Point(557, 437);
            dontHaveLabel.Name = "dontHaveLabel";
            dontHaveLabel.Size = new Size(258, 20);
            dontHaveLabel.TabIndex = 12;
            dontHaveLabel.Text = "Don't have an account? Sign up here !";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(617, 357);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 40);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Button1_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(601, 204);
            passBox.Margin = new Padding(3, 4, 3, 4);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(153, 27);
            passBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(601, 141);
            usernameBox.Margin = new Padding(3, 4, 3, 4);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(153, 27);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.BackColor = Color.Transparent;
            logoLabel.Font = new Font("Segoe Script", 29F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logoLabel.Location = new Point(12, 21);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(397, 81);
            logoLabel.TabIndex = 14;
            logoLabel.Text = "Cartier Estate";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(27, 163);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(376, 376);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 15;
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
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = (Image)resources.GetObject("backgroundPictureBox.Image");
            backgroundPictureBox.Location = new Point(423, -1);
            backgroundPictureBox.Margin = new Padding(2, 3, 2, 3);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(503, 603);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.TabIndex = 16;
            backgroundPictureBox.TabStop = false;
            backgroundPictureBox.Click += pictureBox2_Click;
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.WhiteSmoke;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(538, 133);
            userPictureBox.Margin = new Padding(2, 3, 2, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(32, 32);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 17;
            userPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.BackColor = Color.WhiteSmoke;
            passwordPictureBox.Image = (Image)resources.GetObject("passwordPictureBox.Image");
            passwordPictureBox.Location = new Point(538, 204);
            passwordPictureBox.Margin = new Padding(2, 3, 2, 3);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(32, 32);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPictureBox.TabIndex = 18;
            passwordPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 600);
            Controls.Add(logoLabel);
            Controls.Add(passwordPictureBox);
            Controls.Add(userPictureBox);
            Controls.Add(dontHaveLabel);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(passBox);
            Controls.Add(usernameBox);
            Controls.Add(backgroundPictureBox);
            Controls.Add(logoPictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button SignUpButton;
        internal Label dontHaveLabel;
        internal Button LoginButton;
        internal TextBox passBox;
        internal TextBox usernameBox;
        private Label logoLabel;
        private PictureBox logoPictureBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private PictureBox backgroundPictureBox;
        private PictureBox userPictureBox;
        private PictureBox passwordPictureBox;
    }
}