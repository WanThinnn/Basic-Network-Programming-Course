namespace Lab_1
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
            lbnum = new Label();
            txbnum = new TextBox();
            lbchoose = new Label();
            cbboxFrom = new ComboBox();
            cbboxTo = new ComboBox();
            lbTo = new Label();
            btnchuyendoi = new Button();
            lbres = new Label();
            txbres = new TextBox();
            btnclear = new Button();
            btnback = new Button();
            lbtieude = new Label();
            SuspendLayout();
            // 
            // lbnum
            // 
            lbnum.AutoSize = true;
            lbnum.Location = new Point(58, 143);
            lbnum.Name = "lbnum";
            lbnum.Size = new Size(153, 32);
            lbnum.TabIndex = 0;
            lbnum.Text = "Nhập một số";
            // 
            // txbnum
            // 
            txbnum.Location = new Point(253, 136);
            txbnum.Name = "txbnum";
            txbnum.Size = new Size(471, 39);
            txbnum.TabIndex = 1;
            // 
            // lbchoose
            // 
            lbchoose.AutoSize = true;
            lbchoose.Location = new Point(129, 219);
            lbchoose.Name = "lbchoose";
            lbchoose.Size = new Size(71, 32);
            lbchoose.TabIndex = 2;
            lbchoose.Text = "Chọn";
            // 
            // cbboxFrom
            // 
            cbboxFrom.AccessibleDescription = "";
            cbboxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbboxFrom.FlatStyle = FlatStyle.Popup;
            cbboxFrom.FormattingEnabled = true;
            cbboxFrom.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal", "Chọn" });
            cbboxFrom.Location = new Point(253, 216);
            cbboxFrom.Name = "cbboxFrom";
            cbboxFrom.Size = new Size(184, 40);
            cbboxFrom.TabIndex = 2;
            cbboxFrom.SelectedIndexChanged += cbboxFrom_SelectedIndexChanged;
            // 
            // cbboxTo
            // 
            cbboxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbboxTo.FlatStyle = FlatStyle.Popup;
            cbboxTo.FormattingEnabled = true;
            cbboxTo.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal", "Chọn" });
            cbboxTo.Location = new Point(540, 216);
            cbboxTo.Name = "cbboxTo";
            cbboxTo.Size = new Size(184, 40);
            cbboxTo.TabIndex = 3;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(456, 219);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(64, 32);
            lbTo.TabIndex = 6;
            lbTo.Text = "sang";
            // 
            // btnchuyendoi
            // 
            btnchuyendoi.BackColor = Color.Green;
            btnchuyendoi.ForeColor = Color.White;
            btnchuyendoi.Location = new Point(300, 401);
            btnchuyendoi.Name = "btnchuyendoi";
            btnchuyendoi.Size = new Size(197, 46);
            btnchuyendoi.TabIndex = 4;
            btnchuyendoi.Text = "Thực Hiện";
            btnchuyendoi.UseVisualStyleBackColor = false;
            btnchuyendoi.Click += btnchuyendoi_Click;
            // 
            // lbres
            // 
            lbres.AutoSize = true;
            lbres.Location = new Point(104, 309);
            lbres.Name = "lbres";
            lbres.Size = new Size(96, 32);
            lbres.TabIndex = 8;
            lbres.Text = "Kết quả";
            // 
            // txbres
            // 
            txbres.Location = new Point(253, 302);
            txbres.Name = "txbres";
            txbres.ReadOnly = true;
            txbres.Size = new Size(476, 39);
            txbres.TabIndex = 9;
            txbres.TabStop = false;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Firebrick;
            btnclear.ForeColor = Color.White;
            btnclear.Location = new Point(527, 401);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(197, 46);
            btnclear.TabIndex = 5;
            btnclear.Text = "Xoá";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.SteelBlue;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(83, 401);
            btnback.Name = "btnback";
            btnback.Size = new Size(197, 46);
            btnback.TabIndex = 6;
            btnback.Text = "Trở về Lab 1";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtieude.Location = new Point(227, 43);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(381, 50);
            lbtieude.TabIndex = 12;
            lbtieude.Text = "BÀI 4: ĐỔI HỆ CƠ SỐ";
            // 
            // Bai_4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(lbtieude);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(txbres);
            Controls.Add(lbres);
            Controls.Add(btnchuyendoi);
            Controls.Add(lbTo);
            Controls.Add(cbboxTo);
            Controls.Add(cbboxFrom);
            Controls.Add(lbchoose);
            Controls.Add(txbnum);
            Controls.Add(lbnum);
            Name = "Bai_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnum;
        private TextBox txbnum;
        private Label lbchoose;
        private ComboBox cbboxFrom;
        private ComboBox cbboxTo;
        private Label lbTo;
        private Button btnchuyendoi;
        private Label lbres;
        private TextBox txbres;
        private Button btnclear;
        private Button btnback;
        private Label lbtieude;
    }
}