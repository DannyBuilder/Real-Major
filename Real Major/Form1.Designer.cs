namespace Real_Major
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Button2 = new Button();
            Label3 = new Label();
            Button1 = new Button();
            Label2 = new Label();
            passBox = new TextBox();
            Label1 = new Label();
            usernameBox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.Location = new Point(405, 445);
            Button2.Margin = new Padding(3, 4, 3, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(125, 37);
            Button2.TabIndex = 13;
            Button2.Text = "Sign up";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(351, 421);
            Label3.Name = "Label3";
            Label3.Size = new Size(258, 20);
            Label3.TabIndex = 12;
            Label3.Text = "Don't have an account? Sign up here !";
            // 
            // Button1
            // 
            Button1.Location = new Point(405, 321);
            Button1.Margin = new Padding(3, 4, 3, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(125, 40);
            Button1.TabIndex = 11;
            Button1.Text = "Login";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(309, 235);
            Label2.Name = "Label2";
            Label2.Size = new Size(70, 20);
            Label2.TabIndex = 10;
            Label2.Text = "Password";
            // 
            // passBox
            // 
            passBox.Location = new Point(391, 224);
            passBox.Margin = new Padding(3, 4, 3, 4);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(153, 27);
            passBox.TabIndex = 9;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(309, 167);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 20);
            Label1.TabIndex = 8;
            Label1.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(391, 163);
            usernameBox.Margin = new Padding(3, 4, 3, 4);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(153, 27);
            usernameBox.TabIndex = 7;
            usernameBox.TextChanged += TextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(309, 31);
            label4.Name = "label4";
            label4.Size = new Size(316, 66);
            label4.TabIndex = 14;
            label4.Text = "Cartier Estate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(768, -3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Button2);
            Controls.Add(Label3);
            Controls.Add(Button1);
            Controls.Add(Label2);
            Controls.Add(passBox);
            Controls.Add(Label1);
            Controls.Add(usernameBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button Button2;
        internal Label Label3;
        internal Button Button1;
        internal Label Label2;
        internal TextBox passBox;
        internal Label Label1;
        internal TextBox usernameBox;
        private Label label4;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}