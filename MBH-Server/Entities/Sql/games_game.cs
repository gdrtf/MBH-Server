namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class games_game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public games_game()
        {
            odds_odd = new HashSet<odds_odd>();
        }

        public long id { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(16)]
        public string away_goal { get; set; }

        public long away_elo { get; set; }

        public long away_team_id { get; set; }

        public long competition_id { get; set; }

        public long home_team_id { get; set; }

        public long? goal_average { get; set; }

        public long goal_average_last_3 { get; set; }

        public long home_elo { get; set; }

        [Required]
        [StringLength(16)]
        public string home_goal { get; set; }

        [Column(TypeName = "real")]
        public double? outcome { get; set; }

        public long stage { get; set; }

        public bool estimator_bet_on_away { get; set; }

        public bool estimator_bet_on_draw { get; set; }

        public bool estimator_bet_on_home { get; set; }

        [Column(TypeName = "real")]
        public double? estimator_odd_away { get; set; }

        [Column(TypeName = "real")]
        public double? estimator_odd_draw { get; set; }

        [Column(TypeName = "real")]
        public double? estimator_odd_home { get; set; }

        [StringLength(256)]
        public string nearest_games_str { get; set; }

        [StringLength(256)]
        public string nearest_games_distance_str { get; set; }

        public virtual competitions_competition competitions_competition { get; set; }

        public virtual teams_team teams_team { get; set; }

        public virtual teams_team teams_team1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odds_odd> odds_odd { get; set; }
    }
}
