using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Version.DB_Layer;
using System.Data;

namespace EntityFramework_Version.BS_Layer
{
    internal class Mua_Sach
    {
        public DataTable Lay_TT_Mua() // Load Data
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = from p in qlnsentity.Muas
                         select new
                         {
                             MaKH = p.MaKH,
                             TenKH = p.KhachHang.TenKH,
                             MaCuon = p.MaCuon,
                             TuaSach = p.CuonSach.DauSach.TuaSach,
                             SoTien = p.CuonSach.DauSach.GiaMua,
                             NgMua = p.NgayMua,
                             DaThanhToan = p.DaThanhToan
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("GiaMua");
            dataTable.Columns.Add("NgMua");
            dataTable.Columns.Add("DaThanhToan");

            foreach (var item in result)
            {
                if (item.DaThanhToan == false)
                    dataTable.Rows.Add(item.MaKH, item.TenKH, item.MaCuon, item.TuaSach, item.SoTien, item.NgMua, item.DaThanhToan);
            }

            return dataTable;
        }

        public void Them_KH_Mua(string MaKH, string MaCuon, DateTime NgMua, ref string result)
        {
            if (check_KH_Is_FlagXoa(MaKH) == true) 
            {
                result = "Khách Hàng Không Tồn Tại";
                return;
            }

            if (check_CuonSach_FlagXoa(MaCuon) == true)
            {
                result = "Cuốn Sách Không Tồn Tại";
                return;
            }    

            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            Mua mua = new Mua();

            mua.MaKH = MaKH;
            mua.MaCuon = MaCuon;
            mua.NgayMua = NgMua;
            mua.DaThanhToan = false;

            qlnsentity.Muas.Add(mua);
            qlnsentity.SaveChanges();
            result = "Thêm Vào Giỏ Hàng Thành Công";
            
            
            qlnsentity.SaveChanges();
            Set_Flag_Cuon_Sach(MaKH, MaCuon);

        }

        public DataTable Load_KH ()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = from p in qlnsentity.KhachHangs
                         where p.FlagXoa == false
                         select new
                         {
                             MaKH = p.MaKH,
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");

            foreach (var item in result)
            {
                dataTable.Rows.Add(item.MaKH);
            }

            return dataTable;

        }

        public DataTable Load_CuonSach_Chua_Xoa()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = from p in qlnsentity.CuonSaches
                         where p.FlagXoa == false
                         select new
                         {
                             MaCuon = p.MaCuon
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");

            foreach (var item in result)
            {
                dataTable.Rows.Add(item.MaCuon);
            }

            return dataTable;

        }

        void Set_Flag_Cuon_Sach(string MaKH, string MaCuon) // set flag in CUonSach value false
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result1 = (from p in qlnsentity.Muas
                           where p.MaKH == MaKH && p.MaCuon == MaCuon
                           select p).SingleOrDefault();


            result1.CuonSach.FlagXoa= true;
            
            qlnsentity.SaveChanges();

        }

        bool check_KH_Is_FlagXoa(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.KhachHangs
                          where p.MaKH == MaKH
                          select p).SingleOrDefault();
            if (result.FlagXoa == true)
                return true;
            return false;
        }

        bool check_CuonSach_FlagXoa(string MaCuon)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.CuonSaches
                          where p.MaCuon == MaCuon
                          select p).SingleOrDefault();
            if (result.FlagXoa == true)
                return true;
            return false;
        }
    }
}
