namespace UpdateInfo
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.cbbJob = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(17, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Tuổi";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(96, 64);
            this.nudAge.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(328, 26);
            this.nudAge.TabIndex = 2;
            this.nudAge.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 109);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới";
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGender.Location = new System.Drawing.Point(96, 106);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(328, 28);
            this.cbbGender.TabIndex = 3;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(17, 150);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(47, 20);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "Nghề";
            // 
            // cbbJob
            // 
            this.cbbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJob.FormattingEnabled = true;
            this.cbbJob.Items.AddRange(new object[] {
            "Học sinh",
            "Sinh viên",
            "Kỹ sư phần mềm",
            "Kỹ sư xây dựng",
            "Bác sĩ",
            "Nha sĩ",
            "Ca sĩ",
            "Nhạc sĩ",
            "Khác"});
            this.cbbJob.Location = new System.Drawing.Point(96, 147);
            this.cbbJob.Name = "cbbJob";
            this.cbbJob.Size = new System.Drawing.Size(328, 28);
            this.cbbJob.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 193);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.AutoSize = true;
            this.btnUndo.Location = new System.Drawing.Point(21, 241);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(190, 30);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Trở lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(234, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 289);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.cbbJob);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cbbJob;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
    }
}

