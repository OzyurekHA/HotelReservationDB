namespace HotelReservation.UI.Forms
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
            nudGuest = new NumericUpDown();
            label8 = new Label();
            btnReservation = new Button();
            groupBox4 = new GroupBox();
            lblTotalPrice = new Label();
            cmbPaymentDate = new ComboBox();
            cmbPaymentMethod = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            grpGuestInput = new GroupBox();
            btnSaveGuests = new Button();
            label19 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuest).BeginInit();
            groupBox4.SuspendLayout();
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
            label3.Location = new Point(246, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Check-Out Tarihi";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(246, 96);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(212, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(6, 96);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(212, 27);
            dtpCheckIn.TabIndex = 3;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(6, 149);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(212, 28);
            cmbRoomType.TabIndex = 4;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
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
            btnReserve.Location = new Point(23, 139);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(286, 41);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Misafir Ekle >>";
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
            groupBox1.Size = new Size(318, 196);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "1";
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(6, 93);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(306, 28);
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
            groupBox2.Location = new Point(336, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 193);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "2";
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
            cmbRoom.Location = new Point(246, 149);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(212, 28);
            cmbRoom.TabIndex = 4;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 126);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 0;
            label5.Text = "Uygun Odalar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudGuest);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnReserve);
            groupBox3.Location = new Point(829, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 193);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "3";
            // 
            // nudGuest
            // 
            nudGuest.Location = new Point(23, 73);
            nudGuest.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudGuest.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuest.Name = "nudGuest";
            nudGuest.Size = new Size(286, 27);
            nudGuest.TabIndex = 3;
            nudGuest.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // btnReservation
            // 
            btnReservation.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReservation.Location = new Point(804, 538);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(352, 41);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "<<Rezervasyonu Tamamla>>";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTotalPrice);
            groupBox4.Controls.Add(cmbPaymentDate);
            groupBox4.Controls.Add(cmbPaymentMethod);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(804, 285);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(352, 247);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "5";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalPrice.Location = new Point(6, 70);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(141, 28);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Toplam Tutar: ";
            // 
            // cmbPaymentDate
            // 
            cmbPaymentDate.FormattingEnabled = true;
            cmbPaymentDate.Items.AddRange(new object[] { "Şimdi Öde", "Check-in Tarihinde Öde" });
            cmbPaymentDate.Location = new Point(6, 140);
            cmbPaymentDate.Name = "cmbPaymentDate";
            cmbPaymentDate.Size = new Size(340, 28);
            cmbPaymentDate.TabIndex = 3;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Kart", "Google Pay", "PayPal" });
            cmbPaymentMethod.Location = new Point(6, 194);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(340, 28);
            cmbPaymentMethod.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(180, 31);
            label10.TabIndex = 2;
            label10.Text = "Ödeme Yöntemi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 171);
            label12.Name = "label12";
            label12.Size = new Size(168, 20);
            label12.TabIndex = 0;
            label12.Text = "Nasıl ödemek istersiniz?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 117);
            label11.Name = "label11";
            label11.Size = new Size(202, 20);
            label11.TabIndex = 0;
            label11.Text = "Ne zaman ödemek istersiniz?";
            // 
            // grpGuestInput
            // 
            grpGuestInput.Location = new Point(12, 355);
            grpGuestInput.Name = "grpGuestInput";
            grpGuestInput.Size = new Size(786, 177);
            grpGuestInput.TabIndex = 11;
            grpGuestInput.TabStop = false;
            grpGuestInput.Text = "4";
            // 
            // btnSaveGuests
            // 
            btnSaveGuests.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSaveGuests.Location = new Point(508, 538);
            btnSaveGuests.Name = "btnSaveGuests";
            btnSaveGuests.Size = new Size(286, 41);
            btnSaveGuests.TabIndex = 51;
            btnSaveGuests.Text = "Misafirleri Kaydet >>";
            btnSaveGuests.UseVisualStyleBackColor = true;
            btnSaveGuests.Click += btnSaveGuests_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label19.Location = new Point(18, 308);
            label19.Name = "label19";
            label19.Size = new Size(176, 31);
            label19.TabIndex = 52;
            label19.Text = "Misafir Bilgileri";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1168, 606);
            Controls.Add(label19);
            Controls.Add(btnReservation);
            Controls.Add(btnSaveGuests);
            Controls.Add(grpGuestInput);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)nudGuest).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private NumericUpDown nudGuest;
        private GroupBox groupBox4;
        private ComboBox cmbPaymentMethod;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmbPaymentDate;
        private GroupBox grpGuestInput;
        private Button btnReservation;
        private Label lblTotalPrice;
        private Button btnSaveGuests;
        private Label label19;
    }
}