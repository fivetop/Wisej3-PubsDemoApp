namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sales
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string stor_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ord_num { get; set; }

        public DateTime ord_date { get; set; }

        public short qty { get; set; }

        [Required]
        [StringLength(12)]
        public string payterms { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string title_id { get; set; }

        public virtual stores stores { get; set; }

        public virtual titles titles { get; set; }
    }
}
