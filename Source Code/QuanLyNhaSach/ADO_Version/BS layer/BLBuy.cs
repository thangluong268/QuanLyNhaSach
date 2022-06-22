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
    class BLBuy
    {
        DBMain db = null;
        public BLBuy()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("Select M.MaCuon, DS.TuaSach, M.MaKH, KH.TenKH, DS.GiaMua, M.NgayMua From CuonSach as CS, DauSach as DS, KhachHang as KH, Mua as M Where CS.MaCuon = M.MaCuon and KH.MaKH = M.MaKH and CS.Masach = DS.MaSach and M.DaThanhToan = 'True'", CommandType.Text);
        }
        public DataSet LayMaCuon()
        {
            return db.ExecuteQueryDataSet("Select MaCuon From CuonSach Where FlagXoa='False'", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang", CommandType.Text);
        }
        public bool MuaSach(string MaCuon, string MaKhachHang, string NgayMua, string flag, ref string err)
        {
            string sqlString = "Insert Into Mua Values('" +
                MaCuon + "','" +
                MaKhachHang + "','" +
                NgayMua + "','" +
                flag + "')";
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
    }
}
