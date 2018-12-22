namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teams_team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public teams_team()
        {
            competitions_competition_teams = new HashSet<competitions_competition_teams>();
            games_game = new HashSet<games_game>();
            games_game1 = new HashSet<games_game>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(32)]
        public string soccerpunter_name { get; set; }

        [Required]
        [StringLength(32)]
        public string equipe_id { get; set; }

        public long espn_id { get; set; }

        [Required]
        [StringLength(32)]
        public string long_name { get; set; }

        [Required]
        [StringLength(32)]
        public string oddsway_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<competitions_competition_teams> competitions_competition_teams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<games_game> games_game { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<games_game> games_game1 { get; set; }
    }
}
