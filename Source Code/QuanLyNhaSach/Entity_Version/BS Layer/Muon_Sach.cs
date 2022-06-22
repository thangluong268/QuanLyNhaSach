using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class Muon_Sach
    {
        public DataTable Lay_TT()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.Muons
                         select new
                         {
                             MaKH = p.MaKH,
                             TenKH = p.KhachHang.TenKH,
                             MaCuon = p.MaCuon,
                             GiaMuon = p.CuonSach.DauSach.GiaMuon,
                             NgayMuon = p.NgayMuon,
                             HanTra = p.HanTra,
                             NgayTra = p.NgayTra,
                             TienPhat = p.TienPhat,
                             DangMuon = p.DangMuon,
                             DaThanhToan = p.DaThanhToan
                         };
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("GiaMuon");
            dataTable.Columns.Add("NgayMuon");
            dataTable.Columns.Add("HanTra");
            dataTable.Columns.Add("NgayTra");
            dataTable.Columns.Add("TienPhat");
            dataTable.Columns.Add("DangMuon");
            dataTable.Columns.Add("DaThanhToan");

            foreach (var item in result)
            {   
                if (item.DangMuon == true)
                    dataTable.Rows.Add(item.MaCuon, item.MaKH, item.TenKH, item.GiaMuon, item.NgayMuon, item.HanTra, item.NgayTra, item.TienPhat, item.DangMuon, item.DaThanhToan);
            }

            return dataTable;
        }

        public void KH_Muon_Sach (string MaKH, string MaCuon, DateTime NgMuon, ref string result)
        {
            if (check_KH_Is_FlagXoa(MaKH) == true)
            {
                result = "Khách hàng không tồn tại";
                return;
            }

            if (check_CuonSach_FlagXoa(MaCuon) == true)
            {
                result = "Cuốn sách không tồn tại";
                return;
            }

            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
          
            Muon muon = new Muon();
            muon.MaKH = MaKH;
            muon.MaCuon = MaCuon;
            muon.NgayMuon = NgMuon;
            muon.NgayTra = null;
            muon.DangMuon = true;
            muon.HanTra = NgMuon.AddMonths(1);
            muon.TienPhat = 0;
            muon.DaThanhToan = false;

            qlnsentity.Muons.Add(muon);
            qlnsentity.SaveChanges();

            result = "Đã thêm vảo giỏ hàng thành công";
            string option = "Muon";

            Set_Flag_Cuon_Sach(MaKH, MaCuon, option);
        }
        public void KH_Tra_Sach(string MaKH, string MaCuon)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.Muons
                          where p.MaKH == MaKH && p.MaCuon == MaCuon
                          select p).SingleOrDefault();

            result.DangMuon = false;
            result.NgayTra = Convert.ToDateTime(DateTime.Now);

            if (DateTime.Compare(Convert.ToDateTime(result.NgayTra), Convert.ToDateTime(result.HanTra)) > 0) // Returning overdue books
            {
                TimeSpan interval = Convert.ToDateTime(result.NgayTra).Subtract(Convert.ToDateTime(result.HanTra));
                int date = interval.Days;
                result.TienPhat = date * 5000;
            }    

            qlnsentity.SaveChanges();

            string option = "Tra";
            Set_Flag_Cuon_Sach(MaKH, MaCuon, option);
        }

        public DataTable Load_KH()
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

        void Set_Flag_Cuon_Sach (string MaKH, string MaCuon, string option)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            
            var result = (from p in qlnsentity.Muons
                          where p.MaKH == MaKH && p.MaCuon == MaCuon
                          select p).SingleOrDefault();

            if (option == "Muon")
            { 
                result.CuonSach.FlagXoa = true; 
            }

            else if (option == "Tra")
            {
                result.CuonSach.FlagXoa = false;
            }

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
