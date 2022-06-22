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
    class BLBuyPay
    {
        DBMain db = null;
        public BLBuyPay()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select M.MaKH, M.MaCuon, M.NgayMua, DS.GiaMua from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang", CommandType.Text);
        }
        public DataSet TimKiemThanhToan(string MaKhachHang, string NgayMua)
        {
            return db.ExecuteQueryDataSet("select * from (select M.MaKH, M.MaCuon, M.NgayMua, DS.GiaMua from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as M where MaKH LIKE '%" + MaKhachHang + "%' and NgayMua LIKE '%" + NgayMua + "%'", CommandType.Text);
        }
    }
}
