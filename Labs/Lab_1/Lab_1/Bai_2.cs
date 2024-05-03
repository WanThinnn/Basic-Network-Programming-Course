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
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void CalculateMinMax()
        {

                if (IsValidInput())
                {
                    // Lấy giá trị từ các ô nhập và kiểm tra tính hợp lệ của chuỗi đầu vào
                    string input1 = txbnum1.Text.Replace(',', '.');
                    string input2 = txbnum2.Text.Replace(',', '.');
                    string input3 = txbnum3.Text.Replace(',', '.');

                    // Kiểm tra xem các chuỗi đầu vào có thể chuyển đổi thành số kiểu double không
                    if (double.TryParse(input1, out double number1) &&
                        double.TryParse(input2, out double number2) &&
                        double.TryParse(input3, out double number3))
                    {
                        // Tìm số lớn nhất và số nhỏ nhất
                        double min = Math.Min(Math.Min(number1, number2), number3);
                        double max = Math.Max(Math.Max(number1, number2), number3);

                        // Hiển thị kết quả
                        txbmin.Text = min.ToString();
                        txbmax.Text = max.ToString();
                    }
                    else 
                    MessageBox.Show("Vui lòng nhập vào ba số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vào ba số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }


        private void btntinhtoan_Click(object sender, EventArgs e)
        {
            CalculateMinMax();
        }

        private bool IsValidInput()
        {

                // Kiểm tra xem các ô nhập có chứa dữ liệu hợp lệ không
                return double.TryParse(txbnum1.Text, out _) &&
                       double.TryParse(txbnum2.Text, out _) &&
                       double.TryParse(txbnum3.Text, out _);
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            txbnum1.Clear();
            txbnum2.Clear();
            txbnum3.Clear();
            txbmin.Clear();
            txbmax.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
