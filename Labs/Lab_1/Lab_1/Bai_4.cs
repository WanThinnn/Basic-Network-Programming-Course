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
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
            cbboxFrom.SelectedItem = "Chọn";
            cbboxTo.SelectedItem = "Chọn";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txbnum.Clear();
            txbres.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        // Chuyển từ 10 -> 2
        private string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        // Chuyển từ 2 -> 10
        private int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        // Chuyển từ 10 -> 16
        private string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }

        // Chuyển từ 16 -> 10
        private int HexadecimalToDecimal(string hexadecimalNumber)
        {
            return Convert.ToInt32(hexadecimalNumber, 16);
        }

        // Chuyển từ 2 -> 16
        private string BinaryToHexadecimal(string binaryNumber)
        {
            int decimalNumber = BinaryToDecimal(binaryNumber);
            return DecimalToHexadecimal(decimalNumber);
        }

        // Chuyển từ 16 -> 2
        private string HexadecimalToBinary(string hexadecimalNumber)
        {
            int decimalNumber = HexadecimalToDecimal(hexadecimalNumber);
            return DecimalToBinary(decimalNumber);
        }
        private bool IsValidInput(string input, string selectedBase, string selectedTo)
        {
            // Kiểm tra xem input có rỗng hay không
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Kiểm tra xem input có chứa các kí tự không hợp lệ đối với hệ cơ số đang chọn hay không
            string validChars = "";
            if (selectedBase == "decimal")
            {
                validChars = "0123456789";
            }
            else if (selectedBase == "binary")
            {
                validChars = "01";
            }
            else if (selectedBase == "hexadecimal")
            {
                validChars = "0123456789ABCDEFabcdef";
            }
            
            if (selectedBase == "chọn")
            {
                return false;
            }
            if (selectedTo == "chọn")
            {
                return false;
            }
            if (selectedBase == "")
            {
                return false;
            }
            if (selectedTo == "")
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!validChars.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }



        private void btnchuyendoi_Click(object sender, EventArgs e)
        {

            string input = txbnum.Text;
            string to, from;

            from = cbboxFrom.SelectedItem.ToString().ToLower();
            to = cbboxTo.SelectedItem.ToString().ToLower();

            if (!IsValidInput(input, from, to))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (from == "decimal" && to == "binary")
            {
                int decimalNumber = int.Parse(input);
                txbres.Text = DecimalToBinary(decimalNumber);
            }
            else if (from == "decimal" && to == "hexadecimal")
            {
                int decimalNumber = int.Parse(input);
                txbres.Text = DecimalToHexadecimal(decimalNumber);
            }
            else if (from == "decimal" && to == "decimal")
            {
                txbres.Text = input;
            }
            else if (from == "binary" && to == "decimal")
            {
                txbres.Text = BinaryToDecimal(input).ToString();
            }
            else if (from == "binary" && to == "hexadecimal")
            {
                txbres.Text = BinaryToHexadecimal(input);
            }
            else if (from == "binary" && to == "binary")
            {
                txbres.Text = input;
            }
            else if (from == "hexadecimal" && to == "decimal")
            {
                txbres.Text = HexadecimalToDecimal(input).ToString();
            }
            else if (from == "hexadecimal" && to == "binary")
            {
                txbres.Text = HexadecimalToBinary(input);
            }
            else if (from == "hexadecimal" && to == "hexadecimal")
            {
                txbres.Text = input;
            }

        }

        private void cbboxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
