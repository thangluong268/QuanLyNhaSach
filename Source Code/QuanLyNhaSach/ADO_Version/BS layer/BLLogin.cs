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
    class BLLogin
    {
        DBMain db = null;
        public BLLogin()
        {
            db = new DBMain();
        }
        public DataSet CheckDangNhap(string Quyen, string TaiKhoan, string MatKhau)
        {
            return db.ExecuteQueryDataSet("select count(*) as SoLuongTaiKhoan " +
                                        "from TaiKhoan where FlagXoa='False' group by Quyen, TenTK, MatKhau " +
                                        "having Quyen = N'" + Quyen + "' and TenTK = N'" + TaiKhoan + "' and MatKhau = N'" + MatKhau + "'", CommandType.Text);
        }
    }
}
