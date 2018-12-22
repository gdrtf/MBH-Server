using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBH_Server.Models {
    public class GameModel {
        public string Date { get; set; }
        public TeamModel HomeTeam { get; set; }
        public TeamModel AwayTeam { get; set; }
        public string Season { get; set; }
        public string Stage { get; set; }
        public string League { get; set; }
        public int HomeWP { get; set; }
        public int AwayWP { get; set; }
    }
}