namespace Lab_1
{
    partial class Bai_5
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
            lbtieude = new Label();
            lbDiem = new Label();
            txbDiem = new TextBox();
            btnXuat = new Button();
            lbXuat = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnClear = new Button();
            btnBack = new Button();
            lbDtb = new Label();
            lbHocluc = new Label();
            lbMax = new Label();
            lbMin = new Label();
            lbPass = new Label();
            lbNotpass = new Label();
            lbDanhgia = new Label();
            panel1 = new Panel();
            btnNotPass = new Button();
            btnPass = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnHocluc = new Button();
            btnDtb = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtieude.Location = new Point(235, 29);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(594, 50);
            lbtieude.TabIndex = 13;
            lbtieude.Text = "BÀI 5: QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // lbDiem
            // 
            lbDiem.AutoSize = true;
            lbDiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiem.Location = new Point(128, 137);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(219, 96);
            lbDiem.TabIndex = 14;
            lbDiem.Text = "Danh sách điểm \r\n(cách nhau ít nhất \r\n1 khoảng trắng)";
            // 
            // txbDiem
            // 
            txbDiem.Location = new Point(353, 137);
            txbDiem.Multiline = true;
            txbDiem.Name = "txbDiem";
            txbDiem.Size = new Size(527, 96);
            txbDiem.TabIndex = 15;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Green;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(730, 260);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // lbXuat
            // 
            lbXuat.AutoSize = true;
            lbXuat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbXuat.Location = new Point(241, 380);
            lbXuat.Name = "lbXuat";
            lbXuat.Size = new Size(99, 32);
            lbXuat.TabIndex = 18;
            lbXuat.Text = "Kết quả";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.Location = new Point(52, 422);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(482, 475);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Firebrick;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(574, 260);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 19;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(373, 260);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(195, 46);
            btnBack.TabIndex = 20;
            btnBack.Text = "Trở về Lab 1";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // lbDtb
            // 
            lbDtb.AutoSize = true;
            lbDtb.Location = new Point(8, 23);
            lbDtb.Name = "lbDtb";
            lbDtb.Size = new Size(196, 32);
            lbDtb.TabIndex = 21;
            lbDtb.Text = "Điểm trung bình:";
            // 
            // lbHocluc
            // 
            lbHocluc.AutoSize = true;
            lbHocluc.Location = new Point(8, 102);
            lbHocluc.Name = "lbHocluc";
            lbHocluc.Size = new Size(189, 32);
            lbHocluc.TabIndex = 22;
            lbHocluc.Text = "Xếp loại học lực:";
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.Location = new Point(8, 192);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(229, 32);
            lbMax.TabIndex = 23;
            lbMax.Text = "Môn cao điểm nhất:";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Location = new Point(8, 279);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(240, 32);
            lbMin.TabIndex = 24;
            lbMin.Text = "Môn thấp điểm nhất:";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(8, 351);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(149, 32);
            lbPass.TabIndex = 25;
            lbPass.Text = "Số môn đậu:";
            // 
            // lbNotpass
            // 
            lbNotpass.AutoSize = true;
            lbNotpass.Location = new Point(8, 422);
            lbNotpass.Name = "lbNotpass";
            lbNotpass.Size = new Size(224, 32);
            lbNotpass.TabIndex = 26;
            lbNotpass.Text = "Số môn không đậu:";
            // 
            // lbDanhgia
            // 
            lbDanhgia.AutoSize = true;
            lbDanhgia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDanhgia.Location = new Point(717, 380);
            lbDanhgia.Name = "lbDanhgia";
            lbDanhgia.Size = new Size(112, 32);
            lbDanhgia.TabIndex = 27;
            lbDanhgia.Text = "Đánh giá";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnNotPass);
            panel1.Controls.Add(btnPass);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnHocluc);
            panel1.Controls.Add(btnDtb);
            panel1.Controls.Add(lbDtb);
            panel1.Controls.Add(lbHocluc);
            panel1.Controls.Add(lbNotpass);
            panel1.Controls.Add(lbMax);
            panel1.Controls.Add(lbPass);
            panel1.Controls.Add(lbMin);
            panel1.Location = new Point(566, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 475);
            panel1.TabIndex = 28;
            // 
            // btnNotPass
            // 
            btnNotPass.Location = new Point(254, 418);
            btnNotPass.Name = "btnNotPass";
            btnNotPass.Size = new Size(150, 41);
            btnNotPass.TabIndex = 32;
            btnNotPass.UseVisualStyleBackColor = true;
            // 
            // btnPass
            // 
            btnPass.Location = new Point(254, 347);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(150, 41);
            btnPass.TabIndex = 31;
            btnPass.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(254, 270);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(150, 41);
            btnMin.TabIndex = 30;
            btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(254, 183);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(150, 41);
            btnMax.TabIndex = 29;
            btnMax.UseVisualStyleBackColor = true;
            // 
            // btnHocluc
            // 
            btnHocluc.Location = new Point(254, 102);
            btnHocluc.Name = "btnHocluc";
            btnHocluc.Size = new Size(150, 41);
            btnHocluc.TabIndex = 28;
            btnHocluc.UseVisualStyleBackColor = true;
            // 
            // btnDtb
            // 
            btnDtb.Location = new Point(254, 19);
            btnDtb.Name = "btnDtb";
            btnDtb.Size = new Size(150, 41);
            btnDtb.TabIndex = 27;
            btnDtb.UseVisualStyleBackColor = true;
            // 
            // Bai_5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 958);
            Controls.Add(panel1);
            Controls.Add(lbDanhgia);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(lbXuat);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnXuat);
            Controls.Add(txbDiem);
            Controls.Add(lbDiem);
            Controls.Add(lbtieude);
            Name = "Bai_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtieude;
        private Label lbDiem;
        private TextBox txbDiem;
        private Button btnXuat;
        private Label lbXuat;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnClear;
        private Button btnBack;
        private Label lbDtb;
        private Label lbHocluc;
        private Label lbMax;
        private Label lbMin;
        private Label lbPass;
        private Label lbNotpass;
        private Label lbDanhgia;
        private Panel panel1;
        private Button btnNotPass;
        private Button btnPass;
        private Button btnMin;
        private Button btnMax;
        private Button btnHocluc;
        private Button btnDtb;
    }
}