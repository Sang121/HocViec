using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap1.Modules
{
    public class NhanVien
    {
        public  string MaNV { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string chucVu { get; set; }
        public int namCongTac { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string MaNV, string name, string birthday, string phoneNumber, string address, string chucVu, int namCongTac) {
            this.MaNV = MaNV;
            this.name =name;
            this.birthday = birthday;
            this.phoneNumber =phoneNumber;
            this.address = address;
            this.chucVu = chucVu;
            this.namCongTac = namCongTac;    
        }
        public void info()
        {
            Console.WriteLine("Mã nhân viên: {0},Tên nhân viên: {1},số điện thoại: {2} ",MaNV,name,phoneNumber);

        }


       


    }
}
