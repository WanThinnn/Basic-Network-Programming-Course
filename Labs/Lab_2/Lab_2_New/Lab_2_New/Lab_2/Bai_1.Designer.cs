namespace Lab_2
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
            btnRead = new Button();
            btnWrite = new Button();
            richTextBox1 = new RichTextBox();
            btnClear = new Button();
            btnDeBai = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.SteelBlue;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(55, 171);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 46);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc File";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.SteelBlue;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = Color.White;
            btnWrite.Location = new Point(55, 237);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(150, 46);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Ghi File";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(274, 171);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(618, 527);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(55, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeBai
            // 
            btnDeBai.BackColor = Color.SteelBlue;
            btnDeBai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeBai.ForeColor = Color.White;
            btnDeBai.Location = new Point(55, 37);
            btnDeBai.Margin = new Padding(4);
            btnDeBai.Name = "btnDeBai";
            btnDeBai.Size = new Size(837, 101);
            btnDeBai.TabIndex = 30;
            btnDeBai.Text = "Bài 1: Đọc và Ghi file";
            btnDeBai.UseVisualStyleBackColor = false;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 745);
            Controls.Add(btnDeBai);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            MaximizeBox = false;
            Name = "Bai_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox richTextBox1;
        private Button btnClear;
        private Button btnDeBai;
    }
}