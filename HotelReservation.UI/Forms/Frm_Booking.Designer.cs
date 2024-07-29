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
            btnReservation = new Button();
            nudGuest = new NumericUpDown();
            label8 = new Label();
            groupBox4 = new GroupBox();
            lblTotalPrice = new Label();
            cmbPaymentDate = new ComboBox();
            cmbPaymentMethod = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            grpGuestInput = new GroupBox();
            label19 = new Label();
            txtName4 = new TextBox();
            txtEmail4 = new TextBox();
            dtpBirthDate4 = new DateTimePicker();
            txtSurname4 = new TextBox();
            txtAddress4 = new TextBox();
            txtPhone4 = new TextBox();
            txtName3 = new TextBox();
            txtEmail3 = new TextBox();
            dtpBirthDate3 = new DateTimePicker();
            txtSurname3 = new TextBox();
            txtAddress3 = new TextBox();
            txtPhone3 = new TextBox();
            txtName2 = new TextBox();
            txtEmail2 = new TextBox();
            dtpBirthDate2 = new DateTimePicker();
            txtSurname2 = new TextBox();
            txtAddress2 = new TextBox();
            txtPhone2 = new TextBox();
            label13 = new Label();
            txtName1 = new TextBox();
            txtEmail = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtSurname = new TextBox();
            label14 = new Label();
            txtAddress = new TextBox();
            label15 = new Label();
            txtPhone = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuest).BeginInit();
            groupBox4.SuspendLayout();
            grpGuestInput.SuspendLayout();
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
            label3.Location = new Point(229, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Check-Out Tarihi";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(229, 96);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(200, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(6, 96);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(200, 27);
            dtpCheckIn.TabIndex = 3;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(6, 149);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(200, 28);
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
            btnReserve.Location = new Point(6, 136);
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
            groupBox2.Location = new Point(336, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 193);
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
            cmbRoom.Location = new Point(229, 149);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(200, 28);
            cmbRoom.TabIndex = 4;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 126);
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
            groupBox3.Location = new Point(818, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 193);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "3";
            // 
            // btnReservation
            // 
            btnReservation.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReservation.Location = new Point(818, 544);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(298, 39);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "Rezervasyonu Tamamla";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btn_Click;
            // 
            // nudGuest
            // 
            nudGuest.Location = new Point(6, 73);
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
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTotalPrice);
            groupBox4.Controls.Add(cmbPaymentDate);
            groupBox4.Controls.Add(cmbPaymentMethod);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(818, 285);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(298, 242);
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
            cmbPaymentDate.Size = new Size(286, 28);
            cmbPaymentDate.TabIndex = 3;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Kart", "Google Pay", "PayPal" });
            cmbPaymentMethod.Location = new Point(6, 194);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(286, 28);
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
            grpGuestInput.Controls.Add(label19);
            grpGuestInput.Controls.Add(txtName4);
            grpGuestInput.Controls.Add(txtEmail4);
            grpGuestInput.Controls.Add(dtpBirthDate4);
            grpGuestInput.Controls.Add(txtSurname4);
            grpGuestInput.Controls.Add(txtAddress4);
            grpGuestInput.Controls.Add(txtPhone4);
            grpGuestInput.Controls.Add(txtName3);
            grpGuestInput.Controls.Add(txtEmail3);
            grpGuestInput.Controls.Add(dtpBirthDate3);
            grpGuestInput.Controls.Add(txtSurname3);
            grpGuestInput.Controls.Add(txtAddress3);
            grpGuestInput.Controls.Add(txtPhone3);
            grpGuestInput.Controls.Add(txtName2);
            grpGuestInput.Controls.Add(txtEmail2);
            grpGuestInput.Controls.Add(dtpBirthDate2);
            grpGuestInput.Controls.Add(txtSurname2);
            grpGuestInput.Controls.Add(txtAddress2);
            grpGuestInput.Controls.Add(txtPhone2);
            grpGuestInput.Controls.Add(label13);
            grpGuestInput.Controls.Add(txtName1);
            grpGuestInput.Controls.Add(txtEmail);
            grpGuestInput.Controls.Add(dtpBirthDate);
            grpGuestInput.Controls.Add(txtSurname);
            grpGuestInput.Controls.Add(label14);
            grpGuestInput.Controls.Add(txtAddress);
            grpGuestInput.Controls.Add(label15);
            grpGuestInput.Controls.Add(txtPhone);
            grpGuestInput.Controls.Add(label16);
            grpGuestInput.Controls.Add(label17);
            grpGuestInput.Controls.Add(label18);
            grpGuestInput.Location = new Point(12, 285);
            grpGuestInput.Name = "grpGuestInput";
            grpGuestInput.Size = new Size(800, 242);
            grpGuestInput.TabIndex = 11;
            grpGuestInput.TabStop = false;
            grpGuestInput.Text = "4";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label19.Location = new Point(6, 23);
            label19.Name = "label19";
            label19.Size = new Size(176, 31);
            label19.TabIndex = 50;
            label19.Text = "Misafir Bilgileri";
            // 
            // txtName4
            // 
            txtName4.Location = new Point(6, 192);
            txtName4.Name = "txtName4";
            txtName4.Size = new Size(124, 27);
            txtName4.TabIndex = 44;
            // 
            // txtEmail4
            // 
            txtEmail4.Location = new Point(656, 192);
            txtEmail4.Name = "txtEmail4";
            txtEmail4.Size = new Size(124, 27);
            txtEmail4.TabIndex = 49;
            // 
            // dtpBirthDate4
            // 
            dtpBirthDate4.Format = DateTimePickerFormat.Short;
            dtpBirthDate4.Location = new Point(266, 192);
            dtpBirthDate4.Name = "dtpBirthDate4";
            dtpBirthDate4.Size = new Size(124, 27);
            dtpBirthDate4.TabIndex = 46;
            // 
            // txtSurname4
            // 
            txtSurname4.Location = new Point(136, 192);
            txtSurname4.Name = "txtSurname4";
            txtSurname4.Size = new Size(124, 27);
            txtSurname4.TabIndex = 45;
            // 
            // txtAddress4
            // 
            txtAddress4.Location = new Point(396, 192);
            txtAddress4.Name = "txtAddress4";
            txtAddress4.Size = new Size(124, 27);
            txtAddress4.TabIndex = 47;
            // 
            // txtPhone4
            // 
            txtPhone4.Location = new Point(526, 192);
            txtPhone4.Name = "txtPhone4";
            txtPhone4.Size = new Size(124, 27);
            txtPhone4.TabIndex = 48;
            // 
            // txtName3
            // 
            txtName3.Location = new Point(6, 159);
            txtName3.Name = "txtName3";
            txtName3.Size = new Size(124, 27);
            txtName3.TabIndex = 38;
            // 
            // txtEmail3
            // 
            txtEmail3.Location = new Point(656, 159);
            txtEmail3.Name = "txtEmail3";
            txtEmail3.Size = new Size(124, 27);
            txtEmail3.TabIndex = 43;
            // 
            // dtpBirthDate3
            // 
            dtpBirthDate3.Format = DateTimePickerFormat.Short;
            dtpBirthDate3.Location = new Point(266, 159);
            dtpBirthDate3.Name = "dtpBirthDate3";
            dtpBirthDate3.Size = new Size(124, 27);
            dtpBirthDate3.TabIndex = 40;
            // 
            // txtSurname3
            // 
            txtSurname3.Location = new Point(136, 159);
            txtSurname3.Name = "txtSurname3";
            txtSurname3.Size = new Size(124, 27);
            txtSurname3.TabIndex = 39;
            // 
            // txtAddress3
            // 
            txtAddress3.Location = new Point(396, 159);
            txtAddress3.Name = "txtAddress3";
            txtAddress3.Size = new Size(124, 27);
            txtAddress3.TabIndex = 41;
            // 
            // txtPhone3
            // 
            txtPhone3.Location = new Point(526, 159);
            txtPhone3.Name = "txtPhone3";
            txtPhone3.Size = new Size(124, 27);
            txtPhone3.TabIndex = 42;
            // 
            // txtName2
            // 
            txtName2.Location = new Point(6, 126);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(124, 27);
            txtName2.TabIndex = 32;
            // 
            // txtEmail2
            // 
            txtEmail2.Location = new Point(656, 126);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(124, 27);
            txtEmail2.TabIndex = 37;
            // 
            // dtpBirthDate2
            // 
            dtpBirthDate2.Format = DateTimePickerFormat.Short;
            dtpBirthDate2.Location = new Point(266, 126);
            dtpBirthDate2.Name = "dtpBirthDate2";
            dtpBirthDate2.Size = new Size(124, 27);
            dtpBirthDate2.TabIndex = 34;
            // 
            // txtSurname2
            // 
            txtSurname2.Location = new Point(136, 126);
            txtSurname2.Name = "txtSurname2";
            txtSurname2.Size = new Size(124, 27);
            txtSurname2.TabIndex = 33;
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(396, 126);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(124, 27);
            txtAddress2.TabIndex = 35;
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(526, 126);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(124, 27);
            txtPhone2.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 70);
            label13.Name = "label13";
            label13.Size = new Size(28, 20);
            label13.TabIndex = 26;
            label13.Text = "Ad";
            // 
            // txtName1
            // 
            txtName1.Location = new Point(6, 93);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(124, 27);
            txtName1.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(656, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(124, 27);
            txtEmail.TabIndex = 31;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(266, 93);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(124, 27);
            dtpBirthDate.TabIndex = 28;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(136, 93);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(124, 27);
            txtSurname.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(656, 70);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 21;
            label14.Text = "E-Posta";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(396, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(124, 27);
            txtAddress.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(526, 70);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 22;
            label15.Text = "Telefon";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(526, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(124, 27);
            txtPhone.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(396, 70);
            label16.Name = "label16";
            label16.Size = new Size(47, 20);
            label16.TabIndex = 23;
            label16.Text = "Adres";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(136, 70);
            label17.Name = "label17";
            label17.Size = new Size(50, 20);
            label17.TabIndex = 25;
            label17.Text = "Soyad";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(266, 70);
            label18.Name = "label18";
            label18.Size = new Size(98, 20);
            label18.TabIndex = 24;
            label18.Text = "Doğum Tarihi";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 633);
            Controls.Add(btnReservation);
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
            grpGuestInput.ResumeLayout(false);
            grpGuestInput.PerformLayout();
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
        private Label label13;
        private TextBox txtName1;
        private TextBox txtEmail;
        private DateTimePicker dtpBirthDate;
        private TextBox txtSurname;
        private Label label14;
        private TextBox txtAddress;
        private Label label15;
        private TextBox txtPhone;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtName4;
        private TextBox txtEmail4;
        private DateTimePicker dtpBirthDate4;
        private TextBox txtSurname4;
        private TextBox txtAddress4;
        private TextBox txtPhone4;
        private TextBox txtName3;
        private TextBox txtEmail3;
        private DateTimePicker dtpBirthDate3;
        private TextBox txtSurname3;
        private TextBox txtAddress3;
        private TextBox txtPhone3;
        private TextBox txtName2;
        private TextBox txtEmail2;
        private DateTimePicker dtpBirthDate2;
        private TextBox txtSurname2;
        private TextBox txtAddress2;
        private TextBox txtPhone2;
        private Button btnReservation;
        private Label lblTotalPrice;
    }
}