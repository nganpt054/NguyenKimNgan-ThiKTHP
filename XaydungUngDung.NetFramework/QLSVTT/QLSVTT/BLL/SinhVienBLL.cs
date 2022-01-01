using QLSVTT.DAL;
using QLSVTT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVTT.BLL
{
    internal class SinhVienBLL
    {
        public static List<SinhVien> GetList(String TenSV)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.SinhViens.Where(e => e.TenSV == TenSV).ToList();
            return ls;
        }

        public static List<SinhvienViewModel> GetListViewModel()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.SinhViens.Select(e => new SinhvienViewModel
            {
                MaSV = e.MaSV,
                TenSV = e.TenSV,
                NoiSinh = e.NoiSinh,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
                Email = e.Email
                
            }).ToList();
            return ls;
        }

        public static bool Delete (String tenSV)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var sinhVien = model.SinhViens.Where(e => e.TenSV == tenSV).FirstOrDefault();
            model.SinhViens.Remove(sinhVien);
            model.SaveChanges();
            return true;
        }
    }
}
