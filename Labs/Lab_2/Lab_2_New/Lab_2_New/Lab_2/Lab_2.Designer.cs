namespace Lab_2
{
    partial class formLab2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai5 = new Button();
            btnBai4 = new Button();
            btnLab2 = new Button();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.BackColor = Color.SteelBlue;
            btnBai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai1.ForeColor = Color.White;
            btnBai1.Location = new Point(64, 206);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(203, 74);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = Color.SteelBlue;
            btnBai2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai2.ForeColor = Color.White;
            btnBai2.Location = new Point(299, 206);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(203, 74);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = false;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = Color.SteelBlue;
            btnBai3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai3.ForeColor = Color.White;
            btnBai3.Location = new Point(526, 206);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(203, 74);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai5
            // 
            btnBai5.BackColor = Color.SteelBlue;
            btnBai5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai5.ForeColor = Color.White;
            btnBai5.Location = new Point(403, 314);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(203, 74);
            btnBai5.TabIndex = 4;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = false;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai4
            // 
            btnBai4.BackColor = Color.SteelBlue;
            btnBai4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai4.ForeColor = Color.White;
            btnBai4.Location = new Point(168, 314);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(203, 74);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = false;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnLab2
            // 
            btnLab2.BackColor = Color.White;
            btnLab2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLab2.ForeColor = Color.SteelBlue;
            btnLab2.Location = new Point(64, 46);
            btnLab2.Name = "btnLab2";
            btnLab2.Size = new Size(665, 111);
            btnLab2.TabIndex = 5;
            btnLab2.Text = "Lab 2: Lập Trình Mạng Căn Bản";
            btnLab2.UseVisualStyleBackColor = false;
            // 
            // formLab2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnLab2);
            Controls.Add(btnBai5);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            MaximizeBox = false;
            Name = "formLab2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 2";
            FormClosing += formLab2_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai5;
        private Button btnBai4;
        private Button btnLab2;
    }
}
