using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Bai_1 : Form
    {
        private bool IsValidData()
        {
            int number1, number2;

            if (!int.TryParse(textBox1.Text, out number1) || !int.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Vui lòng nhập vào hai số nguyên hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Bai_1()
        {
            InitializeComponent();
        }

        private void Bai_1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_Tinhtong(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);

                int sum = number1 + number2;

                textBox3.Text = sum.ToString();
            }
        }

        private void button2_Click_Xoa(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click_Trove(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
