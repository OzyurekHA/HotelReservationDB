namespace HotelReservation.UI.Forms
{
    partial class Frm_Room
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
            cmbHotel = new ComboBox();
            cmbIsReserved = new ComboBox();
            label4 = new Label();
            cmbRoomType = new ComboBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 215);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 0;
            label1.Text = "Rezerve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 0;
            label2.Text = "Bulunduğu Otel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 0;
            label3.Text = "Oda Tipi";
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(237, 160);
            cmbHotel.Margin = new Padding(4);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(224, 38);
            cmbHotel.TabIndex = 1;
            // 
            // cmbIsReserved
            // 
            cmbIsReserved.FormattingEnabled = true;
            cmbIsReserved.Items.AddRange(new object[] { "Dolu", "Boş" });
            cmbIsReserved.Location = new Point(237, 212);
            cmbIsReserved.Margin = new Padding(4);
            cmbIsReserved.Name = "cmbIsReserved";
            cmbIsReserved.Size = new Size(224, 38);
            cmbIsReserved.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 39);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 0;
            label4.Text = "Oda Kayıt Formu";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(237, 110);
            cmbRoomType.Margin = new Padding(4);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(224, 38);
            cmbRoomType.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(237, 277);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(224, 37);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Oda Ekle";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Frm_Room
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 371);
            Controls.Add(btnCreate);
            Controls.Add(cmbIsReserved);
            Controls.Add(cmbRoomType);
            Controls.Add(cmbHotel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "Frm_Room";
            Text = "Frm_Room";
            Load += Frm_Room_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbHotel;
        private ComboBox cmbIsReserved;
        private Label label4;
        private ComboBox cmbRoomType;
        private Button btnCreate;
    }
}