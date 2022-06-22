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
    class BLBuyBill
    {
        DBMain db = null;
        public BLBuyBill()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu(string MaKhachHang, string NgayMua)
        {
            return db.ExecuteQueryDataSet("select * from (select M.MaKH, M.MaCuon, M.NgayMua, DS.GiaMua from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as M where MaKH LIKE '%" + MaKhachHang + "%' and NgayMua LIKE '%" + NgayMua + "%'", CommandType.Text);
        }
        public DataSet TinhTong(string MaKhachHang, string NgayMua)
        {
            return db.ExecuteQueryDataSet("select count(MaCuon), Sum(cast(GiaMua as int)) from (select M.MaKH, M.MaCuon, M.NgayMua, DS.GiaMua from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as M where MaKH LIKE '%" + MaKhachHang + "%' and NgayMua LIKE '%" + NgayMua + "%'", CommandType.Text);
        }
    }
}
