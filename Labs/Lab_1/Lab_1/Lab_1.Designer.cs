namespace Lab_1
{
    partial class Lab_1
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
            btn_b1 = new Button();
            btn_b2 = new Button();
            btn_b3 = new Button();
            btn_b4 = new Button();
            btn_exit = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_lab1 = new Button();
            btn_b5 = new Button();
            SuspendLayout();
            // 
            // btn_b1
            // 
            btn_b1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_b1.ForeColor = Color.SteelBlue;
            btn_b1.Location = new Point(71, 172);
            btn_b1.Name = "btn_b1";
            btn_b1.Size = new Size(152, 92);
            btn_b1.TabIndex = 1;
            btn_b1.Text = "Bài 1";
            btn_b1.UseVisualStyleBackColor = true;
            btn_b1.Click += btn_b1_Click;
            // 
            // btn_b2
            // 
            btn_b2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_b2.ForeColor = Color.SteelBlue;
            btn_b2.Location = new Point(280, 172);
            btn_b2.Name = "btn_b2";
            btn_b2.Size = new Size(152, 92);
            btn_b2.TabIndex = 2;
            btn_b2.Text = "Bài 2";
            btn_b2.UseVisualStyleBackColor = true;
            btn_b2.Click += btn_b2_Click;
            // 
            // btn_b3
            // 
            btn_b3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_b3.ForeColor = Color.SteelBlue;
            btn_b3.Location = new Point(489, 172);
            btn_b3.Name = "btn_b3";
            btn_b3.Size = new Size(152, 92);
            btn_b3.TabIndex = 3;
            btn_b3.Text = "Bài 3";
            btn_b3.UseVisualStyleBackColor = true;
            btn_b3.Click += btn_b3_Click;
            // 
            // btn_b4
            // 
            btn_b4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_b4.ForeColor = Color.SteelBlue;
            btn_b4.Location = new Point(71, 300);
            btn_b4.Name = "btn_b4";
            btn_b4.Size = new Size(152, 92);
            btn_b4.TabIndex = 4;
            btn_b4.Text = "Bài 4";
            btn_b4.UseVisualStyleBackColor = true;
            btn_b4.Click += btn_b4_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Tomato;
            btn_exit.Location = new Point(489, 300);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(142, 92);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 50);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 97);
            label2.Name = "label2";
            label2.Size = new Size(0, 50);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // btn_lab1
            // 
            btn_lab1.BackColor = SystemColors.GradientActiveCaption;
            btn_lab1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lab1.Location = new Point(61, 37);
            btn_lab1.Name = "btn_lab1";
            btn_lab1.Size = new Size(570, 92);
            btn_lab1.TabIndex = 7;
            btn_lab1.TabStop = false;
            btn_lab1.Text = "Lập Trình Mạng Căn Bản";
            btn_lab1.UseVisualStyleBackColor = false;
            // 
            // btn_b5
            // 
            btn_b5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_b5.ForeColor = Color.SteelBlue;
            btn_b5.Location = new Point(280, 300);
            btn_b5.Name = "btn_b5";
            btn_b5.Size = new Size(152, 92);
            btn_b5.TabIndex = 5;
            btn_b5.Text = "Bài 5";
            btn_b5.UseVisualStyleBackColor = true;
            btn_b5.Click += btn_b5_Click;
            // 
            // Lab_1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new Size(697, 486);
            Controls.Add(btn_b5);
            Controls.Add(btn_lab1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(btn_b4);
            Controls.Add(btn_b3);
            Controls.Add(btn_b2);
            Controls.Add(btn_b1);
            MaximizeBox = false;
            Name = "Lab_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 1";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_b1;
        private Button btn_b2;
        private Button btn_b3;
        private Button btn_b4;
        private Button btn_exit;
        private Label label1;
        private Label label2;
        private Button btn_lab1;
        private Button btn_b5;
    }
}
