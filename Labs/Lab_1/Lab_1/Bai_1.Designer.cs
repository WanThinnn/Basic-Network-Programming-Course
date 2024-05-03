namespace Lab_1
{
    partial class Bai_1
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
            btn_tinhtoan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            btn_clr = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_tinhtoan
            // 
            btn_tinhtoan.BackColor = Color.Green;
            btn_tinhtoan.ForeColor = Color.WhiteSmoke;
            btn_tinhtoan.Location = new Point(297, 359);
            btn_tinhtoan.Name = "btn_tinhtoan";
            btn_tinhtoan.Size = new Size(193, 46);
            btn_tinhtoan.TabIndex = 3;
            btn_tinhtoan.Text = "Tính";
            btn_tinhtoan.UseVisualStyleBackColor = false;
            btn_tinhtoan.Click += button1_Click_Tinhtong;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 162);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 1;
            label1.Text = "Số Thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 219);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 2;
            label2.Text = "Số Thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 286);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 3;
            label3.Text = "Kết Quả";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 39);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 283);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(367, 39);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 60);
            label4.Name = "label4";
            label4.Size = new Size(594, 50);
            label4.TabIndex = 7;
            label4.Text = "BÀI 1: TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // btn_clr
            // 
            btn_clr.BackColor = Color.Firebrick;
            btn_clr.ForeColor = Color.White;
            btn_clr.Location = new Point(519, 359);
            btn_clr.Name = "btn_clr";
            btn_clr.Size = new Size(196, 46);
            btn_clr.TabIndex = 4;
            btn_clr.Text = "Xoá";
            btn_clr.UseVisualStyleBackColor = false;
            btn_clr.Click += button2_Click_Xoa;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SteelBlue;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(83, 359);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(184, 45);
            btn_back.TabIndex = 5;
            btn_back.Text = "Trở Về Lab 1";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += button4_Click_Trove;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 487);
            Controls.Add(btn_back);
            Controls.Add(btn_clr);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_tinhtoan);
            Name = "Bai_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1";
            Load += Bai_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_tinhtoan;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Button btn_clr;
        private Button btn_back;
    }
}