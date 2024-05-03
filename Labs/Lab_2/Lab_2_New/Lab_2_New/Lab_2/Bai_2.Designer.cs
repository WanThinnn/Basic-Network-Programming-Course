namespace Lab_2
{
    partial class Bai_2
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
            btnDocFile = new Button();
            lbTenFile = new Label();
            lbURL = new Label();
            lbSoDong = new Label();
            lbSoTu = new Label();
            lbSoKyTu = new Label();
            txbTenFile = new TextBox();
            txbURL = new TextBox();
            txbSoDong = new TextBox();
            txbSoTu = new TextBox();
            txbSoKyTu = new TextBox();
            richTextBox1 = new RichTextBox();
            btnClear = new Button();
            btnDeBai = new Button();
            SuspendLayout();
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.SteelBlue;
            btnDocFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocFile.ForeColor = Color.White;
            btnDocFile.Location = new Point(30, 709);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(265, 53);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // lbTenFile
            // 
            lbTenFile.AutoSize = true;
            lbTenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenFile.Location = new Point(30, 230);
            lbTenFile.Name = "lbTenFile";
            lbTenFile.Size = new Size(97, 32);
            lbTenFile.TabIndex = 1;
            lbTenFile.Text = "Tên file";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbURL.Location = new Point(30, 323);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(59, 32);
            lbURL.TabIndex = 2;
            lbURL.Text = "URL";
            // 
            // lbSoDong
            // 
            lbSoDong.AutoSize = true;
            lbSoDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoDong.Location = new Point(29, 409);
            lbSoDong.Name = "lbSoDong";
            lbSoDong.Size = new Size(109, 32);
            lbSoDong.TabIndex = 4;
            lbSoDong.Text = "Số dòng";
            // 
            // lbSoTu
            // 
            lbSoTu.AutoSize = true;
            lbSoTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoTu.Location = new Point(29, 493);
            lbSoTu.Name = "lbSoTu";
            lbSoTu.Size = new Size(74, 32);
            lbSoTu.TabIndex = 3;
            lbSoTu.Text = "Số từ";
            // 
            // lbSoKyTu
            // 
            lbSoKyTu.AutoSize = true;
            lbSoKyTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoKyTu.Location = new Point(30, 586);
            lbSoKyTu.Name = "lbSoKyTu";
            lbSoKyTu.Size = new Size(107, 32);
            lbSoKyTu.TabIndex = 5;
            lbSoKyTu.Text = "Số ký tự";
            // 
            // txbTenFile
            // 
            txbTenFile.Location = new Point(174, 223);
            txbTenFile.Name = "txbTenFile";
            txbTenFile.ReadOnly = true;
            txbTenFile.Size = new Size(402, 39);
            txbTenFile.TabIndex = 6;
            // 
            // txbURL
            // 
            txbURL.Location = new Point(174, 320);
            txbURL.Name = "txbURL";
            txbURL.ReadOnly = true;
            txbURL.Size = new Size(402, 39);
            txbURL.TabIndex = 7;
            // 
            // txbSoDong
            // 
            txbSoDong.Location = new Point(173, 406);
            txbSoDong.Name = "txbSoDong";
            txbSoDong.ReadOnly = true;
            txbSoDong.Size = new Size(403, 39);
            txbSoDong.TabIndex = 8;
            // 
            // txbSoTu
            // 
            txbSoTu.Location = new Point(173, 490);
            txbSoTu.Name = "txbSoTu";
            txbSoTu.ReadOnly = true;
            txbSoTu.Size = new Size(403, 39);
            txbSoTu.TabIndex = 9;
            // 
            // txbSoKyTu
            // 
            txbSoKyTu.Location = new Point(174, 586);
            txbSoKyTu.Name = "txbSoKyTu";
            txbSoKyTu.ReadOnly = true;
            txbSoKyTu.Size = new Size(402, 39);
            txbSoKyTu.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(640, 169);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(690, 593);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(313, 709);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(264, 53);
            btnClear.TabIndex = 12;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeBai
            // 
            btnDeBai.BackColor = Color.SteelBlue;
            btnDeBai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeBai.ForeColor = Color.White;
            btnDeBai.Location = new Point(283, 39);
            btnDeBai.Margin = new Padding(4);
            btnDeBai.Name = "btnDeBai";
            btnDeBai.Size = new Size(837, 94);
            btnDeBai.TabIndex = 31;
            btnDeBai.Text = "Bài 2: Đọc thông tin một file *.txt";
            btnDeBai.UseVisualStyleBackColor = false;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 842);
            Controls.Add(btnDeBai);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
            Controls.Add(txbSoKyTu);
            Controls.Add(txbSoTu);
            Controls.Add(txbSoDong);
            Controls.Add(txbURL);
            Controls.Add(txbTenFile);
            Controls.Add(lbSoKyTu);
            Controls.Add(lbSoDong);
            Controls.Add(lbSoTu);
            Controls.Add(lbURL);
            Controls.Add(lbTenFile);
            Controls.Add(btnDocFile);
            MaximizeBox = false;
            Name = "Bai_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDocFile;
        private Label lbTenFile;
        private Label lbURL;
        private Label lbSoDong;
        private Label lbSoTu;
        private Label lbSoKyTu;
        private TextBox txbTenFile;
        private TextBox txbURL;
        private TextBox txbSoDong;
        private TextBox txbSoTu;
        private TextBox txbSoKyTu;
        private RichTextBox richTextBox1;
        private Button btnClear;
        private Button btnDeBai;
    }
}