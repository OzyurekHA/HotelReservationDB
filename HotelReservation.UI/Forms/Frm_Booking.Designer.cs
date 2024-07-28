﻿namespace HotelReservation.UI.Forms
{
    partial class Frm_Booking
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            cmbRoomType = new ComboBox();
            label4 = new Label();
            btnReserve = new Button();
            groupBox1 = new GroupBox();
            cmbHotel = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            cmbRoom = new ComboBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(460, 31);
            label1.TabIndex = 0;
            label1.Text = "Lütfen rezervasyon bilgilerini doldurunuz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-in Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Check-Out Tarihi";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(151, 96);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(139, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(6, 96);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(139, 27);
            dtpCheckIn.TabIndex = 3;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(6, 149);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(284, 28);
            cmbRoomType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 0;
            label4.Text = "Oda Tipi";
            // 
            // btnReserve
            // 
            btnReserve.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReserve.Location = new Point(642, 346);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(266, 41);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Misafir Kaydı >>";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbHotel);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 245);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(6, 93);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(286, 28);
            cmbHotel.TabIndex = 3;
            cmbHotel.SelectedIndexChanged += cmbHotel_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(242, 31);
            label7.TabIndex = 2;
            label7.Text = "Nereye Gidiyorsunuz?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "Oteller";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpCheckIn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbRoom);
            groupBox2.Controls.Add(cmbRoomType);
            groupBox2.Controls.Add(dtpCheckOut);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(316, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 245);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(276, 31);
            label9.TabIndex = 2;
            label9.Text = "Ne Zaman Gidiyorsunuz?";
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(6, 203);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(284, 28);
            cmbRoom.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 0;
            label5.Text = "Uygun Odalar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(628, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 242);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(14, 94);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(266, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(14, 23);
            label8.Name = "label8";
            label8.Size = new Size(154, 31);
            label8.TabIndex = 2;
            label8.Text = "Misafir Sayısı";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 407);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnReserve);
            Controls.Add(label1);
            Name = "Frm_Booking";
            Text = "Frm_Booking";
            Load += Frm_Booking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private ComboBox cmbRoomType;
        private Label label4;
        private Button btnReserve;
        private GroupBox groupBox1;
        private Label label6;
        private GroupBox groupBox2;
        private ComboBox cmbRoom;
        private Label label5;
        private Label label7;
        private GroupBox groupBox3;
        private Label label8;
        private ComboBox cmbHotel;
        private Label label9;
        private NumericUpDown numericUpDown1;
    }
}