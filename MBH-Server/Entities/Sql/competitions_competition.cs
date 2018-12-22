namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class competitions_competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public competitions_competition()
        {
            competitions_competition_teams = new HashSet<competitions_competition_teams>();
            games_game = new HashSet<games_game>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(32)]
        public string season { get; set; }

        public long league_id { get; set; }

        public long country_id { get; set; }

        public virtual countries_country countries_country { get; set; }

        public virtual leagues_league leagues_league { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<competitions_competition_teams> competitions_competition_teams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<games_game> games_game { get; set; }
    }
}
