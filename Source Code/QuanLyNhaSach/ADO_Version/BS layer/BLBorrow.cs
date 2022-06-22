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
    class BLBorrow
    {
        DBMain db = null;
        public BLBorrow()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select M.MaCuon, M.MaKH, KH.TenKH, DS.GiaMuon, M.NgayMuon, M.HanTra, M.NgayTra, M.TienPhat, M.DangMuon, M.DaThanhToan from Muon as M, KhachHang as KH, DauSach as DS, CuonSach as CS where M.MaKH = KH.MaKH and M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang where FlagXoa='False'", CommandType.Text);
        }
        public DataSet LayMaCuon()
        {
            return db.ExecuteQueryDataSet("Select MaCuon From CuonSach", CommandType.Text);
        }
        public bool MuonSach(string MaCuon, string MaKhachHang, string NgayMuon, string HanTra, string DangMuon, ref string err)
        {
            string sqlString = "Insert Into Muon Values('" +
                MaCuon + "','" +
                MaKhachHang + "','" +
                NgayMuon + "',NULL,'" +
                HanTra + "','0','" +
                DangMuon + "', 'False')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTraSach(string MaCuon, string MaKhachHang, string NgayTra, string TienPhat, string DangMuon, ref string err)
        {
            string sqlString = "Update Muon Set NgayTra='" +
                NgayTra + "',TienPhat='" + 
                TienPhat + "',DangMuon='" +
                DangMuon +
                "', DaThanhToan='True' Where MaCuon='" +
                MaCuon + "' and MaKH='" +
                MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatMuonSach(string MaCuon, string MaKhachHang, string NgayMuon, string HanTra, string DangMuon, ref string err)
        {
            string sqlString = "Update Muon Set NgayMuon='" +
                NgayMuon + "',NgayTra=NULL,HanTra='" +
                HanTra + "',TienPhat=NULL,DangMuon='" +
                DangMuon +
                "', DaThanhToan='False' Where MaCuon='" +
                MaCuon + "' and MaKH='" +
                MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatCuonSach(string MaCuon, string flag, ref string err)
        {
            string sqlString = "Update CuonSach Set FlagXoa='" +
                flag +
                "'Where MaCuon='" +
                MaCuon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet KiemTraCSDangMuon(string MaCuon)
        {
            return db.ExecuteQueryDataSet("Select Count(*) From CuonSach Where MaCuon='" + MaCuon + "' and FlagXoa='True'", CommandType.Text);
        }
        public DataSet LayHanTra(string MaCuon, string MaKhachHang)
        {
            return db.ExecuteQueryDataSet("select HanTra from Muon where MaCuon LIKE '%" + MaCuon + "%' and MaKH LIKE '%" + MaKhachHang + "%'", CommandType.Text);
        }
    }
}
