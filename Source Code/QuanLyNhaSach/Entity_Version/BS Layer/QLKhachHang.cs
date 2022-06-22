using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class QLKhachHang
    {
        public DataTable Lay_TT_Khach()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.KhachHangs
                         select new
                         {
                             MaKH = p.MaKH,
                             TenKH = p.TenKH, 
                             DiaChi = p.DiaChi,
                             NgaySinh = p.NgaySinh, 
                             soDT = p.soDT,
                             Flag_Xoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("DiaChi");
            dataTable.Columns.Add("NgaySinh");
            dataTable.Columns.Add("soDT");

            foreach (var item in result)
            {
                if (item.Flag_Xoa == false)
                    dataTable.Rows.Add(item.MaKH, item.TenKH, item.DiaChi, item.NgaySinh, item.soDT);
            }

            return dataTable;
        }

        public void Them_Khach_Hang (string MaKH, string TenKH, DateTime NgSinh, string DiaChi, string SDT)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            KhachHang khach_hang = new KhachHang();
            khach_hang.MaKH = MaKH;
            khach_hang.TenKH = TenKH;
            khach_hang.NgaySinh = NgSinh;
            khach_hang.DiaChi = DiaChi;
            khach_hang.soDT = SDT;
            khach_hang.FlagXoa = false;

            qlnsentity.KhachHangs.Add(khach_hang);
            qlnsentity.SaveChanges();
        }

        public void Cap_Nhat_TT_Khach_Hang (string MaKH, string TenKH, DateTime NgSinh, string DiaChi, string SDT)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = (from p in qlnsentity.KhachHangs
                          where p.MaKH == MaKH
                          select p).SingleOrDefault();

            if (result != null)
            {
                result.TenKH = TenKH;
                result.NgaySinh = NgSinh;
                result.DiaChi = DiaChi;
                result.soDT = SDT;

            }

            qlnsentity.SaveChanges();

        }

        public DataTable Tim_Khach_Hang (string MaKH, string TenKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = from p in qlnsentity.KhachHangs
                         where p.TenKH == TenKH && p.MaKH == MaKH
                         select new
                         {
                             MaKH = p.MaKH,
                             TenKH = p.TenKH,
                             DiaChi = p.DiaChi,
                             NgaySinh = p.NgaySinh,
                             soDT = p.soDT,
                             Flag_Xoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("DiaChi");
            dataTable.Columns.Add("NgaySinh");
            dataTable.Columns.Add("soDT");

            foreach (var item in result)
            {
                if (item.Flag_Xoa == false)
                    dataTable.Rows.Add(item.MaKH, item.TenKH, item.DiaChi, item.NgaySinh, item.soDT);
            }

            return dataTable;
        }

        public void Xoa_KH (string MaKH ,ref string comm)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            if (Check_KH_DangMuon(MaKH))
            {
                comm = "Khách hàng đang mượn sách, không thể xóa";
                return;
            }
            comm = "Khách hàng đã bị xóa thành công";

            var result = (from p in qlnsentity.KhachHangs
                          where p.MaKH == MaKH
                          select p).SingleOrDefault();

            result.FlagXoa = true;

            qlnsentity.SaveChanges();
        }
        
        bool Check_KH_DangMuon (string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.Muons
                          where p.MaKH == MaKH
                          select p);

            if (result != null)
            {
                foreach(var item in result)
                {
                    if (item.DangMuon == true)
                        return true;
                }
                return false;
            }

            return false;
        }

    
    }
    
}
