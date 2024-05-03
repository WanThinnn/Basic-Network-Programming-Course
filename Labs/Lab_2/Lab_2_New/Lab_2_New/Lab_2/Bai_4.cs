using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Task4_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtID.Enabled = false;
            txtMath.Enabled = false;
            txtLiterature.Enabled = false;
            txtWrite.Enabled = false;
            txtRead.Enabled = false;
            btnRead.Enabled = false;
            btnWrite.Enabled = false;
        }
        private bool IsValid()
        {
            return float.TryParse(txtMath.Text, out _)
                && float.TryParse(txtLiterature.Text, out _)
                && int.TryParse(txtPhone.Text, out _)
                && int.TryParse(txtNum.Text, out _)
                && int.TryParse(txtID.Text, out _)
                && txtPhone.Text != ""
                && txtName.Text != ""
                && txtID.Text != "";
        }

        private void ClearAll()
        {
            txtMath.Text = "";
            txtLiterature.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            txtID.Text = "";

        }


        private void txtMath_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsAllFieldsFilled()
        {
            // Kiểm tra từng ô nhập liệu để xem có ô nào trống không
            if (string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtLiterature.Text) ||
                string.IsNullOrEmpty(txtMath.Text))
            {
                return false; // Trả về false nếu có ô nào đó trống
            }
            return true; // Trả về true nếu tất cả các ô nhập liệu đều đã được điền
        }
        //private void btnWrite_Click(object sender, EventArgs e)
        //{
        //    FileStream fsw = new FileStream("..\\input.txt", FileMode.OpenOrCreate);

        //    string phoneNumber = txtPhone.Text;
        //    // Kiểm tra xem tất cả các ô nhập liệu đã được điền đầy đủ hay chưa
        //    if (!IsAllFieldsFilled())
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    // Kiểm tra độ dài của chuỗi
        //    if (phoneNumber.Length != 10)
        //    {
        //        MessageBox.Show("Số điện thoại phải có 10 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (IsValid())
        //    {
        //        string[] content = {txtName.Text, txtPhone.Text, txtID.Text, txtLiterature.Text, txtMath.Text, "\r\n" };


        //        txtAddressWrite.Text = fsw.Name;
        //        fsw.Close();

        //        File.AppendAllLines(fsw.Name, content);

        //        FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
        //        StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
        //        txtWrite.Text = sr.ReadToEnd();
        //        sr.Close();
        //        fsr.Close();

        //        txtNum.Text = (int.Parse(txtNum.Text) - 1).ToString();
        //        ClearAll();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Sai định dạng, vui lòng nhập lại!", "Thông báo",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (txtNum.Text == "0")
        //    {
        //        btnStart.Enabled = true;
        //        txtNum.Enabled = true;
        //        txtID.Enabled = false;
        //        txtName.Enabled = false;
        //        txtPhone.Enabled = false;
        //        txtLiterature.Enabled = false;
        //        txtMath.Enabled = false;
        //        btnWrite.Enabled = false;
        //        btnRead.Enabled = true;
        //        ClearAll();
        //    }



        //}
        private void btnWrite_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Hoc_Ky_2\\LapTrinhMang\\Lab_2\\input.bin";

            // Kiểm tra xem tất cả các ô nhập liệu đã được điền đầy đủ hay chưa
            if (!IsAllFieldsFilled())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra độ dài của chuỗi
            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsValid())
            {
                // Tạo đối tượng SinhVien từ dữ liệu nhập vào
                SinhVien sinhVien = new SinhVien
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    ID = txtID.Text,
                    Literature = txtLiterature.Text,
                    Math = txtMath.Text
                };

                // Ghi đối tượng SinhVien xuống file bằng BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    formatter.Serialize(fs, sinhVien);
                }


                // Hiển thị dữ liệu vừa ghi vào TextBox
                ShowDataInTextBox(filePath);

                // Giảm số lượng sinh viên nhập còn lại và làm sạch các TextBox
                txtNum.Text = (int.Parse(txtNum.Text) - 1).ToString();
                ClearAll();

                // Kiểm tra xem đã nhập đủ số lượng sinh viên chưa
                if (txtNum.Text == "0")
                {
                    btnStart.Enabled = true;
                    txtNum.Enabled = true;
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    txtPhone.Enabled = false;
                    txtLiterature.Enabled = false;
                    txtMath.Enabled = false;
                    btnWrite.Enabled = false;
                    btnRead.Enabled = true;
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Sai định dạng, vui lòng nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức để hiển thị dữ liệu từ file vào TextBox
        private void ShowDataInTextBox(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                while (fs.Position < fs.Length)
                {
                    SinhVien sinhVien = (SinhVien)formatter.Deserialize(fs);
                    sb.AppendLine($"Name: {sinhVien.Name}, Phone: {sinhVien.Phone}, ID: {sinhVien.ID}, Literature: {sinhVien.Literature}, Math: {sinhVien.Math}");
                }
            }
            txtWrite.Text = sb.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text, out int num) && num > 0)
            {
                btnStart.Enabled = false;
                txtID.Enabled = true;
                txtName.Enabled = true;
                txtPhone.Enabled = true;
                txtLiterature.Enabled = true;
                txtMath.Enabled = true;
                txtWrite.Enabled = true;
                txtRead.Enabled = true;
                btnWrite.Enabled = true;
                btnRead.Enabled = false;
                txtNum.Enabled = false;
            }
            else
            {
                MessageBox.Show("Số lượng sinh viên phải là một số nguyên dương lớn hơn 0.\nVui lòng nhập lại!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Hoc_Ky_2\\LapTrinhMang\\Lab_2\\input.bin", string.Empty);
            File.WriteAllText("C:\\Hoc_Ky_2\\LapTrinhMang\\Lab_2\\output.bin", string.Empty);
            txtWrite.Text = "";
            txtRead.Text = "";
            ClearAll();
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtID.Enabled = false;
            txtMath.Enabled = false;
            txtLiterature.Enabled = false;
            txtWrite.Enabled = false;
            txtRead.Enabled = false;
            btnRead.Enabled = false;
            btnWrite.Enabled = false;
            txtNum.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string inputFilePath = "C:\\Hoc_Ky_2\\LapTrinhMang\\Lab_2\\input.bin";
            string outputFilePath = "C:\\Hoc_Ky_2\\LapTrinhMang\\Lab_2\\output.bin";

            // Khai báo StringBuilder để chứa dữ liệu đọc từ file input
            StringBuilder sb = new StringBuilder();

            // Mở file input để đọc bằng FileStream và BinaryFormatter
            using (FileStream inputFs = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while (inputFs.Position < inputFs.Length)
                {
                    // Đọc từng đối tượng SinhVien từ file input
                    SinhVien sinhVien = (SinhVien)formatter.Deserialize(inputFs);

                    // Tính điểm trung bình
                    float average = ((float.Parse(sinhVien.Math)) + (float.Parse(sinhVien.Literature)) )/ 2;

                    // Hiển thị thông tin của sinh viên và điểm trung bình ra TextBox
                    sb.AppendLine($"Name: {sinhVien.Name}, Phone: {sinhVien.Phone}, ID: {sinhVien.ID}, Literature: {sinhVien.Literature}, Math: {sinhVien.Math}, Average: {average}");

                    // Ghi dữ liệu và điểm trung bình vào file output
                    using (FileStream outputFs = new FileStream(outputFilePath, FileMode.Append, FileAccess.Write))
                    {
                        formatter.Serialize(outputFs, sinhVien);
                        formatter.Serialize(outputFs, average);
                    }
                }
            }

            // Hiển thị dữ liệu ra TextBox
            txtRead.Text = sb.ToString();

            MessageBox.Show($"Đã tính và ghi điểm trung bình vào file {outputFilePath}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtAddressRead_TextChanged(object sender, EventArgs e)
        {

        }

        private bool MustBeNum(char num)
        {
            return char.IsDigit(num) || num == '.';
        }
        private bool MustBeLetter(char letter)
        {
            return char.IsLetter(letter) || char.IsWhiteSpace(letter);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in txtName.Text)
            {
                if (!MustBeLetter(item))
                {
                    MessageBox.Show("Sai định dạng, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                    return;
                }
            }
        }


        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            // Kiểm tra xem ô nhập liệu có rỗng không
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return; // Không làm gì nếu ô nhập liệu rỗng
            }



            // Kiểm tra xem tất cả các ký tự có phải là chữ số không
            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số từ 0 đến 9!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem chuỗi có bắt đầu bằng số 0 không
            if (phoneNumber[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void txtLiterature_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in txtLiterature.Text)
            {
                float num = float.Parse(txtLiterature.Text);
                if (!MustBeNum(item) || num < 0 || num > 10)
                {
                    MessageBox.Show("Giá trị không hợp lệ, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLiterature.Text = "";
                    return;
                }
            }
        }

        private void txtMath_TextChanged_1(object sender, EventArgs e)
        {
            foreach (char item in txtMath.Text)
            {
                float num = float.Parse(txtMath.Text);
                if (!MustBeNum(item) || num < 0 || num > 10)
                {
                    MessageBox.Show("Giá trị không hợp lệ, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMath.Text = "";
                    return;
                }
            }
        }
    }
}
