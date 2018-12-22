namespace MBH_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class leagues_league
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public leagues_league()
        {
            competitions_competition = new HashSet<competitions_competition>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(128)]
        public string long_name { get; set; }

        public bool is_cup { get; set; }

        public long level { get; set; }

        public bool is_men { get; set; }

        [Required]
        [StringLength(128)]
        public string soccerpunter_name { get; set; }

        [Required]
        [StringLength(128)]
        public string oddsway_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<competitions_competition> competitions_competition { get; set; }
    }
}
