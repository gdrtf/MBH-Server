namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class django_session
    {
        [Key]
        [StringLength(40)]
        public string session_key { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string session_data { get; set; }

        public DateTime expire_date { get; set; }
    }
}
