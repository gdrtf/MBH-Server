namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class django_migrations
    {
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string app { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public DateTime applied { get; set; }
    }
}
