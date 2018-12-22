namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class odds_odd
    {
        public long id { get; set; }

        [Column(TypeName = "real")]
        public double value { get; set; }

        public DateTime timestamp { get; set; }

        public long bookmaker_id { get; set; }

        public long game_id { get; set; }

        [Required]
        [StringLength(4)]
        public string outcome { get; set; }

        public virtual bookmakers_bookmaker bookmakers_bookmaker { get; set; }

        public virtual games_game games_game { get; set; }
    }
}
