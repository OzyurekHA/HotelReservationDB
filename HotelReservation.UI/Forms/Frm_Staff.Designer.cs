namespace HotelReservation.UI.Forms
{
    partial class Frm_Staff
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPosition = new TextBox();
            label4 = new Label();
            txtSalary = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            cmbHotel = new ComboBox();
            label9 = new Label();
            lstEmployees = new ListBox();
            label10 = new Label();
            label11 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            dtpBirthDate = new DateTimePicker();
            dtpHireDate = new DateTimePicker();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 81);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 27);
            txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 114);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 27);
            txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Pozisyon";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(156, 144);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(168, 27);
            txtPosition.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 180);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 0;
            label4.Text = "Yıllık Maaş";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(156, 177);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(168, 27);
            txtSalary.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 213);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 0;
            label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 246);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 279);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 312);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 0;
            label8.Text = "İşe Giriş Tarihi";
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(330, 111);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(168, 28);
            cmbHotel.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 81);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 0;
            label9.Text = "Çalıştığı Otel";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.Location = new Point(504, 78);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(258, 264);
            lstEmployees.TabIndex = 10;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LimeGreen;
            label10.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(504, 23);
            label10.Name = "label10";
            label10.Size = new Size(184, 31);
            label10.TabIndex = 12;
            label10.Text = "Kayıtlı Çalışanlar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gold;
            label11.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(41, 23);
            label11.Name = "label11";
            label11.Size = new Size(264, 31);
            label11.TabIndex = 11;
            label11.Text = "Çalışan Bilgilerini Giriniz";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(668, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(387, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(156, 210);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(168, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(156, 307);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(168, 27);
            dtpHireDate.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(156, 243);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(168, 27);
            txtPhone.TabIndex = 5;
            // 
            // Frm_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 418);
            Controls.Add(dtpHireDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(lstEmployees);
            Controls.Add(cmbHotel);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(txtSalary);
            Controls.Add(label4);
            Controls.Add(txtPosition);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "Frm_Staff";
            Text = "Frm_Staff";
            Load += Frm_Staff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPosition;
        private Label label4;
        private TextBox txtSalary;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private ComboBox cmbHotel;
        private Label label9;
        private ListBox lstEmployees;
        private Label label10;
        private Label label11;
        private Button btnDelete;
        private Button btnSave;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpHireDate;
        private TextBox txtPhone;
    }
}