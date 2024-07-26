namespace HotelReservation.UI.Forms
{
    partial class Frm_Main
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
            btnHotel = new Button();
            btnRoomType = new Button();
            btnGuest = new Button();
            btnStaff = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnHotel
            // 
            btnHotel.Location = new Point(498, 111);
            btnHotel.Name = "btnHotel";
            btnHotel.Size = new Size(223, 46);
            btnHotel.TabIndex = 0;
            btnHotel.Text = "Otel Kayıt";
            btnHotel.UseVisualStyleBackColor = true;
            btnHotel.Click += button1_Click;
            // 
            // btnRoomType
            // 
            btnRoomType.Location = new Point(498, 163);
            btnRoomType.Name = "btnRoomType";
            btnRoomType.Size = new Size(223, 46);
            btnRoomType.TabIndex = 1;
            btnRoomType.Text = "Oda Tipi Kayıt";
            btnRoomType.UseVisualStyleBackColor = true;
            btnRoomType.Click += btnRoomType_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(498, 215);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(223, 46);
            btnGuest.TabIndex = 2;
            btnGuest.Text = "Misafir Kayıt";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnStaff
            // 
            btnStaff.Location = new Point(498, 267);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(223, 46);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Çalışan Kayıt";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 74);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 4;
            label1.Text = "Kayıt İşlemlerinden Birini Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(498, 30);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 4;
            label2.Text = "Kayıt İşlemleri";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStaff);
            Controls.Add(btnGuest);
            Controls.Add(btnRoomType);
            Controls.Add(btnHotel);
            Name = "Frm_Main";
            Text = "Frm_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHotel;
        private Button btnRoomType;
        private Button btnGuest;
        private Button btnStaff;
        private Label label1;
        private Label label2;
    }
}