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
    class BLFindBook
    {
        DBMain db = null;
        public BLFindBook()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select DS.MaSach, DS.TuaSach, NXB.TenNXB, TG.TenTacGia, DS.GiaMua, DS.GiaMuon, CS.ViTri from DauSach as DS, NXB, TacGia as TG, CuonSach as CS where DS.MaNXB = NXB.MaNXB and DS.MaTG = TG.MaTG and DS.MaSach = CS.Masach and CS.FlagXoa = 'False'", CommandType.Text);
        }
        public DataSet TimKiemSach(string TenSach)
        {
            return db.ExecuteQueryDataSet("select distinct * from ((select * from (select DS.MaSach, DS.TuaSach, NXB.TenNXB, TG.TenTacGia, DS.GiaMua, DS.GiaMuon, CS.ViTri from DauSach as DS, NXB, TacGia as TG, CuonSach as CS where DS.MaNXB = NXB.MaNXB and DS.MaTG = TG.MaTG and DS.MaSach = CS.Masach and CS.FlagXoa = 'False') as F where TuaSach LIKE N'%" + TenSach + "%')) as P", CommandType.Text);
        }
    }
}
