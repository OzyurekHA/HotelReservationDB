namespace HotelReservation.UI.Forms
{
    partial class Frm_OneGuest
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
            btnKaydet = new Button();
            label7 = new Label();
            dtpBirthDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(140, 246);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(124, 29);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(29, 27);
            label7.Name = "label7";
            label7.Size = new Size(263, 31);
            label7.TabIndex = 16;
            label7.Text = "Misafir Bilgilerini Giriniz";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(140, 114);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(124, 27);
            dtpBirthDate.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 216);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 8;
            label6.Text = "E-Posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 183);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 150);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 10;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 11;
            label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 51);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 13;
            label1.Text = "Ad";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 180);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(124, 27);
            txtPhone.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 147);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(124, 27);
            txtAddress.TabIndex = 17;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(140, 81);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(124, 27);
            txtSurname.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(124, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(124, 27);
            txtName.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 308);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Frm_OneGuest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Name = "Frm_OneGuest";
            Text = "Frm_OneGuest";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtName;
        private GroupBox groupBox1;
    }
}