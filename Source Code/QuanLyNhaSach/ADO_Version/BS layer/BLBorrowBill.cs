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
    class BLBorrowBill
    {
        DBMain db = null;
        public BLBorrowBill()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu(string MaKhachHang, string NgayMuon)
        {
            return db.ExecuteQueryDataSet("select * from (select M.MaCuon, M.MaKH, M.NgayMuon, M.HanTra, DS.GiaMuon from Muon as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as B where MaKH LIKE '%" + MaKhachHang + "%' and NgayMuon LIKE '%" + NgayMuon + "%'", CommandType.Text);
        }
        public DataSet TinhTong(string MaKhachHang, string NgayMuon)
        {
            return db.ExecuteQueryDataSet("select count(MaCuon), Sum(cast(GiaMuon as int)) from (select M.MaCuon, M.MaKH, M.NgayMuon, M.HanTra, DS.GiaMuon from Muon as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as B where MaKH LIKE '%" + MaKhachHang + "%' and NgayMuon LIKE '%" + NgayMuon + "%'", CommandType.Text);
        }
    }
}
