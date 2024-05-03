namespace Lab_2
{
    partial class Bai_3
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
            btnClear = new Button();
            richTextBox1 = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            btnDeBai = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(59, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(274, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(618, 527);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.SteelBlue;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = Color.White;
            btnWrite.Location = new Point(59, 249);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(150, 46);
            btnWrite.TabIndex = 5;
            btnWrite.Text = "Ghi File";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.SteelBlue;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(59, 183);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 46);
            btnRead.TabIndex = 4;
            btnRead.Text = "Đọc File";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnDeBai
            // 
            btnDeBai.BackColor = Color.SteelBlue;
            btnDeBai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeBai.ForeColor = Color.White;
            btnDeBai.Location = new Point(55, 38);
            btnDeBai.Margin = new Padding(4);
            btnDeBai.Name = "btnDeBai";
            btnDeBai.Size = new Size(837, 94);
            btnDeBai.TabIndex = 31;
            btnDeBai.Text = "Bài 3: Đọc và Ghi file (Mở rộng)";
            btnDeBai.UseVisualStyleBackColor = false;
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 745);
            Controls.Add(btnDeBai);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Bai_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai_3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private RichTextBox richTextBox1;
        private Button btnWrite;
        private Button btnRead;
        private Button btnDeBai;
    }
}