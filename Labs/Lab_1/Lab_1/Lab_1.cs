using System.Diagnostics;

namespace Lab_1
{
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            Bai_1 b1 = new Bai_1();

            this.Hide();
            b1.ShowDialog();
            this.Show();
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            Bai_2 b2 = new Bai_2();

            this.Hide();
            b2.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_b3_Click(object sender, EventArgs e)
        {
            Bai_3_2 b3 = new Bai_3_2();

            this.Hide();
            b3.ShowDialog();
            this.Show();
        }

        private void btn_b4_Click(object sender, EventArgs e)
        {
            Bai_4 b4 = new Bai_4();

            this.Hide();
            b4.ShowDialog();
            this.Show();
        }

        private void btn_b5_Click(object sender, EventArgs e)
        {
            Bai_5 b5 = new Bai_5();

            this.Hide();
            b5.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
