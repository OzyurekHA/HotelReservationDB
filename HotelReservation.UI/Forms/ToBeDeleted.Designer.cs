namespace HotelReservation.UI.Forms
{
    partial class ToBeDeleted
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
            nudCount = new NumericUpDown();
            btnAdd = new Button();
            grpGuestInput = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
            SuspendLayout();
            // 
            // nudCount
            // 
            nudCount.Location = new Point(12, 64);
            nudCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(150, 27);
            nudCount.TabIndex = 0;
            nudCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(168, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // grpGuestInput
            // 
            grpGuestInput.Location = new Point(12, 97);
            grpGuestInput.Name = "grpGuestInput";
            grpGuestInput.Size = new Size(978, 248);
            grpGuestInput.TabIndex = 3;
            grpGuestInput.TabStop = false;
            grpGuestInput.Text = "grpGuestInput";
            // 
            // ToBeDeleted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 450);
            Controls.Add(grpGuestInput);
            Controls.Add(btnAdd);
            Controls.Add(nudCount);
            Name = "ToBeDeleted";
            Text = "ToBeDeleted";
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nudCount;
        private Button btnAdd;
        private GroupBox grpGuestInput;
    }
}