namespace Clinic_Management
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.EditBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Appoint_Lb = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Presc_Lb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Doc_Lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Pa_Lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaID_Cbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PaName_Tbox = new System.Windows.Forms.TextBox();
            this.DocID_Cbox = new System.Windows.Forms.ComboBox();
            this.DocName_Tbox = new System.Windows.Forms.TextBox();
            this.ApDate = new System.Windows.Forms.DateTimePicker();
            this.ApTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.ApNote_Tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(589, 247);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(104, 44);
            this.EditBtn.TabIndex = 43;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.Location = new System.Drawing.Point(458, 247);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(104, 44);
            this.AddBtn.TabIndex = 42;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Appoint_Lb);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Presc_Lb);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.Doc_Lb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Pa_Lb);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 590);
            this.panel1.TabIndex = 4;
            // 
            // Appoint_Lb
            // 
            this.Appoint_Lb.AutoSize = true;
            this.Appoint_Lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appoint_Lb.ForeColor = System.Drawing.Color.Black;
            this.Appoint_Lb.Location = new System.Drawing.Point(57, 329);
            this.Appoint_Lb.Name = "Appoint_Lb";
            this.Appoint_Lb.Size = new System.Drawing.Size(137, 28);
            this.Appoint_Lb.TabIndex = 24;
            this.Appoint_Lb.Text = "Appointment";
            this.Appoint_Lb.Click += new System.EventHandler(this.Appoint_Lb_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 312);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // Presc_Lb
            // 
            this.Presc_Lb.AutoSize = true;
            this.Presc_Lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presc_Lb.ForeColor = System.Drawing.Color.Black;
            this.Presc_Lb.Location = new System.Drawing.Point(57, 278);
            this.Presc_Lb.Name = "Presc_Lb";
            this.Presc_Lb.Size = new System.Drawing.Size(135, 28);
            this.Presc_Lb.TabIndex = 22;
            this.Presc_Lb.Text = "Prescriptions";
            this.Presc_Lb.Click += new System.EventHandler(this.Presc_Lb_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 261);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // Doc_Lb
            // 
            this.Doc_Lb.AutoSize = true;
            this.Doc_Lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc_Lb.ForeColor = System.Drawing.Color.Black;
            this.Doc_Lb.Location = new System.Drawing.Point(57, 227);
            this.Doc_Lb.Name = "Doc_Lb";
            this.Doc_Lb.Size = new System.Drawing.Size(86, 28);
            this.Doc_Lb.TabIndex = 19;
            this.Doc_Lb.Text = "Doctors";
            this.Doc_Lb.Click += new System.EventHandler(this.Doc_Lb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(73, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "LOGOUT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(16, 524);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Pa_Lb
            // 
            this.Pa_Lb.AutoSize = true;
            this.Pa_Lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pa_Lb.ForeColor = System.Drawing.Color.Black;
            this.Pa_Lb.Location = new System.Drawing.Point(57, 176);
            this.Pa_Lb.Name = "Pa_Lb";
            this.Pa_Lb.Size = new System.Drawing.Size(89, 28);
            this.Pa_Lb.TabIndex = 8;
            this.Pa_Lb.Text = "Patients";
            this.Pa_Lb.Click += new System.EventHandler(this.Pa_Lb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.ApNote_Tbox);
            this.panel2.Controls.Add(this.ApTime);
            this.panel2.Controls.Add(this.ApDate);
            this.panel2.Controls.Add(this.PaID_Cbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.PaName_Tbox);
            this.panel2.Controls.Add(this.DocID_Cbox);
            this.panel2.Controls.Add(this.DocName_Tbox);
            this.panel2.Controls.Add(this.ApGridView1);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 590);
            this.panel2.TabIndex = 5;
            // 
            // ApGridView1
            // 
            this.ApGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ApGridView1.Location = new System.Drawing.Point(210, 372);
            this.ApGridView1.Name = "ApGridView1";
            this.ApGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApGridView1.Size = new System.Drawing.Size(875, 206);
            this.ApGridView1.TabIndex = 60;
            this.ApGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApGridView1_CellContentClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(717, 247);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(104, 44);
            this.CancelBtn.TabIndex = 41;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1046, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PaID_Cbox
            // 
            this.PaID_Cbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaID_Cbox.FormattingEnabled = true;
            this.PaID_Cbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PaID_Cbox.Location = new System.Drawing.Point(210, 206);
            this.PaID_Cbox.Name = "PaID_Cbox";
            this.PaID_Cbox.Size = new System.Drawing.Size(81, 21);
            this.PaID_Cbox.TabIndex = 66;
            this.PaID_Cbox.Text = "Patient ID";
            this.PaID_Cbox.SelectionChangeCommitted += new System.EventHandler(this.PaID_Cbox_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(293, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Doctor name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(293, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Patient name:";
            // 
            // PaName_Tbox
            // 
            this.PaName_Tbox.Enabled = false;
            this.PaName_Tbox.Location = new System.Drawing.Point(297, 207);
            this.PaName_Tbox.Name = "PaName_Tbox";
            this.PaName_Tbox.Size = new System.Drawing.Size(258, 20);
            this.PaName_Tbox.TabIndex = 63;
            // 
            // DocID_Cbox
            // 
            this.DocID_Cbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID_Cbox.FormattingEnabled = true;
            this.DocID_Cbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DocID_Cbox.Location = new System.Drawing.Point(210, 160);
            this.DocID_Cbox.Name = "DocID_Cbox";
            this.DocID_Cbox.Size = new System.Drawing.Size(81, 21);
            this.DocID_Cbox.TabIndex = 62;
            this.DocID_Cbox.Text = "Doctor ID";
            this.DocID_Cbox.SelectionChangeCommitted += new System.EventHandler(this.DocID_Cbox_SelectionChangeCommitted);
            // 
            // DocName_Tbox
            // 
            this.DocName_Tbox.Enabled = false;
            this.DocName_Tbox.Location = new System.Drawing.Point(297, 161);
            this.DocName_Tbox.Name = "DocName_Tbox";
            this.DocName_Tbox.Size = new System.Drawing.Size(258, 20);
            this.DocName_Tbox.TabIndex = 61;
            // 
            // ApDate
            // 
            this.ApDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ApDate.Location = new System.Drawing.Point(570, 161);
            this.ApDate.Name = "ApDate";
            this.ApDate.Size = new System.Drawing.Size(200, 20);
            this.ApDate.TabIndex = 67;
            // 
            // ApTime
            // 
            this.ApTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApTime.CustomFormat = "HH:mm";
            this.ApTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ApTime.Location = new System.Drawing.Point(570, 207);
            this.ApTime.Name = "ApTime";
            this.ApTime.ShowUpDown = true;
            this.ApTime.Size = new System.Drawing.Size(200, 20);
            this.ApTime.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(774, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 70;
            this.label12.Text = "Note:";
            // 
            // ApNote_Tbox
            // 
            this.ApNote_Tbox.Location = new System.Drawing.Point(778, 159);
            this.ApNote_Tbox.Multiline = true;
            this.ApNote_Tbox.Name = "ApNote_Tbox";
            this.ApNote_Tbox.Size = new System.Drawing.Size(307, 68);
            this.ApNote_Tbox.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(47, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Clinic MS";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Appoint_Lb;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Presc_Lb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Doc_Lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Pa_Lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ApGridView1;
        private System.Windows.Forms.ComboBox PaID_Cbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PaName_Tbox;
        private System.Windows.Forms.ComboBox DocID_Cbox;
        private System.Windows.Forms.TextBox DocName_Tbox;
        private System.Windows.Forms.DateTimePicker ApTime;
        private System.Windows.Forms.DateTimePicker ApDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ApNote_Tbox;
        private System.Windows.Forms.Label label1;
    }
}