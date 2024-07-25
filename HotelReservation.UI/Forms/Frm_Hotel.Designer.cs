namespace HotelReservation.UI.Forms
{
    partial class Frm_Hotel
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
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            nudStars = new NumericUpDown();
            lstHotels = new ListBox();
            label8 = new Label();
            label7 = new Label();
            btnSil = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 73);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Otel Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Adres";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 103);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(158, 136);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 172);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 204);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 0;
            label5.Text = "Yıldız";
            // 
            // nudStars
            // 
            nudStars.Location = new Point(158, 202);
            nudStars.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudStars.Name = "nudStars";
            nudStars.Size = new Size(250, 27);
            nudStars.TabIndex = 4;
            // 
            // lstHotels
            // 
            lstHotels.FormattingEnabled = true;
            lstHotels.Location = new Point(474, 70);
            lstHotels.Name = "lstHotels";
            lstHotels.Size = new Size(288, 204);
            lstHotels.TabIndex = 6;
            lstHotels.SelectedIndexChanged += lstHotels_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LimeGreen;
            label8.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(474, 23);
            label8.Name = "label8";
            label8.Size = new Size(154, 31);
            label8.TabIndex = 10;
            label8.Text = "Kayıtlı Oteller";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(41, 23);
            label7.Name = "label7";
            label7.Size = new Size(234, 31);
            label7.TabIndex = 9;
            label7.Text = "Otel Bilgilerini Giriniz";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(639, 280);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(123, 29);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(285, 280);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(123, 29);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Frm_Hotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 348);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lstHotels);
            Controls.Add(nudStars);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Frm_Hotel";
            Text = "Frm_Hotel";
            Load += Frm_Hotel_Load;
            ((System.ComponentModel.ISupportInitialize)nudStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private NumericUpDown nudStars;
        private ListBox lstHotels;
        private Label label8;
        private Label label7;
        private Button btnSil;
        private Button btnKaydet;
    }
}