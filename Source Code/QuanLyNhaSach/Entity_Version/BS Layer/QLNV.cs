using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class QLNV
    {
        public DataTable Lay_TT_NV ()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.NhanViens
                         select new
                         {
                             MaNV = p.MaNV,
                             TenNV = p.TenNV,
                             CongViec = p.CongViec,
                             Luong = p.Luong,
                             DiaChi = p.DiaChi,
                             NgaySinh = p.NgaySinh,
                             GioiTinh = p.GioiTinh,
                             soDT = p.soDT,
                             TenTK = p.TaiKhoan.TenTK,
                             MatKhau = p.TaiKhoan.MatKhau,
                             FlagXoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaNV");
            dataTable.Columns.Add("TenNV");
            dataTable.Columns.Add("CongViec");
            dataTable.Columns.Add("Luong");
            dataTable.Columns.Add("DiaChi");
            dataTable.Columns.Add("NgaySinh");
            dataTable.Columns.Add("GioiTinh");
            dataTable.Columns.Add("soDT");
            //dataTable.Columns.Add("TenTK");
            //dataTable.Columns.Add("MatKhau");
            //dataTable.Columns.Add("FlagXoa");

            foreach (var item in result)
            {
                if (item.FlagXoa == false)
                    dataTable.Rows.Add(item.MaNV, item.TenNV, item.CongViec, item.Luong, item.DiaChi, item.NgaySinh, item.GioiTinh, item.soDT);
            }

            return dataTable;
    }    

        public void Sua_TT_NV(string MaNV, string HoTen, string CongViec, string Luong, string DiaChi, DateTime NgSinh, bool GioiTinh, string SDT )
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.NhanViens
                          where p.MaNV == MaNV
                          select p).SingleOrDefault();

            result.TenNV = HoTen;
            result.CongViec = CongViec;
            result.Luong = Luong;
            result.DiaChi = DiaChi;
            result.NgaySinh = NgSinh;
            result.GioiTinh = GioiTinh;
            result.soDT = SDT;

            qlnsentity.SaveChanges();
        }

        public void Them_NV (string MaNV, string HoTen, string CongViec, string Luong, string DiaChi, DateTime NgSinh, bool GioiTinh, string SDT, string user, string pass)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            
            NhanVien nhan_vien = new NhanVien();
            nhan_vien.MaNV = MaNV;
            nhan_vien.TenNV = HoTen;
            nhan_vien.CongViec = CongViec;
            nhan_vien.Luong = Luong;
            nhan_vien.DiaChi = DiaChi;
            nhan_vien.NgaySinh = NgSinh;
            nhan_vien.GioiTinh = GioiTinh;
            nhan_vien.soDT = SDT;
            nhan_vien.FlagXoa = false;

            TaiKhoan tk = new TaiKhoan();
            tk.MaNV = MaNV;
            tk.Quyen = "Nhanvien";
            tk.TenTK = user;
            tk.MatKhau = pass;
            tk.FlagXoa = false;

            qlnsentity.NhanViens.Add(nhan_vien);
            qlnsentity.TaiKhoans.Add(tk);

            qlnsentity.SaveChanges();
        }

        public DataTable Tim_NV (string MaNV)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.NhanViens
                         where p.MaNV == MaNV
                         select new
                         {
                             MaNV = p.MaNV,
                             TenNV = p.TenNV,
                             CongViec = p.CongViec,
                             Luong = p.Luong,
                             DiaChi = p.DiaChi,
                             NgaySinh = p.NgaySinh,
                             GioiTinh = p.GioiTinh,
                             soDT = p.soDT,
                             TenTK = p.TaiKhoan.TenTK,
                             MatKhau = p.TaiKhoan.MatKhau,
                             FlagXoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaNV");
            dataTable.Columns.Add("TenNV");
            dataTable.Columns.Add("CongViec");
            dataTable.Columns.Add("Luong");
            dataTable.Columns.Add("DiaChi");
            dataTable.Columns.Add("NgaySinh");
            dataTable.Columns.Add("GioiTinh");
            dataTable.Columns.Add("soDT");
            //dataTable.Columns.Add("TenTK");
            //dataTable.Columns.Add("MatKhau");
            //dataTable.Columns.Add("FlagXoa");

            foreach (var item in result)
            {
                if (item.FlagXoa == false)
                    dataTable.Rows.Add(item.MaNV, item.TenNV, item.CongViec, item.Luong, item.DiaChi, item.NgaySinh, item.GioiTinh, item.soDT);
            }

            return dataTable;
        }

        public void Xoa_NV (string MaNV)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.NhanViens
                          where p.MaNV == MaNV
                          select p).SingleOrDefault();

            result.FlagXoa = true;
            
            qlnsentity.SaveChanges();

            Xoa_Tai_Khoan(MaNV);
        }

        void Xoa_Tai_Khoan(string MaNV)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.TaiKhoans
                        where p.MaNV == MaNV
                        select p).SingleOrDefault();

            result.FlagXoa = true;

            qlnsentity.SaveChanges();
        }
    }
}
