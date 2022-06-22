using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class Pay_Buy
    {
        public DataTable Lay_TT_Pay_Buy()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_mua = from p in qlnsentity.Muas
                              where p.DaThanhToan == false
                             select new
                             {
                                 MaKH = p.MaKH,
                                 MaCuon = p.MaCuon,
                                 NgayMua = p.NgayMua,
                                 GiaMua = p.CuonSach.DauSach.GiaMua,
                             };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("NgayMua");
            dataTable.Columns.Add("GiaMua");

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaKH, item.MaCuon, item.NgayMua, item.GiaMua);
            }

            return dataTable;
        }

        public DataTable Tim_KH_Chua_Thanh_Toan(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_mua = from p in qlnsentity.Muas
                             where p.DaThanhToan == false && p.MaKH == MaKH
                             select new
                             {
                                 MaKH = p.MaKH,
                                 MaCuon = p.MaCuon,
                                 NgayMua = p.NgayMua,
                                 GiaMua = p.CuonSach.DauSach.GiaMua,
                             };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("NgayMua");
            dataTable.Columns.Add("GiaMua");

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaKH, item.MaCuon, item.NgayMua, item.GiaMua);
            }

            return dataTable;
        }

        public (DataTable, int, int) Pay_Bill_Buy(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_mua = from p in qlnsentity.Muas
                             where p.DaThanhToan == false && p.MaKH == MaKH
                             select new
                             {
                                 MaKH = p.MaKH,
                                 NgayMua = p.NgayMua,
                                 MaCuon = p.MaCuon,
                                 GiaMua = p.CuonSach.DauSach.GiaMua,
                             };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("NgayMua");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("GiaMua");

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaKH, item.NgayMua, item.MaCuon, item.GiaMua);
            }

            int SoLuong = dataTable.Rows.Count;
            int ThanhTien = 0;

            for (int i = 0; i < SoLuong; i++)
            {
                ThanhTien += Convert.ToInt32(dataTable.Rows[i][3].ToString());
            }

            return (dataTable, SoLuong, ThanhTien);

        }

        public void DaThanhToan(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = (from p in qlnsentity.Muons
                               where p.MaKH == MaKH && p.DaThanhToan == false
                               select p);

            var result_mua = (from p in qlnsentity.Muas
                              where p.MaKH == MaKH && p.DaThanhToan == false
                              select p);

            if (result_muon != null)
            {
                foreach (var item in result_muon)
                    item.DaThanhToan = true;
            }

            if (result_mua != null)
            {
                foreach (var item in result_mua)
                    item.DaThanhToan = true;
            }

            qlnsentity.SaveChanges();
        }
    }
}
