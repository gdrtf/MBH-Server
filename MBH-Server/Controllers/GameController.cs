using System;
using System.Linq;
using System.Web.Http;
using MBH_Server.Models;

namespace MBH_Server.Controllers {
    public class GameController : ApiController {

        [System.Web.Http.HttpGet]
        public async System.Threading.Tasks.Task<GameModel> Get(int? id) {
            using (var db = new MBHContext()) {
                var game = await db.games_game.FindAsync(id.Value);
                var homeTeam = await db.teams_team.FindAsync(game.home_team_id);
                var awayTeam = await db.teams_team.FindAsync(game.away_team_id);
                var competition = await db.competitions_competition.FindAsync(game.competition_id);
                var league = await db.leagues_league.FindAsync(competition.league_id);
                var elo = GetElo(db, game, game.date);
                var model = new GameModel();
                model.Date = game.date.ToLongDateString();
                model.HomeTeam = TeamModelUtils.GetModel(homeTeam);
                model.AwayTeam = TeamModelUtils.GetModel(awayTeam);
                model.League = league.long_name;
                model.Season = competition.season;
                model.Stage = "Stage " + game.stage;
                model.HomeWP = elo.home;
                model.AwayWP = elo.away;
                return model;
            }
        }

        private struct GameElo {
            public int home;
            public int draw;
            public int away;
        }

        private GameElo GetElo(MBHContext db, games_game game, DateTime date) {
            var lastHomeElo = game.home_elo;
            var lastAwayElo = game.away_elo;
            var q = (lastHomeElo - lastAwayElo) / 400f;
            var p = Math.Pow(10, q);
            var e = 1 / (1 + p);
            double p_home = e;
            double p_draw = 0;
            if (p_home + p_draw > 1) {
                double diff = p_home + p_draw - 1;
                p_home -= diff / 2;
                p_draw -= diff / 2;
            }
            var p_away = 1 - p_home - p_draw;
            Func<double, int> per = o => (int)Math.Round(o * 100, 0);
            var elo = new GameElo {
                home = per(p_home),
                draw = per(p_draw),
                away = per(p_away)
            };
            return elo;
        }
    }
}
