
namespace Sl_Trains
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Log = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(468, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(325, 140);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(352, 58);
            this.Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(325, 274);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(352, 60);
            this.Password.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBox1.Location = new System.Drawing.Point(346, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(342, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Remember me on This Device";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Log.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log.ForeColor = System.Drawing.Color.Teal;
            this.Log.Location = new System.Drawing.Point(453, 451);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(235, 63);
            this.Log.TabIndex = 8;
            this.Log.Text = "LogIn";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.Teal;
            this.create.Location = new System.Drawing.Point(453, 562);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(235, 63);
            this.create.TabIndex = 9;
            this.create.Text = "Create Account";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.forgot.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.forgot.Location = new System.Drawing.Point(683, 297);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(195, 26);
            this.forgot.TabIndex = 11;
            this.forgot.TabStop = true;
            this.forgot.Text = "*Forgot Password";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(213, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "This is the Email Address you registered with";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(436, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Don\'t Have An Account";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 676);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.create);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

