namespace QLSVTT.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangVien")]
    public partial class GiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangVien()
        {
            NhomTTs = new HashSet<NhomTT>();
        }

        [Key]
        [StringLength(50)]
        public string MaGV { get; set; }

        [StringLength(50)]
        public string TenGV { get; set; }

        [StringLength(50)]
        public string GioiTinhGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinhGV { get; set; }

        [StringLength(50)]
        public string SDTGV { get; set; }

        [StringLength(50)]
        public string EmailGV { get; set; }

        [StringLength(50)]
        public string DiaChiGV { get; set; }

        [StringLength(50)]
        public string MaBM { get; set; }

        public virtual BoMon BoMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhomTT> NhomTTs { get; set; }
    }
}
