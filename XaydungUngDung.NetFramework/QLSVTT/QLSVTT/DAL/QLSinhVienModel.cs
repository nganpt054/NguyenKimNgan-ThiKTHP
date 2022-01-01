using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVTT.DAL
{
    public class QLSinhVienModel : DbContext
    {
        public QLSinhVienModel()
            : base("name=model1")
        {
        }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
