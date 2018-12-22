namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class django_admin_log
    {
        public long id { get; set; }

        [StringLength(2147483647)]
        public string object_id { get; set; }

        [Required]
        [StringLength(200)]
        public string object_repr { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string change_message { get; set; }

        public long? content_type_id { get; set; }

        public long user_id { get; set; }

        public DateTime action_time { get; set; }

        public virtual auth_user auth_user { get; set; }

        public virtual django_content_type django_content_type { get; set; }
    }
}
