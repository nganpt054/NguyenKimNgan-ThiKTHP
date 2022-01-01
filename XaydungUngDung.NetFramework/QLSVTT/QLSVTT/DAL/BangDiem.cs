namespace QLSVTT.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangDiem")]
    public partial class BangDiem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaSV { get; set; }

        [StringLength(50)]
        public string Diem { get; set; }

        [StringLength(50)]
        public string TenLHTT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LanThucTap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianTT { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
