namespace Lab_2
{
    public partial class formLab2 : Form
    {
        public formLab2()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai_1 b1 = new Bai_1();
            this.Hide();
            b1.ShowDialog();
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai_2 b2 = new Bai_2();
            this.Hide();
            b2.ShowDialog();
            this.Show();
        }


        private void formLab2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai_3 b3 = new Bai_3();
            this.Hide();
            b3.ShowDialog();
            this.Show();
        }
    }
}
