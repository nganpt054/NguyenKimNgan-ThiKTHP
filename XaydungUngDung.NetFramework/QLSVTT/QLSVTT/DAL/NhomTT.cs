namespace QLSVTT.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomTT")]
    public partial class NhomTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomTT()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LichTT { get; set; }

        [StringLength(50)]
        public string MaGV { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
