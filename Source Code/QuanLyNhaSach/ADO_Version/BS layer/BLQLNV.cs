using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ADO_Version.DB_layer;

namespace ADO_Version.BS_layer
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
            return db.ExecuteQueryDataSet("SELECT MaNV, TenNV, CongViec, Luong, DiaChi, NgaySinh, GioiTinh, soDT FROM NhanVien Where FlagXoa='False'", CommandType.Text);
        }
        public bool ThemNhanVien(string MaNhanVien, string HoTen, string CongViec, string Luong, string DiaChi, string NgaySinh, string Nam, string SoDienThoai, string flag, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values('" +
                            MaNhanVien + "',N'" +
                            HoTen + "',N'" +
                            CongViec + "','" +
                            Luong + "',N'" +
                            DiaChi + "','" +
                            NgaySinh + "','" +
                            Nam + "','" +
                            SoDienThoai + "','" +
                            flag + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(ref string err, string MaNhanVien, string flag)
        {
            string sqlString = "Update NhanVien Set FlagXoa='" +
                        flag +
                        "'Where MaNV='" +
                        MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaTaiKhoan(ref string err, string MaNhanVien, string flag)
        {
            string sqlString = "Update TaiKhoan Set FlagXoa='" +
                        flag +
                        "'Where MaNV='" +
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
                            MaNhanVien + "' and FlagXoa='False'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemNhanVien(string MaNhanVien, string TenNhanVien)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM NhanVien Where MaNV LIKE '%" + MaNhanVien + "%' and TenNV LIKE N'%" + TenNhanVien + "%' and FlagXoa='False'", CommandType.Text);
        }
        public bool ThemTaiKhoan(string MaNhanVien, string Quyen, string TaiKhoan, string MatKhau, string flag, ref string err)
        {
            string sqlString = "Insert Into TaiKhoan Values('" +
                            MaNhanVien + "',N'" +
                            Quyen + "',N'" +
                            TaiKhoan + "',N'" +
                            MatKhau + "','" +
                            flag + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet KiemTraNVTonTai(string MaNhanVien)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From NhanVien Where MaNV='" + MaNhanVien + "' and FlagXoa='False'", CommandType.Text);
        }
        public DataSet KiemTraNVDaXoa(string MaNhanVien)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From NhanVien Where MaNV='" + MaNhanVien + "' and FlagXoa='True'", CommandType.Text);
        }
        public bool CapNhatNhanVienDaXoa(string MaNhanVien, string HoTen, string CongViec, string Luong, string DiaChi, string NgaySinh, string Nam, string SoDienThoai, string flag, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" +
                            HoTen + "', CongViec=N'" +
                            CongViec + "', Luong='" +
                            Luong + "', DiaChi=N'" +
                            DiaChi + "', NgaySinh='" +
                            NgaySinh + "', GioiTinh='" +
                            Nam + "', soDT='" +
                            SoDienThoai + "', FlagXoa='" +
                            flag +
                            "'Where MaNV='" +
                            MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTaiKhoanDaXoa(string MaNhanVien, string Quyen, string TaiKhoan, string MatKhau, string flag, ref string err)
        {
            string sqlString = "Update TaiKhoan Set Quyen=N'" +
                            Quyen + "', TenTK=N'" +
                            TaiKhoan + "', MatKhau=N'" +
                            MatKhau + "', FlagXoa='" +
                            flag +
                            "'Where MaNV='" +
                            MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet KiemTraTKTonTai(string TaiKhoan)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From TaiKhoan where TenTK='" + TaiKhoan + "' and FlagXoa='False'", CommandType.Text);
        }
    }
}
