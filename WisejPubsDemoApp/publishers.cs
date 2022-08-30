namespace WisejWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class publishers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public publishers()
        {
            employee = new HashSet<employee>();
            titles = new HashSet<titles>();
        }

        [Key]
        [StringLength(4)]
        public string pub_id { get; set; }

        [StringLength(40)]
        public string pub_name { get; set; }

        [StringLength(20)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(30)]
        public string country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employee { get; set; }

        public virtual pub_info pub_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<titles> titles { get; set; }
    }
}
