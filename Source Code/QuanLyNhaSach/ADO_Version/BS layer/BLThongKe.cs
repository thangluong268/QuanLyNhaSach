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
    class BLThongKe
    {
        DBMain db = null;
        public BLThongKe()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select DS.MaSach, DS.TuaSach, count(DS.MaSach) as SoLuong from DauSach as DS, CuonSach as CS where DS.MaSach = CS.Masach and CS.FlagXoa='False' group by DS.MaSach, DS.TuaSach", CommandType.Text);
        }
        public DataSet TinhTienBanSach()
        {
            return db.ExecuteQueryDataSet("select sum(cast(DS.GiaMua as int)) from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach and M.DaThanhToan = 'True'", CommandType.Text);
        }
        public DataSet TinhTienMuonSach()
        {
            return db.ExecuteQueryDataSet("select sum(cast(DS.GiaMuon as int)) from Muon as M, CuonSach as CS, DauSach as DS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach and M.DangMuon = 'True'", CommandType.Text);
        }
        public DataSet TinhTienPhat()
        {
            return db.ExecuteQueryDataSet("select sum(cast(TienPhat as int)) from Muon where DaThanhToan = 'True'", CommandType.Text);
        }
        public DataSet TinhTienTheoNam(string NgayBatDau, string NgayKetThuc)
        {
            return db.ExecuteQueryDataSet("select YearMua as Year, TienBan, TienMuon, TienPhat from (select Year(M.NgayMua) as YearMua, sum(cast(DS.GiaMua as int)) as TienBan from Mua as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach and M.DaThanhToan = 'True' and (M.NgayMua between'" + NgayBatDau + "'and'" + NgayKetThuc + "') group by Year(M.NgayMua)) as Ban, (select Year(M.NgayMuon) as YearMuon, sum(cast(DS.GiaMuon as int)) as TienMuon from Muon as M, CuonSach as CS, DauSach as DS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach and M.DangMuon = 'True' and (M.NgayMuon between'" + NgayBatDau + "'and'" + NgayKetThuc + "') group by Year(M.NgayMuon)) as Muon, (select Year(NgayTra) as YearPhat, sum(cast(TienPhat as int)) as TienPhat from Muon where DaThanhToan = 'True' and (NgayTra between'" + NgayBatDau + "'and'" + NgayKetThuc + "') group by Year(NgayTra)) as Phat", CommandType.Text);
        }
        public DataSet TinhTienTheoThang(string NgayBatDau)
        {
            return db.ExecuteQueryDataSet("select X.ThongKeTheoThang, GiaMua, GiaMuon, TienPhat from((" +
                " select MONTH(NgayMua) as ThongKeTheoThang, Sum(cast(GiaMua as int)) as GiaMua from(" +
                " ((select MaCuon, GiaMua from DauSach inner join CuonSach on DauSach.Masach = CuonSach.Masach) A inner join" +
                " (select * from Mua" +
                " where (Mua.DaThanhToan = 1 and Mua.NgayMua >='" + NgayBatDau + "')) B on A.MaCuon = B.MaCuon))" +
	            " group by MONTH(NgayMua))X full join(" +
                " select MONTH(NgayMuon) as ThongKeTheoThang, Sum(cast(GiaMuon as int)) as GiaMuon, sum(cast(TienPhat as int)) as TienPhat from(" +
                " ((select MaCuon, GiaMuon from DauSach inner join CuonSach on DauSach.Masach = CuonSach.Masach) A inner join" +
                " (select * from Muon" +
                " where Muon.DaThanhToan = 1 and Muon.NgayMuon >='" + NgayBatDau + "') B on A.MaCuon = B.MaCuon))" +
                " group by MONTH(NgayMuon))Y on X.ThongKeTheoThang = Y.ThongKeTheoThang)", CommandType.Text);
        }
    }
}
