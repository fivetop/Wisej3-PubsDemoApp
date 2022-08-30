namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("roysched")]
    public partial class roysched
    {
        [Key]
        [StringLength(6)]
        public string title_id { get; set; }

        public int? lorange { get; set; }

        public int? hirange { get; set; }

        public int? royalty { get; set; }

        public virtual titles titles { get; set; }
    }
}
