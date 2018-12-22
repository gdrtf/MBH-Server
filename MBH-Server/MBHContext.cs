namespace MBH_Server {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MBHContext : DbContext {
        public MBHContext()
            : base("name=MBHContext") {
        }

        public virtual DbSet<auth_group> auth_group { get; set; }
        public virtual DbSet<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual DbSet<auth_permission> auth_permission { get; set; }
        public virtual DbSet<auth_user> auth_user { get; set; }
        public virtual DbSet<auth_user_groups> auth_user_groups { get; set; }
        public virtual DbSet<auth_user_user_permissions> auth_user_user_permissions { get; set; }
        public virtual DbSet<bookmakers_bookmaker> bookmakers_bookmaker { get; set; }
        public virtual DbSet<competitions_competition> competitions_competition { get; set; }
        public virtual DbSet<competitions_competition_teams> competitions_competition_teams { get; set; }
        public virtual DbSet<countries_country> countries_country { get; set; }
        public virtual DbSet<django_admin_log> django_admin_log { get; set; }
        public virtual DbSet<django_content_type> django_content_type { get; set; }
        public virtual DbSet<django_migrations> django_migrations { get; set; }
        public virtual DbSet<django_session> django_session { get; set; }
        public virtual DbSet<games_game> games_game { get; set; }
        public virtual DbSet<leagues_league> leagues_league { get; set; }
        public virtual DbSet<odds_odd> odds_odd { get; set; }
        public virtual DbSet<teams_team> teams_team { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<auth_group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<auth_group>()
                .HasMany(e => e.auth_group_permissions)
                .WithRequired(e => e.auth_group)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_group>()
                .HasMany(e => e.auth_user_groups)
                .WithRequired(e => e.auth_group)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_permission>()
                .Property(e => e.codename)
                .IsUnicode(false);

            modelBuilder.Entity<auth_permission>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<auth_permission>()
                .HasMany(e => e.auth_group_permissions)
                .WithRequired(e => e.auth_permission)
                .HasForeignKey(e => e.permission_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_permission>()
                .HasMany(e => e.auth_user_user_permissions)
                .WithRequired(e => e.auth_permission)
                .HasForeignKey(e => e.permission_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<auth_user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<auth_user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<auth_user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<auth_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<auth_user>()
                .HasMany(e => e.auth_user_groups)
                .WithRequired(e => e.auth_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_user>()
                .HasMany(e => e.auth_user_user_permissions)
                .WithRequired(e => e.auth_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auth_user>()
                .HasMany(e => e.django_admin_log)
                .WithRequired(e => e.auth_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<bookmakers_bookmaker>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<bookmakers_bookmaker>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<bookmakers_bookmaker>()
                .Property(e => e.oddsway_name)
                .IsUnicode(false);

            modelBuilder.Entity<bookmakers_bookmaker>()
                .HasMany(e => e.odds_odd)
                .WithRequired(e => e.bookmakers_bookmaker)
                .HasForeignKey(e => e.bookmaker_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<competitions_competition>()
                .Property(e => e.season)
                .IsUnicode(false);

            modelBuilder.Entity<competitions_competition>()
                .HasMany(e => e.competitions_competition_teams)
                .WithRequired(e => e.competitions_competition)
                .HasForeignKey(e => e.competition_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<competitions_competition>()
                .HasMany(e => e.games_game)
                .WithRequired(e => e.competitions_competition)
                .HasForeignKey(e => e.competition_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<countries_country>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<countries_country>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<countries_country>()
                .HasMany(e => e.competitions_competition)
                .WithRequired(e => e.countries_country)
                .HasForeignKey(e => e.country_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<django_admin_log>()
                .Property(e => e.object_repr)
                .IsUnicode(false);

            modelBuilder.Entity<django_content_type>()
                .Property(e => e.app_label)
                .IsUnicode(false);

            modelBuilder.Entity<django_content_type>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<django_content_type>()
                .HasMany(e => e.auth_permission)
                .WithRequired(e => e.django_content_type)
                .HasForeignKey(e => e.content_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<django_content_type>()
                .HasMany(e => e.django_admin_log)
                .WithOptional(e => e.django_content_type)
                .HasForeignKey(e => e.content_type_id);

            modelBuilder.Entity<django_migrations>()
                .Property(e => e.app)
                .IsUnicode(false);

            modelBuilder.Entity<django_migrations>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<django_session>()
                .Property(e => e.session_key)
                .IsUnicode(false);

            modelBuilder.Entity<games_game>()
                .Property(e => e.away_goal)
                .IsUnicode(false);

            modelBuilder.Entity<games_game>()
                .Property(e => e.home_goal)
                .IsUnicode(false);

            modelBuilder.Entity<games_game>()
                .Property(e => e.nearest_games_str)
                .IsUnicode(false);

            modelBuilder.Entity<games_game>()
                .Property(e => e.nearest_games_distance_str)
                .IsUnicode(false);

            modelBuilder.Entity<games_game>()
                .HasMany(e => e.odds_odd)
                .WithRequired(e => e.games_game)
                .HasForeignKey(e => e.game_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<leagues_league>()
                .Property(e => e.long_name)
                .IsUnicode(false);

            modelBuilder.Entity<leagues_league>()
                .Property(e => e.soccerpunter_name)
                .IsUnicode(false);

            modelBuilder.Entity<leagues_league>()
                .Property(e => e.oddsway_name)
                .IsUnicode(false);

            modelBuilder.Entity<leagues_league>()
                .HasMany(e => e.competitions_competition)
                .WithRequired(e => e.leagues_league)
                .HasForeignKey(e => e.league_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<odds_odd>()
                .Property(e => e.outcome)
                .IsUnicode(false);

            modelBuilder.Entity<teams_team>()
                .Property(e => e.soccerpunter_name)
                .IsUnicode(false);

            modelBuilder.Entity<teams_team>()
                .Property(e => e.equipe_id)
                .IsUnicode(false);

            modelBuilder.Entity<teams_team>()
                .Property(e => e.long_name)
                .IsUnicode(false);

            modelBuilder.Entity<teams_team>()
                .Property(e => e.oddsway_name)
                .IsUnicode(false);

            modelBuilder.Entity<teams_team>()
                .HasMany(e => e.competitions_competition_teams)
                .WithRequired(e => e.teams_team)
                .HasForeignKey(e => e.team_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<teams_team>()
                .HasMany(e => e.games_game)
                .WithRequired(e => e.teams_team)
                .HasForeignKey(e => e.home_team_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<teams_team>()
                .HasMany(e => e.games_game1)
                .WithRequired(e => e.teams_team1)
                .HasForeignKey(e => e.away_team_id)
                .WillCascadeOnDelete(false);
        }
    }
}
