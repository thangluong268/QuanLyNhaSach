using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class Pay_Borrow
    {
        public DataTable Lay_TT_Pay_Borrow()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                         where p.DaThanhToan == false
                         select p;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("NgayMuon");
            dataTable.Columns.Add("HanTra");
            dataTable.Columns.Add("GiaMuon");

            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.NgayMuon, item.HanTra, item.CuonSach.DauSach.GiaMuon);
            }

            return dataTable;
        }

        public DataTable Tim_KH_Chua_Thanh_Toan (string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                              where p.DaThanhToan == false && p.MaKH == MaKH
                              select p;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("NgayMuon");
            dataTable.Columns.Add("HanTra");
            dataTable.Columns.Add("GiaMuon");

            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.NgayMuon, item.HanTra, item.CuonSach.DauSach.GiaMuon);
            }

            return dataTable;
        }

        public (DataTable, int, int) Pay_Bill_Borrow(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                              where p.DaThanhToan == false && p.MaKH == MaKH
                              select new
                              {
                                  MaCuon = p.MaCuon,
                                  MaKH = p.MaKH,
                                  NgayMuon = p.NgayMuon,
                                  HanTra = p.HanTra,
                                  GiaMuon = p.CuonSach.DauSach.GiaMuon
                              };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("NgayMuon");
            dataTable.Columns.Add("HanTra");
            dataTable.Columns.Add("GiaMuon");

            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.NgayMuon, item.HanTra, item.GiaMuon);
            }
            int SoLuong = dataTable.Rows.Count;
            int ThanhTien = 0;

            for (int i =0; i< SoLuong; i++)
            {
                ThanhTien += Convert.ToInt32(dataTable.Rows[i][4].ToString());
            }

            return (dataTable, SoLuong, ThanhTien);

        }

        public void DaThanhToan(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = (from p in qlnsentity.Muons
                               where p.MaKH == MaKH && p.DaThanhToan == false
                               select p);


            if (result_muon != null)
            {
                foreach (var item in result_muon)
                    item.DaThanhToan = true;
            }    

            qlnsentity.SaveChanges();
        }
    }
}
