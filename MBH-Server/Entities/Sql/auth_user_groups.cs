namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auth_user_groups
    {
        public long id { get; set; }

        public long user_id { get; set; }

        public long group_id { get; set; }

        public virtual auth_group auth_group { get; set; }

        public virtual auth_user auth_user { get; set; }
    }
}
