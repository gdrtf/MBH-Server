namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class competitions_competition_teams
    {
        public long id { get; set; }

        public long competition_id { get; set; }

        public long team_id { get; set; }

        public virtual competitions_competition competitions_competition { get; set; }

        public virtual teams_team teams_team { get; set; }
    }
}
