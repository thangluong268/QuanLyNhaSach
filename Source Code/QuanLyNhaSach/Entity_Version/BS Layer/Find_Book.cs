using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;
namespace EntityFramework_Version.BS_Layer
{
    internal class Find_Book
    {
        public DataTable Lay_TT_Sach () // Load Data
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.CuonSaches
                         select new
                         {
                             MaSach = p.Masach,
                             TuaSach = p.DauSach.TuaSach,
                             TenNXB = p.DauSach.NXB.TenNXB,
                             TenTG = p.DauSach.TacGia.TenTacGia,
                             GiaMua = p.DauSach.GiaMua,
                             GiaMuon = p.DauSach.GiaMuon,
                             ViTri = p.ViTri,
                             FlagXoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("TenNXB");
            dataTable.Columns.Add("TenTG");
            dataTable.Columns.Add("GiaMua");
            dataTable.Columns.Add("GiaMuon");
            dataTable.Columns.Add("ViTri");

            foreach (var item in result)
            {
                if (item.FlagXoa == false)
                    dataTable.Rows.Add(item.MaSach, item.TuaSach, item.TenNXB, item.TenTG, item.GiaMua, item.GiaMuon, item.ViTri);
            }    

            return dataTable;
        }

        public DataTable Tim_Sach(string TenSach)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.CuonSaches
                         where p.DauSach.TuaSach.Contains (TenSach)
                         select new
                         {
                             MaSach = p.Masach,
                             TuaSach = p.DauSach.TuaSach,
                             TenNXB = p.DauSach.NXB.TenNXB,
                             TenTG = p.DauSach.TacGia.TenTacGia,
                             GiaMua = p.DauSach.GiaMua,
                             GiaMuon = p.DauSach.GiaMuon,
                             ViTri = p.ViTri,
                             FlagXoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("TenNXB");
            dataTable.Columns.Add("TenTG");
            dataTable.Columns.Add("GiaMua");
            dataTable.Columns.Add("GiaMuon");
            dataTable.Columns.Add("ViTri");

            foreach (var item in result)
            {
                if (item.FlagXoa == false)
                    dataTable.Rows.Add(item.MaSach, item.TuaSach, item.TenNXB, item.TenTG, item.GiaMua, item.GiaMuon, item.ViTri);
            }

            return dataTable;
        }

    }
}
