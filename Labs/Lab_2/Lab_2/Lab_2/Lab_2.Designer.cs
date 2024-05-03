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
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.BackColor = Color.SteelBlue;
            btnBai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai1.ForeColor = Color.White;
            btnBai1.Location = new Point(64, 210);
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
            btnBai2.Location = new Point(299, 210);
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
            btnBai3.Location = new Point(526, 210);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(203, 74);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            btnBai3.Click += btnBai3_Click;
            // 
            // formLab2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
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
    }
}
