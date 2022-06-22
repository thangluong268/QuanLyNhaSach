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
    class BLForgetPassword
    {
        DBMain db = null;
        public BLForgetPassword()
        {
            db = new DBMain();
        }
        public DataSet LayThongTin(string MaNhanVien, string TenNhanVien, string SoDienThoai)
        {
            return db.ExecuteQueryDataSet("Select NV.MaNV, TK.TenTK, TK.MatKhau from NhanVien as NV, TaiKhoan as TK " + 
                "where NV.MaNV = N'" + MaNhanVien + "' and NV.TenNV = N'" + TenNhanVien + "' and NV.soDT = '" + SoDienThoai + "'" + 
                "and NV.MaNV = TK.MaNV", CommandType.Text);
        }
    }
}
