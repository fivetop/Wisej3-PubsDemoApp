namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("titleview")]
    public partial class titleview
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(80)]
        public string title { get; set; }

        public byte? au_ord { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string au_lname { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public int? ytd_sales { get; set; }

        [StringLength(4)]
        public string pub_id { get; set; }
    }
}
