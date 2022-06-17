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
    class BLQLNV
    {
        DBMain db = null;
        public BLQLNV()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM NhanVien", CommandType.Text);
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
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" +
                        MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNhanVien, string HoTen, string CongViec, string Luong, string DiaChi, string NgaySinh, string Nam, string SoDienThoai, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" +
                            HoTen + "', CongViec=N'" +
                            CongViec + "', Luong='" +
                            Luong + "', DiaChi=N'" +
                            DiaChi + "', NgaySinh='" +
                            NgaySinh + "', GioiTinh='" +
                            Nam + "', soDT='" +
                            SoDienThoai +
                            "'Where MaNV='" +
                            MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
