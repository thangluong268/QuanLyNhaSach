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
    class BLCustomer
    {
        DBMain db = null;
        public BLCustomer()
        {
            db = new DBMain();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("SELECT MaKh, TenKH, DiaChi, NgaySinh, soDT FROM KhachHang Where FlagXoa='False'", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKhachHang, string HoTen, string DiaChi, string NgaySinh, string SoDienThoai, string flag, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values('" +
                            MaKhachHang + "',N'" +
                            HoTen + "',N'" +
                            DiaChi + "','" +
                            NgaySinh + "','" +
                            SoDienThoai + "','" +
                            flag + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKhachHang, string flag)
        {
            string sqlString = "Update KhachHang Set FlagXoa='" +
                        flag +
                        "'Where MaKH='" +
                        MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKhachHang, string HoTen, string DiaChi, string NgaySinh, string SoDienThoai, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" +
                            HoTen + "', DiaChi=N'" +
                            DiaChi + "', NgaySinh='" +
                            NgaySinh + "', soDT='" +
                            SoDienThoai +
                            "'Where MaKH='" +
                            MaKhachHang + "' and FlagXoa='False'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemKhachHang(string MaKhachHang, string TenKhachHang)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KhachHang Where MaKH LIKE '%" + MaKhachHang + "%' and TenKH LIKE N'%" + TenKhachHang + "%' and FlagXoa='False'", CommandType.Text);
        }
        public DataSet KiemTraKHTonTai(string MaKhachHang)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From KhachHang Where MaKH='" + MaKhachHang + "' and FlagXoa='False'", CommandType.Text);
        }
        public DataSet KiemTraKHDaXoa(string MaKhachHang)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From KhachHang Where MaKH='" + MaKhachHang + "' and FlagXoa='True'", CommandType.Text);
        }
        public bool CapNhatKhachHangDaXoa(string MaKhachHang, string HoTen, string DiaChi, string NgaySinh, string SoDienThoai, string flag, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" +
                            HoTen + "', DiaChi=N'" +
                            DiaChi + "', NgaySinh='" +
                            NgaySinh + "', soDT='" +
                            SoDienThoai + "', FlagXoa='" +
                            flag +
                            "'Where MaKH='" +
                            MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet KiemTraKHDangMuon(string MaKhachHang)
        {
            return db.ExecuteQueryDataSet("select count(M.MaKH) from KhachHang as KH, Muon as M where KH.MaKH = M.MaKH and M.DangMuon = 'True' and M.MaKH LIKE '%" + MaKhachHang + "%'", CommandType.Text);
        }
    }
}
