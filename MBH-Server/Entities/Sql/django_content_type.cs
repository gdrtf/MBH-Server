namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class django_content_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public django_content_type()
        {
            auth_permission = new HashSet<auth_permission>();
            django_admin_log = new HashSet<django_admin_log>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(100)]
        public string app_label { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auth_permission> auth_permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<django_admin_log> django_admin_log { get; set; }
    }
}
