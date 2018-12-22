using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBH_Server.Models {
    public class TeamModel {
        public string Name { get; set; }
        public string Logo { get; set; }
    }

    public static class TeamModelUtils {
        public static TeamModel GetModel(teams_team team) {
            return new TeamModel {
                Name = team.long_name,
                Logo = $"http://medias.lequipe.fr/logo-football/{ team.equipe_id }/100"
            };
        }
    }
}