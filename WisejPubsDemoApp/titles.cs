namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class titles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public titles()
        {
            sales = new HashSet<sales>();
            titleauthor = new HashSet<titleauthor>();
        }

        [Key]
        [StringLength(6)]
        public string title_id { get; set; }

        [Required]
        [StringLength(80)]
        public string title { get; set; }

        [Required]
        [StringLength(12)]
        public string type { get; set; }

        [StringLength(4)]
        public string pub_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [Column(TypeName = "money")]
        public decimal? advance { get; set; }

        public int? royalty { get; set; }

        public int? ytd_sales { get; set; }

        [StringLength(200)]
        public string notes { get; set; }

        public DateTime pubdate { get; set; }

        public virtual publishers publishers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sales> sales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<titleauthor> titleauthor { get; set; }

        public virtual roysched roysched { get; set; }
    }
}
