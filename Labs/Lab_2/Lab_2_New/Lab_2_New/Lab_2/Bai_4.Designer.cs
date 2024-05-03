namespace Lab2
{
    partial class Bai_4
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
            panel1 = new Panel();
            btnStart = new Button();
            btnReset = new Button();
            txtNum = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            txtLiterature = new TextBox();
            label7 = new Label();
            txtMath = new TextBox();
            panel2 = new Panel();
            txtWrite = new TextBox();
            txtRead = new TextBox();
            btnRead = new Button();
            btnWrite = new Button();
            txtAddressRead = new TextBox();
            txtAddressWrite = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnDeBai = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 32);
            label1.TabIndex = 0;
            label1.Text = "Số lượng sinh viên muốn nhập:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(txtNum);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(522, 144);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 211);
            panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(274, 118);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(146, 44);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.IndianRed;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(94, 118);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 44);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(383, 27);
            txtNum.Margin = new Padding(4);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(90, 39);
            txtNum.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 24);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 39);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 6;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 32);
            label3.TabIndex = 8;
            label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(149, 72);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(290, 39);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 123);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 10;
            label4.Text = "MSSV:";
            // 
            // txtID
            // 
            txtID.Location = new Point(149, 123);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(290, 39);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtMath_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 170);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 12;
            label5.Text = "Văn:";
            // 
            // txtLiterature
            // 
            txtLiterature.Location = new Point(149, 170);
            txtLiterature.Margin = new Padding(4);
            txtLiterature.Name = "txtLiterature";
            txtLiterature.Size = new Size(91, 39);
            txtLiterature.TabIndex = 11;
            txtLiterature.TextChanged += txtLiterature_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(254, 170);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 14;
            label7.Text = "Toán:";
            label7.Click += label7_Click;
            // 
            // txtMath
            // 
            txtMath.Location = new Point(338, 170);
            txtMath.Margin = new Padding(4);
            txtMath.Name = "txtMath";
            txtMath.Size = new Size(101, 39);
            txtMath.TabIndex = 17;
            txtMath.TextChanged += txtMath_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMath);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLiterature);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(18, 144);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 211);
            panel2.TabIndex = 19;
            // 
            // txtWrite
            // 
            txtWrite.BackColor = Color.White;
            txtWrite.Location = new Point(35, 438);
            txtWrite.Margin = new Padding(4);
            txtWrite.Multiline = true;
            txtWrite.Name = "txtWrite";
            txtWrite.ReadOnly = true;
            txtWrite.ScrollBars = ScrollBars.Both;
            txtWrite.Size = new Size(468, 265);
            txtWrite.TabIndex = 20;
            // 
            // txtRead
            // 
            txtRead.BackColor = Color.White;
            txtRead.Location = new Point(537, 438);
            txtRead.Margin = new Padding(4);
            txtRead.Multiline = true;
            txtRead.Name = "txtRead";
            txtRead.ReadOnly = true;
            txtRead.ScrollBars = ScrollBars.Both;
            txtRead.Size = new Size(468, 265);
            txtRead.TabIndex = 21;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.SteelBlue;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(699, 376);
            btnRead.Margin = new Padding(4);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(146, 44);
            btnRead.TabIndex = 22;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.SteelBlue;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = Color.White;
            btnWrite.Location = new Point(183, 376);
            btnWrite.Margin = new Padding(4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(146, 44);
            btnWrite.TabIndex = 23;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtAddressRead
            // 
            txtAddressRead.BackColor = SystemColors.Control;
            txtAddressRead.BorderStyle = BorderStyle.None;
            txtAddressRead.Location = new Point(526, 723);
            txtAddressRead.Margin = new Padding(4);
            txtAddressRead.Multiline = true;
            txtAddressRead.Name = "txtAddressRead";
            txtAddressRead.ReadOnly = true;
            txtAddressRead.Size = new Size(469, 87);
            txtAddressRead.TabIndex = 24;
            txtAddressRead.TextChanged += txtAddressRead_TextChanged;
            // 
            // txtAddressWrite
            // 
            txtAddressWrite.BackColor = SystemColors.Control;
            txtAddressWrite.BorderStyle = BorderStyle.None;
            txtAddressWrite.Location = new Point(34, 723);
            txtAddressWrite.Margin = new Padding(4);
            txtAddressWrite.Multiline = true;
            txtAddressWrite.Name = "txtAddressWrite";
            txtAddressWrite.ReadOnly = true;
            txtAddressWrite.Size = new Size(469, 87);
            txtAddressWrite.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(365, 648);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 32);
            label8.TabIndex = 26;
            label8.Text = "input.txt";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(847, 648);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 32);
            label9.TabIndex = 27;
            label9.Text = "output.txt";
            // 
            // btnDeBai
            // 
            btnDeBai.BackColor = Color.SteelBlue;
            btnDeBai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeBai.ForeColor = Color.White;
            btnDeBai.Location = new Point(107, 33);
            btnDeBai.Margin = new Padding(4);
            btnDeBai.Name = "btnDeBai";
            btnDeBai.Size = new Size(845, 92);
            btnDeBai.TabIndex = 29;
            btnDeBai.Text = "Bài 4: Đọc và Ghi file sử dụng BinaryFormatter";
            btnDeBai.UseVisualStyleBackColor = false;
            // 
            // Bai_4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1040, 856);
            Controls.Add(btnDeBai);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAddressWrite);
            Controls.Add(txtAddressRead);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(txtRead);
            Controls.Add(txtWrite);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Bai_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4";
            Load += Task4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnStart;
        private Button btnReset;
        private TextBox txtNum;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtID;
        private Label label5;
        private TextBox txtLiterature;
        private Label label7;
        private TextBox txtMath;
        private Panel panel2;
        private TextBox txtWrite;
        private TextBox txtRead;
        private Button btnRead;
        private Button btnWrite;
        private TextBox txtAddressRead;
        private TextBox txtAddressWrite;
        private Label label8;
        private Label label9;
        private Button btnDeBai;
    }
}