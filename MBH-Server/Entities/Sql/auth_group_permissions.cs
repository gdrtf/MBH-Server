namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auth_group_permissions
    {
        public long id { get; set; }

        public long group_id { get; set; }

        public long permission_id { get; set; }

        public virtual auth_group auth_group { get; set; }

        public virtual auth_permission auth_permission { get; set; }
    }
}
