namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [Key]
        [StringLength(9)]
        public string emp_id { get; set; }

        [Required]
        [StringLength(20)]
        public string fname { get; set; }

        [StringLength(1)]
        public string minit { get; set; }

        [Required]
        [StringLength(30)]
        public string lname { get; set; }

        public short job_id { get; set; }

        public byte? job_lvl { get; set; }

        [Required]
        [StringLength(4)]
        public string pub_id { get; set; }

        public DateTime hire_date { get; set; }

        public virtual jobs jobs { get; set; }

        public virtual publishers publishers { get; set; }
    }
}
