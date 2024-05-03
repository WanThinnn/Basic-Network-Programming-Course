
namespace Lab_1
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
            btnback = new Button();
            btntinhtoan = new Button();
            btnxoa = new Button();
            lbtieude = new Label();
            lbnum1 = new Label();
            txbnum1 = new TextBox();
            txbnum2 = new TextBox();
            lbnum2 = new Label();
            txbnum3 = new TextBox();
            lbnum3 = new Label();
            txbmin = new TextBox();
            lbmin = new Label();
            txbmax = new TextBox();
            lbmax = new Label();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = Color.SteelBlue;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(74, 442);
            btnback.Name = "btnback";
            btnback.Size = new Size(200, 51);
            btnback.TabIndex = 6;
            btnback.Text = "Trở về Lab 1";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btntinhtoan
            // 
            btntinhtoan.BackColor = Color.Green;
            btntinhtoan.ForeColor = Color.White;
            btntinhtoan.Location = new Point(289, 442);
            btntinhtoan.Name = "btntinhtoan";
            btntinhtoan.Size = new Size(200, 51);
            btntinhtoan.TabIndex = 4;
            btntinhtoan.Text = "Tìm";
            btntinhtoan.UseVisualStyleBackColor = false;
            btntinhtoan.Click += btntinhtoan_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Firebrick;
            btnxoa.ForeColor = Color.White;
            btnxoa.Location = new Point(504, 442);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(200, 51);
            btnxoa.TabIndex = 5;
            btnxoa.Text = "Xoá";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtieude.Location = new Point(31, 50);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(741, 50);
            lbtieude.TabIndex = 0;
            lbtieude.Text = "BÀI 2: TÌM SỐ LỚN NHẤT, SỐ NHỎ NHẤT";
            lbtieude.Click += lbtieude_Click;
            // 
            // lbnum1
            // 
            lbnum1.AutoSize = true;
            lbnum1.Location = new Point(74, 124);
            lbnum1.Name = "lbnum1";
            lbnum1.Size = new Size(148, 32);
            lbnum1.TabIndex = 0;
            lbnum1.Text = "Số Thứ Nhất";
            // 
            // txbnum1
            // 
            txbnum1.Location = new Point(252, 121);
            txbnum1.Name = "txbnum1";
            txbnum1.Size = new Size(452, 39);
            txbnum1.TabIndex = 1;
            // 
            // txbnum2
            // 
            txbnum2.Location = new Point(252, 177);
            txbnum2.Name = "txbnum2";
            txbnum2.Size = new Size(452, 39);
            txbnum2.TabIndex = 2;
            // 
            // lbnum2
            // 
            lbnum2.AutoSize = true;
            lbnum2.Location = new Point(74, 180);
            lbnum2.Name = "lbnum2";
            lbnum2.Size = new Size(131, 32);
            lbnum2.TabIndex = 0;
            lbnum2.Text = "Số Thứ Hai";
            // 
            // txbnum3
            // 
            txbnum3.Location = new Point(252, 232);
            txbnum3.Name = "txbnum3";
            txbnum3.Size = new Size(452, 39);
            txbnum3.TabIndex = 3;
            // 
            // lbnum3
            // 
            lbnum3.AutoSize = true;
            lbnum3.Location = new Point(74, 235);
            lbnum3.Name = "lbnum3";
            lbnum3.Size = new Size(122, 32);
            lbnum3.TabIndex = 0;
            lbnum3.Text = "Số Thứ Ba";
            // 
            // txbmin
            // 
            txbmin.Location = new Point(252, 303);
            txbmin.Name = "txbmin";
            txbmin.ReadOnly = true;
            txbmin.Size = new Size(452, 39);
            txbmin.TabIndex = 0;
            txbmin.TabStop = false;
            // 
            // lbmin
            // 
            lbmin.AutoSize = true;
            lbmin.Location = new Point(74, 306);
            lbmin.Name = "lbmin";
            lbmin.Size = new Size(153, 32);
            lbmin.TabIndex = 0;
            lbmin.Text = "Số Nhỏ Nhất";
            // 
            // txbmax
            // 
            txbmax.Location = new Point(252, 363);
            txbmax.Name = "txbmax";
            txbmax.ReadOnly = true;
            txbmax.Size = new Size(452, 39);
            txbmax.TabIndex = 0;
            txbmax.TabStop = false;
            // 
            // lbmax
            // 
            lbmax.AutoSize = true;
            lbmax.Location = new Point(74, 366);
            lbmax.Name = "lbmax";
            lbmax.Size = new Size(146, 32);
            lbmax.TabIndex = 0;
            lbmax.Text = "Số Lớn Nhất";
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(txbmax);
            Controls.Add(lbmax);
            Controls.Add(txbmin);
            Controls.Add(lbmin);
            Controls.Add(txbnum3);
            Controls.Add(lbnum3);
            Controls.Add(txbnum2);
            Controls.Add(lbnum2);
            Controls.Add(txbnum1);
            Controls.Add(lbnum1);
            Controls.Add(lbtieude);
            Controls.Add(btnxoa);
            Controls.Add(btntinhtoan);
            Controls.Add(btnback);
            Name = "Bai_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai_2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lbtieude_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnback;
        private Button btntinhtoan;
        private Button btnxoa;
        private Label lbtieude;
        private Label lbnum1;
        private TextBox txbnum1;
        private TextBox txbnum2;
        private Label lbnum2;
        private TextBox txbnum3;
        private Label lbnum3;
        private TextBox txbmin;
        private Label lbmin;
        private TextBox txbmax;
        private Label lbmax;
    }
}