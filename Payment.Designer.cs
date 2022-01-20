
namespace Sl_Trains
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.debit = new System.Windows.Forms.RadioButton();
            this.credit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cno = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.TextBox();
            this.Pay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pamount = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debit
            // 
            this.debit.AutoSize = true;
            this.debit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.debit.Location = new System.Drawing.Point(241, 74);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(127, 32);
            this.debit.TabIndex = 0;
            this.debit.Text = "Debit Card";
            this.debit.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit.Location = new System.Drawing.Point(412, 74);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(132, 32);
            this.credit.TabIndex = 1;
            this.credit.Text = "Credit Card";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Holder Name";
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(306, 127);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(314, 27);
            this.cname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exp Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card No";
            // 
            // cno
            // 
            this.cno.Location = new System.Drawing.Point(306, 177);
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(314, 27);
            this.cno.TabIndex = 7;
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(306, 225);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(122, 27);
            this.exp.TabIndex = 8;
            // 
            // cvv
            // 
            this.cvv.Location = new System.Drawing.Point(306, 275);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(125, 27);
            this.cvv.TabIndex = 9;
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pay.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pay.Location = new System.Drawing.Point(432, 361);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(165, 61);
            this.Pay.TabIndex = 11;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Payment Amount";
            // 
            // pamount
            // 
            this.pamount.Location = new System.Drawing.Point(259, 19);
            this.pamount.Name = "pamount";
            this.pamount.ReadOnly = true;
            this.pamount.Size = new System.Drawing.Size(199, 27);
            this.pamount.TabIndex = 13;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(186, 361);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(165, 61);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.cno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.debit);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton debit;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cno;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox pamount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button cancel;
    }
}