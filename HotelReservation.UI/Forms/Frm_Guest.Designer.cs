namespace HotelReservation.UI.Forms
{
    partial class Frm_Guest
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
            txtName = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            btnKaydet = new Button();
            lstMisafir = new ListBox();
            label8 = new Label();
            btnSil = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 73);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 106);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(158, 103);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(250, 27);
            txtSurname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 139);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Doğum Tarihi";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 172);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 1;
            label4.Text = "Adres";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(158, 202);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 205);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 1;
            label5.Text = "Telefon";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(158, 136);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 238);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 1;
            label6.Text = "E-posta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(41, 23);
            label7.Name = "label7";
            label7.Size = new Size(263, 31);
            label7.TabIndex = 3;
            label7.Text = "Misafir Bilgilerini Giriniz";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(276, 280);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(132, 29);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += button1_Click;
            // 
            // lstMisafir
            // 
            lstMisafir.FormattingEnabled = true;
            lstMisafir.Location = new Point(474, 70);
            lstMisafir.Name = "lstMisafir";
            lstMisafir.Size = new Size(288, 204);
            lstMisafir.TabIndex = 7;
            lstMisafir.SelectedIndexChanged += lstMisafir_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LimeGreen;
            label8.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(474, 23);
            label8.Name = "label8";
            label8.Size = new Size(183, 31);
            label8.TabIndex = 8;
            label8.Text = "Kayıtlı Misafirler";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(639, 280);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(123, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Listeden Çıkar";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Frm_Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 348);
            Controls.Add(btnSil);
            Controls.Add(label8);
            Controls.Add(lstMisafir);
            Controls.Add(btnKaydet);
            Controls.Add(label7);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "Frm_Guest";
            Text = "Frm_Guest";
            Load += Frm_Guest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private DateTimePicker dtpBirthDate;
        private Label label6;
        private Label label7;
        private Button btnKaydet;
        private ListBox lstMisafir;
        private Label label8;
        private Button btnSil;
    }
}