using System;

namespace Lab2
{
    [Serializable]
    internal class SinhVien
    {
        // Các thuộc tính của sinh viên
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ID { get; set; }
        public string Literature { get; set; }
        public string Math { get; set; }

        // Constructor mặc định
        public SinhVien()
        {
        }

        // Constructor với các tham số
        public SinhVien(string name, string phone, string id, string literature, string math)
        {
            Name = name;
            Phone = phone;
            ID = id;
            Literature = literature;
            Math = math;
        }

        // Override phương thức ToString để hiển thị thông tin sinh viên
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, ID: {ID}, Literature: {Literature}, Math: {Math}";
        }
    }
}
