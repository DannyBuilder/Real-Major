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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button2 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(354, 334);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(109, 28);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "Sign up";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(307, 316);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 15);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Don\'t have an account? Sign up here !";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(354, 241);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(109, 30);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(270, 176);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 15);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Password";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(342, 168);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(134, 23);
            this.passBox.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(270, 125);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 15);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(342, 122);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(134, 23);
            this.usernameBox.TabIndex = 7;
            this.usernameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 52);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cartier Estate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.usernameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}