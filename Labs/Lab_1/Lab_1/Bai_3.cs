using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_1
{
    public partial class Bai_3_2 : Form
    {
        public Bai_3_2()
        {
            InitializeComponent();

        }

        //private static string Chu(string gNumber)
        //{
        //    string result = "";
        //    switch (gNumber)
        //    {
        //        case "0":
        //            result = "không";
        //            break;
        //        case "1":
        //            result = "một";
        //            break;
        //        case "2":
        //            result = "hai";
        //            break;
        //        case "3":
        //            result = "ba";
        //            break;
        //        case "4":
        //            result = "bốn";
        //            break;
        //        case "5":
        //            result = "năm";
        //            break;
        //        case "6":
        //            result = "sáu";
        //            break;
        //        case "7":
        //            result = "bảy";
        //            break;
        //        case "8":
        //            result = "tám";
        //            break;
        //        case "9":
        //            result = "chín";
        //            break;
        //    }
        //    return result;
        //}
        //private static string Donvi(string so)
        //{
        //    string Kdonvi = "";

        //    if (so.Equals("1"))
        //        Kdonvi = "";
        //    if (so.Equals("2"))
        //        Kdonvi = "nghìn";
        //    if (so.Equals("3"))
        //        Kdonvi = "triệu";
        //    if (so.Equals("4"))
        //        Kdonvi = "tỷ";
        //    if (so.Equals("5"))
        //        Kdonvi = "nghìn tỷ";
        //    if (so.Equals("6"))
        //        Kdonvi = "triệu tỷ";
        //    if (so.Equals("7"))
        //        Kdonvi = "tỷ tỷ";

        //    return Kdonvi;
        //}
        //private static string Tach(string tach3)
        //{
        //    string Ktach = "";
        //    if (tach3.Equals("000"))
        //        return "";
        //    if (tach3.Length == 3)
        //    {
        //        string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
        //        string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
        //        string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
        //        if (tr.Equals("0") && ch.Equals("0"))
        //            Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
        //        if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
        //            Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
        //        if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
        //            Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
        //        if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
        //            Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
        //        if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
        //            Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
        //        if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
        //            Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
        //        if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
        //            Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
        //        if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
        //            Ktach = " không trăm mười ";
        //        if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
        //            Ktach = " không trăm mười lăm ";
        //        if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
        //        if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
        //        if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
        //        if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

        //        if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
        //        if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
        //            Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

        //    }


        //    return Ktach;

        //}
        //public static string So_chu(double gNum)
        //{
        //    if (gNum == 0)
        //        return "Không";

        //    string lso_chu = "";
        //    string tach_mod = "";
        //    string tach_conlai = "";
        //    double Num = Math.Round(gNum, 0);
        //    string gN = Convert.ToString(Num);
        //    int m = Convert.ToInt32(gN.Length / 3);
        //    int mod = gN.Length - m * 3;
        //    string dau = "[+]";

        //    // Dau [+ , - ]
        //    if (gNum < 0)
        //        dau = "[-]";
        //    dau = "";

        //    // Tach hang lon nhat
        //    if (mod.Equals(1))
        //        tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
        //    if (mod.Equals(2))
        //        tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
        //    if (mod.Equals(0))
        //        tach_mod = "000";
        //    // Tach hang con lai sau mod :
        //    if (Num.ToString().Length > 2)
        //        tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

        //    ///don vi hang mod
        //    int im = m + 1;
        //    if (mod > 0)
        //        lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
        //    /// Tach 3 trong tach_conlai

        //    int i = m;
        //    int _m = m;
        //    int j = 1;
        //    string tach3 = "";
        //    string tach3_ = "";

        //    while (i > 0)
        //    {
        //        tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
        //        tach3_ = tach3;
        //        lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
        //        m = _m + 1 - j;
        //        if (!tach3_.Equals("000"))
        //            lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
        //        tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

        //        i = i - 1;
        //        j = j + 1;
        //    }
        //    if (lso_chu.Trim().Substring(0, 1).Equals("k"))
        //        lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
        //    if (lso_chu.Trim().Substring(0, 1).Equals("l"))
        //        lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
        //    if (lso_chu.Trim().Length > 0)
        //        lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim();

        //    return lso_chu.ToString().Trim();

        //}



        //public string TranslateText(string input)
        //{
        //    string url = String.Format
        //    ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
        //     lang_first, lang_second, Uri.EscapeUriString(input));
        //    HttpClient httpClient = new HttpClient();
        //    string result = httpClient.GetStringAsync(url).Result;
        //    var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
        //    var translationItems = jsonData[0];
        //    string translation = "";
        //    foreach (object item in translationItems)
        //    {
        //        IEnumerable translationLineObject = item as IEnumerable;
        //        IEnumerator translationLineString = translationLineObject.GetEnumerator();
        //        translationLineString.MoveNext();
        //        translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
        //    }
        //    if (translation.Length > 1) { translation = translation.Substring(1); };
        //    return translation;
        //}


        public String translate(String input, string from, string to)
        {
            var fromLanguage = from;
            var toLanguage = to;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(input)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webclient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4
                    , StringComparison.Ordinal) - 4);
                return result;
            }
            catch (Exception e1)
            {
                return "error";
            }
        }

        static string RemoveWord(string input, string word)
        {
            // Tách chuỗi thành các từ bằng cách phân cách bởi khoảng trắng
            string[] words = input.Split(' ');

            // Xóa từ "và" khỏi danh sách các từ
            string result = string.Join(" ", words.Where(w => !w.Equals(word)));

            return result;
        }

        private bool IsValidInput()
        {
            // Kiểm tra xem các ô nhập có chứa dữ liệu hợp lệ không
            if (double.TryParse(txbnum.Text, out double number))
            {
                // Kiểm tra nếu số nhập vào lớn hơn hoặc bằng 10000
                if (number >= 10000)
                {
                    // Trả về false vì số nhập vào không hợp lệ
                    return false;
                }
                // Trả về true nếu số nhập vào hợp lệ
                return true;
            }
            // Trả về false nếu dữ liệu không phải số
            return false;
        }

        private string DocSo(int no)
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };

            string strWords = "";

            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " Ngàn ";
                no = no % 1000;
            }


            if (no > 99 && no < 1000)
            {
                int i = no / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100;
            }

            if (no > 19 && no < 100)
            {
                int i = no / 10;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10;
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1];
            }

            if (no == 0)
            {
                strWords = "không";
            }
            return strWords;

        }

        public static string ChuanHoaChuoi(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Viết hoa ký tự đầu tiên
            string first = input.Substring(0, 1).ToUpper();

            // Viết thường các ký tự còn lại
            string all = input.Substring(1).ToLower();

            // Kết hợp kết quả
            return first + all;
        }

        private void btnread_Click(object sender, EventArgs e)
        {

            if (IsValidInput())
            {
                int num = int.Parse(txbnum.Text);

                //string res = num.ToWords();
                //res = translate(res, "en", "vi");
                //res = RemoveWord(res, "và");

                string res = DocSo(num);

                txbres.Text = ChuanHoaChuoi(res);
            }

            else
            {
                MessageBox.Show("Vui lòng nhập vào số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txbnum.Clear();
            txbres.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
