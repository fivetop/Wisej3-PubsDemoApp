namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pub_info
    {
        [Key]
        [StringLength(4)]
        public string pub_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] logo { get; set; }

        [Column(TypeName = "text")]
        public string pr_info { get; set; }

        public virtual publishers publishers { get; set; }
    }
}
