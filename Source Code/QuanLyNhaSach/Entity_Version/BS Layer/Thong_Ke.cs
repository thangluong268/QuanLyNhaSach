using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Version.DB_Layer;
using System.Data;

namespace EntityFramework_Version.BS_Layer
{
    internal class Thong_Ke
    {

        public DataTable Thong_Ke_SL_Sach_Tren_Moi_Dau_Sach()
        {


            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_dau_sach = from p in qlnsentity.CuonSaches
                                  where p.FlagXoa == false
                                  group p by p.DauSach into s
                                  select new
                                  {
                                      MaSach = s.Key.MaSach,
                                      TuaSach = s.Key.TuaSach,
                                      SL = s.Count()
                                  };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("SoLuong");

            foreach (var item in result_dau_sach)
            {
                dataTable.Rows.Add(item.MaSach, item.TuaSach, item.SL);
            }

            return dataTable;
        }

        public (DataTable, int, int, int) TK_Hoat_Dong_Mua_Ban(string Lua_Chon_Thong_Ke, DateTime Thoi_Gian_Bat_Dau)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            DataTable dataTable = new DataTable();
            int tong_tien_ban_duoc = 0;
            int tong_tien_cho_muon = 0;
            int tong_tien_phat = 0;


            if (Lua_Chon_Thong_Ke == "Month")
            {


                var result_muon = from j in (from k in from p in qlnsentity.Muas
                                                       where p.DaThanhToan == true && p.NgayMua > Thoi_Gian_Bat_Dau
                                                       select p
                                             group k by k.NgayMua.Value.Month into a
                                             select new
                                             {
                                                 Thang = a.Key,
                                                 GiaMua = a.Sum(x => x.CuonSach.DauSach.GiaMua)
                                             })
                                  join e in (from k in from p in qlnsentity.Muons
                                                       where p.DaThanhToan == true && p.NgayMuon > Thoi_Gian_Bat_Dau
                                                       select p
                                             group k by k.NgayMuon.Value.Month into a
                                             select new
                                             {
                                                 Thang = a.Key,
                                                 GiaMuon = a.Sum(x => x.CuonSach.DauSach.GiaMuon),
                                                 TienPhat = a.Sum(x => x.TienPhat)
                                             }) on j.Thang equals e.Thang into temp
                                  from e in temp.DefaultIfEmpty()
                                  select new
                                  {


                                      Thang = e.Thang != null ? e.Thang : j.Thang,
                                      GiaMuon = e.GiaMuon != null ? e.GiaMuon : 0,
                                      TienPhat = e.TienPhat != null ? e.TienPhat : 0,
                                      GiaMua = j.GiaMua != null ? j.GiaMua : 0
                                  };
                dataTable.Columns.Add(Lua_Chon_Thong_Ke);
                dataTable.Columns.Add("SoTienChoMuon");
                dataTable.Columns.Add("SoTienPhat");
                dataTable.Columns.Add("SoTienBan");


                foreach (var muon in result_muon)
                {
                    dataTable.Rows.Add(muon.Thang, muon.GiaMuon, muon.TienPhat, muon.GiaMua);
                }

                int r = dataTable.Rows.Count;

                for (int i = 0; i < r; i++)
                {
                    tong_tien_ban_duoc += Convert.ToInt32(dataTable.Rows[i][3]);
                    tong_tien_cho_muon += Convert.ToInt32(dataTable.Rows[i][1]);
                    tong_tien_phat += Convert.ToInt32(dataTable.Rows[i][2]);
                }

            }
            else if (Lua_Chon_Thong_Ke == "Year")
            {
                var result_muon = from j in (from k in from p in qlnsentity.Muas
                                                       where p.DaThanhToan == true && p.NgayMua > Thoi_Gian_Bat_Dau
                                                       select p
                                             group k by k.NgayMua.Value.Year into a
                                             select new
                                             {
                                                 Thang = a.Key,
                                                 GiaMua = a.Sum(x => x.CuonSach.DauSach.GiaMua)
                                             })
                                  join e in (from k in from p in qlnsentity.Muons
                                                       where p.DaThanhToan == true && p.NgayMuon > Thoi_Gian_Bat_Dau
                                                       select p
                                             group k by k.NgayMuon.Value.Year into a
                                             select new
                                             {
                                                 Thang = a.Key,
                                                 GiaMuon = a.Sum(x => x.CuonSach.DauSach.GiaMuon),
                                                 TienPhat = a.Sum(x => x.TienPhat)
                                             }) on j.Thang equals e.Thang into temp
                                  from e in temp.DefaultIfEmpty()
                                  select new
                                  {


                                      Thang = e.Thang != null ? e.Thang : j.Thang,
                                      GiaMuon = e.GiaMuon != null ? e.GiaMuon : 0,
                                      TienPhat = e.TienPhat != null ? e.TienPhat : 0,
                                      GiaMua = j.GiaMua != null ? j.GiaMua : 0
                                  };
                dataTable.Columns.Add(Lua_Chon_Thong_Ke);
                dataTable.Columns.Add("SoTienChoMuon");
                dataTable.Columns.Add("SoTienPhat");
                dataTable.Columns.Add("SoTienBan");


                foreach (var muon in result_muon)
                {
                    dataTable.Rows.Add(muon.Thang, muon.GiaMuon, muon.TienPhat, muon.GiaMua);
                }

                int r = dataTable.Rows.Count;

                for (int i = 0; i < r; i++)
                {
                    tong_tien_ban_duoc += Convert.ToInt32(dataTable.Rows[i][3]);
                    tong_tien_cho_muon += Convert.ToInt32(dataTable.Rows[i][1]);
                    tong_tien_phat += Convert.ToInt32(dataTable.Rows[i][2]);
                }

            }
            return (dataTable, tong_tien_cho_muon, tong_tien_phat, tong_tien_ban_duoc);

        }

    }
}
