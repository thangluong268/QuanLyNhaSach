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
    class BLCustomer
    {
        DBMain db = null;
        public BLCustomer()
        {
            db = new DBMain();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KhachHang", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKhachHang, string HoTen, string DiaChi, string NgaySinh, string SoDienThoai, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values('" +
                            MaKhachHang + "',N'" +
                            HoTen + "',N'" +
                            DiaChi + "','" +
                            NgaySinh + "','" +
                            SoDienThoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKhachHang)
        {
            string sqlString = "Delete From KhachHang Where MaKH='" +
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
                            MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
