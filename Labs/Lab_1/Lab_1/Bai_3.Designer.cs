namespace Lab_1
{
    partial class Bai_3_2
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
            btnback = new Button();
            btnread = new Button();
            btnclr = new Button();
            txbnum = new TextBox();
            txbres = new TextBox();
            lbnum = new Label();
            lbres = new Label();
            SuspendLayout();
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtieude.Location = new Point(260, 36);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(272, 50);
            lbtieude.TabIndex = 1;
            lbtieude.Text = "BÀI 3: ĐỌC SỐ";
            // 
            // btnback
            // 
            btnback.BackColor = Color.SteelBlue;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(61, 323);
            btnback.Name = "btnback";
            btnback.Size = new Size(194, 60);
            btnback.TabIndex = 4;
            btnback.Text = "Trở về Lab 1";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnread
            // 
            btnread.BackColor = Color.Green;
            btnread.ForeColor = Color.White;
            btnread.Location = new Point(289, 323);
            btnread.Name = "btnread";
            btnread.Size = new Size(194, 60);
            btnread.TabIndex = 2;
            btnread.Text = "Đọc";
            btnread.UseVisualStyleBackColor = false;
            btnread.Click += btnread_Click;
            // 
            // btnclr
            // 
            btnclr.BackColor = Color.Firebrick;
            btnclr.ForeColor = Color.White;
            btnclr.Location = new Point(520, 323);
            btnclr.Name = "btnclr";
            btnclr.Size = new Size(194, 60);
            btnclr.TabIndex = 3;
            btnclr.Text = "Xoá";
            btnclr.UseVisualStyleBackColor = false;
            btnclr.Click += btnclr_Click;
            // 
            // txbnum
            // 
            txbnum.Location = new Point(275, 116);
            txbnum.Name = "txbnum";
            txbnum.Size = new Size(439, 39);
            txbnum.TabIndex = 1;
            // 
            // txbres
            // 
            txbres.Location = new Point(223, 201);
            txbres.Multiline = true;
            txbres.Name = "txbres";
            txbres.ReadOnly = true;
            txbres.Size = new Size(491, 74);
            txbres.TabIndex = 7;
            txbres.TabStop = false;
            // 
            // lbnum
            // 
            lbnum.AutoSize = true;
            lbnum.Location = new Point(68, 116);
            lbnum.Name = "lbnum";
            lbnum.Size = new Size(201, 32);
            lbnum.TabIndex = 5;
            lbnum.Text = "Nhập số [0; 9999]";
            // 
            // lbres
            // 
            lbres.AutoSize = true;
            lbres.Location = new Point(68, 204);
            lbres.Name = "lbres";
            lbres.Size = new Size(96, 32);
            lbres.TabIndex = 8;
            lbres.Text = "Kết quả";
            // 
            // Bai_3_2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbres);
            Controls.Add(txbres);
            Controls.Add(txbnum);
            Controls.Add(lbnum);
            Controls.Add(btnclr);
            Controls.Add(btnread);
            Controls.Add(btnback);
            Controls.Add(lbtieude);
            Name = "Bai_3_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtieude;
        private Button btnback;
        private Button btnread;
        private Button btnclr;
        private TextBox txbnum;
        private TextBox txbres;
        private Label lbnum;
        private Label lbres;
    }
}