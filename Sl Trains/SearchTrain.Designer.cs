
namespace Sl_Trains
{
    partial class Search_Trains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Trains));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endtime = new System.Windows.Forms.ComboBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.starttime = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(391, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "From";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.endtime);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.starttime);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Trains";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(145, 227);
            this.search.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(230, 51);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(445, 38);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // endtime
            // 
            this.endtime.FormattingEnabled = true;
            this.endtime.Items.AddRange(new object[] {
            "0.00 a.m",
            "1.00 a.m",
            "2.00 a.m",
            "3.00 a.m",
            "4.00 a.m",
            "5.00 a.m",
            "6.00 a.m",
            "7.00 a.m",
            "8.00 a.m",
            "9.00 a.m",
            "10.00 a.m",
            "11.00 a.m",
            "12.00 p.m",
            "13.00 p.m",
            "14.00 p.m",
            "15.00 p.m",
            "16.00 pm",
            "17.00 p.m",
            "18.00 p.m",
            "19.00 p.m",
            "20.00 p.m",
            "21.00 p.m",
            "22.00 p.m",
            "23.00 p.m"});
            this.endtime.Location = new System.Drawing.Point(530, 104);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(228, 39);
            this.endtime.TabIndex = 8;
            // 
            // to
            // 
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "Kandy",
            "Beliatta",
            "Aluthgama",
            "Galle",
            "Kanthale",
            "Galoya",
            "Kilinochchi",
            "Thabalagamuwa",
            "Anuradhapura",
            "Gampaha",
            "Kurunegala",
            "Trincomalee",
            "Badulla",
            "Haputale",
            "Matara",
            "Valichchena",
            "Bandarawela",
            "Hatton",
            "Nanuoya",
            "Vauniya",
            "Batticalo",
            "Hikkaduwa",
            "Hingurakgoda",
            "Nawalapitiya",
            "Welikanada",
            "Colombo Fort",
            "Jaffna",
            "Peradeniya",
            "Wellawatte",
            "Diyathalawa",
            "Kalutara",
            "Polgahawela"});
            this.to.Location = new System.Drawing.Point(530, 34);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(228, 39);
            this.to.TabIndex = 7;
            // 
            // starttime
            // 
            this.starttime.FormattingEnabled = true;
            this.starttime.Items.AddRange(new object[] {
            "0.00 a.m",
            "1.00 a.m",
            "2.00 a.m",
            "3.00 a.m",
            "4.00 a.m",
            "5.00 a.m",
            "6.00 a.m",
            "7.00 a.m",
            "8.00 a.m",
            "9.00 a.m",
            "10.00 a.m",
            "11.00 a.m",
            "12.00 p.m",
            "13.00 p.m",
            "14.00 p.m",
            "15.00 p.m",
            "16.00 pm",
            "17.00 p.m",
            "18.00 p.m",
            "19.00 p.m",
            "20.00 p.m",
            "21.00 p.m",
            "22.00 p.m",
            "23.00 p.m"});
            this.starttime.Location = new System.Drawing.Point(145, 104);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(228, 39);
            this.starttime.TabIndex = 6;
            // 
            // from
            // 
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "Kandy",
            "Beliatta",
            "Aluthgama",
            "Galle",
            "Kanthale",
            "Galoya",
            "Kilinochchi",
            "Thabalagamuwa",
            "Anuradhapura",
            "Gampaha",
            "Kurunegala",
            "Trincomalee",
            "Badulla",
            "Haputale",
            "Matara",
            "Valichchena",
            "Bandarawela",
            "Hatton",
            "Nanuoya",
            "Vauniya",
            "Batticalo",
            "Hikkaduwa",
            "Hingurakgoda",
            "Nawalapitiya",
            "Welikanada",
            "Colombo Fort",
            "Jaffna",
            "Peradeniya",
            "Wellawatte",
            "Diyathalawa",
            "Kalutara",
            "Polgahawela",
            "Ella"});
            this.from.Location = new System.Drawing.Point(145, 34);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(228, 39);
            this.from.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(161, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(655, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sri Lankan Railways Train Tickets Reservation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 264);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(823, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 272);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(428, 227);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(230, 51);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // Search_Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1032, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Search_Trains";
            this.Text = "To";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox endtime;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox starttime;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
    }
}