namespace HotelReservation.UI.Forms
{
    partial class Frm_RoomType
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
            txtTypeName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            nudCapacity = new NumericUpDown();
            lstRoomType = new ListBox();
            label6 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 73);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Oda Tipi";
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(158, 70);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(250, 27);
            txtTypeName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 106);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 217);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Kapasite";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(158, 103);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 106);
            txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 250);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 0;
            label4.Text = "Gecelik Fiyat";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(158, 247);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(41, 23);
            label5.Name = "label5";
            label5.Size = new Size(262, 31);
            label5.TabIndex = 0;
            label5.Text = "Oda tiplerini belirleyiniz";
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(158, 215);
            nudCapacity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(250, 27);
            nudCapacity.TabIndex = 2;
            nudCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lstRoomType
            // 
            lstRoomType.FormattingEnabled = true;
            lstRoomType.Location = new Point(474, 70);
            lstRoomType.Name = "lstRoomType";
            lstRoomType.Size = new Size(288, 204);
            lstRoomType.TabIndex = 5;
            lstRoomType.SelectedIndexChanged += lstRoomType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LimeGreen;
            label6.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(474, 23);
            label6.Name = "label6";
            label6.Size = new Size(129, 31);
            label6.TabIndex = 0;
            label6.Text = "Oda Tipleri";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(285, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(639, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Frm_RoomType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 348);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstRoomType);
            Controls.Add(nudCapacity);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTypeName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Frm_RoomType";
            Text = "Frm_RoomType";
            Load += Frm_RoomType_Load;
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTypeName;
        private Label label2;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private NumericUpDown nudCapacity;
        private ListBox lstRoomType;
        private Label label6;
        private Button btnAdd;
        private Button btnDelete;
    }
}