using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using QuanLyNhaSach.DB_layer;

namespace QuanLyNhaSach.BS_layer
{
    class BLSignUp
    {
        DBMain db = null;
        public BLSignUp()
        {
            db = new DBMain();
        }
        public bool ThemNhanVien(string MaNhanVien, string HoTen, string CongViec, string Luong, string DiaChi, string NgaySinh, string Nam, string SoDienThoai, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values('" +
                            MaNhanVien + "',N'" +
                            HoTen + "',N'" +
                            CongViec + "','" +
                            Luong + "',N'" +
                            DiaChi + "','" +
                            NgaySinh + "','" +
                            Nam + "','" +
                            SoDienThoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ThemTaiKhoan(string MaNhanVien, string Quyen, string TaiKhoan, string MatKhau, ref string err)
        {
            string sqlString = "Insert Into TaiKhoan Values('" +
                            MaNhanVien + "',N'" +
                            Quyen + "',N'" +
                            TaiKhoan + "',N'" +
                            MatKhau + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
