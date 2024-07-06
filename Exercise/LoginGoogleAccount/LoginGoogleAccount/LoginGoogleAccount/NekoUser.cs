﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;
using BCrypt.Net;

namespace LoginGoogleAccount
{
    internal class NekoUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }

        private static string error1 = "Tài khoản không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {
            MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_3()
        {
            MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsEqual(NekoUser user1, NekoUser user2)
        {
            if (user1 == null || user2 == null) return false;

            if (user1.Username != user2.Username)
            {
                error1 = "Tài khoản không tồn tại!";
                return false;
            }

            if (!BCrypt.Net.BCrypt.EnhancedVerify(user2.Password, user1.Password, hashType: HashType.SHA384))
            {
                error1 = "Sai tài khoản hoặc mật khẩu!";
                return false;
            }

            return true;
        }

        public static bool IsExist(NekoUser user1, NekoUser user2)
        {
            if (user1 == null || user2 == null) return false;

            if (user1.Username != user2.Username || user1.Email != user2.Email || user1.PhoneNumber != user2.PhoneNumber)
            {
                error1 = "Tài khoản không tồn tại!";
                return false;
            }

            return true;
        }

        public static bool Search(NekoUser user1, NekoUser user2)
        {
            if (user1 == null || user2 == null) return false;

            if (user1.Username != user2.Username)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}