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
            cmbRoom = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            clbGuests = new CheckedListBox();
            btnReserve = new Button();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(406, 30);
            label1.TabIndex = 0;
            label1.Text = "Lütfen rezervasyon bilgilerini doldurunuz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 91);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-in Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 91);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Check-Out Tarihi";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(388, 114);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(250, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(51, 114);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(250, 27);
            dtpCheckIn.TabIndex = 3;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(51, 194);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(250, 28);
            cmbRoom.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 171);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 0;
            label4.Text = "Oda Tipi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 171);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 0;
            label5.Text = "Misafir Listesi";
            // 
            // clbGuests
            // 
            clbGuests.FormattingEnabled = true;
            clbGuests.Location = new Point(388, 194);
            clbGuests.Name = "clbGuests";
            clbGuests.Size = new Size(250, 114);
            clbGuests.TabIndex = 5;
            // 
            // btnReserve
            // 
            btnReserve.Font = new Font("Segoe UI", 13F);
            btnReserve.Location = new Point(388, 331);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(250, 41);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Rezervasyonu Tamamla";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.DarkOrange;
            lblTotalPrice.Font = new Font("Segoe UI", 13F);
            lblTotalPrice.Location = new Point(51, 336);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(147, 30);
            lblTotalPrice.TabIndex = 7;
            lblTotalPrice.Text = "Toplam Ücret:";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 404);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnReserve);
            Controls.Add(clbGuests);
            Controls.Add(cmbRoom);
            Controls.Add(dtpCheckIn);
            Controls.Add(dtpCheckOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Frm_Booking";
            Text = "Frm_Booking";
            Load += Frm_Booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private ComboBox cmbRoom;
        private Label label4;
        private Label label5;
        private CheckedListBox clbGuests;
        private Button btnReserve;
        private Label lblTotalPrice;
    }
}