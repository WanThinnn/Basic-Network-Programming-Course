namespace Lab2
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
            listViewFile = new ListView();
            clnName = new ColumnHeader();
            clnSize = new ColumnHeader();
            clnTail = new ColumnHeader();
            clnDate = new ColumnHeader();
            btnOpen = new Button();
            btnClear = new Button();
            btnDeBai = new Button();
            SuspendLayout();
            // 
            // listViewFile
            // 
            listViewFile.Alignment = ListViewAlignment.Default;
            listViewFile.Columns.AddRange(new ColumnHeader[] { clnName, clnSize, clnTail, clnDate });
            listViewFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listViewFile.GridLines = true;
            listViewFile.Location = new Point(37, 202);
            listViewFile.Margin = new Padding(4);
            listViewFile.Name = "listViewFile";
            listViewFile.RightToLeft = RightToLeft.No;
            listViewFile.Size = new Size(1035, 478);
            listViewFile.TabIndex = 0;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = View.Details;
            // 
            // clnName
            // 
            clnName.Text = "Tên file";
            clnName.Width = 300;
            // 
            // clnSize
            // 
            clnSize.Text = "Kích thước (byte)";
            clnSize.Width = 250;
            // 
            // clnTail
            // 
            clnTail.Text = "Đuôi mở rộng";
            clnTail.Width = 250;
            // 
            // clnDate
            // 
            clnDate.Text = "Ngày khởi tạo";
            clnDate.Width = 250;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.SteelBlue;
            btnOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(418, 711);
            btnOpen.Margin = new Padding(4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(146, 53);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(571, 710);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 53);
            btnClear.TabIndex = 13;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeBai
            // 
            btnDeBai.BackColor = Color.SteelBlue;
            btnDeBai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeBai.ForeColor = Color.White;
            btnDeBai.Location = new Point(130, 63);
            btnDeBai.Margin = new Padding(4);
            btnDeBai.Name = "btnDeBai";
            btnDeBai.Size = new Size(845, 92);
            btnDeBai.TabIndex = 30;
            btnDeBai.Text = "Bài 5: Duyệt thư mục";
            btnDeBai.UseVisualStyleBackColor = false;
            // 
            // Bai_5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1110, 818);
            Controls.Add(btnDeBai);
            Controls.Add(btnClear);
            Controls.Add(btnOpen);
            Controls.Add(listViewFile);
            Margin = new Padding(4);
            Name = "Bai_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task5";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewFile;
        private ColumnHeader clnName;
        private ColumnHeader clnSize;
        private ColumnHeader clnTail;
        private ColumnHeader clnDate;
        private Button btnOpen;
        private Button btnClear;
        private Button btnDeBai;
    }
}