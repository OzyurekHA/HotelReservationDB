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
            listBox1 = new ListBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 97);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Oda Tipi";
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(162, 94);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(213, 27);
            txtTypeName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 211);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Kapasite";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 127);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(213, 76);
            txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 244);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 0;
            label4.Text = "Gecelik Fiyat";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 241);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(213, 27);
            txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(33, 49);
            label5.Name = "label5";
            label5.Size = new Size(262, 31);
            label5.TabIndex = 0;
            label5.Text = "Oda tiplerini belirleyiniz";
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(162, 209);
            nudCapacity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(213, 27);
            nudCapacity.TabIndex = 2;
            nudCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(474, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 204);
            listBox1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LimeGreen;
            label6.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(474, 36);
            label6.Name = "label6";
            label6.Size = new Size(129, 31);
            label6.TabIndex = 0;
            label6.Text = "Oda Tipleri";
            // 
            // button1
            // 
            button1.Location = new Point(239, 284);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(518, 284);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 4;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // Frm_RoomType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 348);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}