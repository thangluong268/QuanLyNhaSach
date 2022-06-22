using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFramework_Version.DB_Layer;

namespace EntityFramework_Version.BS_Layer
{
    internal class Login
    {
        public bool Check_Login_IsTrue (string user, string pass, string quyen)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = (from p in qlnsentity.TaiKhoans
                          where p.TenTK == user && p.MatKhau == pass && p.Quyen == quyen
                          select new
                          {
                              tentk = p.TenTK,
                              matkhau = p.MatKhau,
                              chucvu = p.Quyen,
                              FlagXoa = p.FlagXoa
                          });

            if (result.Count() > 0) // Account found
            {
                foreach (var item in result)
                    if (item.FlagXoa == true) // account has been deleted
                    {
                        return false;
                    }
                return true;
            }

            return false;
        }
    }
}
