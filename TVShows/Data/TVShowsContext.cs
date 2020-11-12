using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Data
{
    public class TVShowsContext : DbContext
    {
        public TVShowsContext(DbContextOptions<TVShowsContext> options): base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<UserShow> UserShows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany<UserShow>(u => u.UserShows)
                        .WithOne(us => us.User);

            modelBuilder.Entity<Show>()
                        .HasMany<UserShow>(s => s.UserShows)
                        .WithOne(us => us.Show);

            modelBuilder.Entity<UserShow>().HasKey(us => new { us.UserId, us.ShowId });

            var users = new List<User>
            {
                new User{ Id=1, Username="Carson" },
                new User{ Id=2, Username="Meredith" },
                new User{ Id=3, Username="Arthur" },
                new User{ Id=4, Username="Lila" }
            };

            var shows = new List<Show>
            {
                new Show{Id=1,Name="Umbrella Academy", EpisodeLength=60, Synopsis="It's sort of like the fantastic four or X-men" },
                new Show{Id=2,Name="Love is war", EpisodeLength=23.5, Synopsis="They think they're smart but they are basically tsunderes" },
                new Show{Id=3,Name="Fullmetal Alchemist: Brotherhood", EpisodeLength=24, Synopsis="Many would say it's the best show ever made" },
                new Show{Id=4,Name="The Boys", EpisodeLength=58, Synopsis="Superheroes, again" }
            };

            var userShows = new List<UserShow>
            {
                new UserShow{UserId=1, ShowId=1, ShowStatus=Status.Dropped},
                new UserShow{UserId=1, ShowId=2, ShowStatus=Status.Watching},
                new UserShow{UserId=1, ShowId=4, ShowStatus=Status.Watching},
                new UserShow{UserId=2, ShowId=4, ShowStatus=Status.Watching},
                new UserShow{UserId=3, ShowId=2, ShowStatus=Status.PlanToWatch},
                new UserShow{UserId=3, ShowId=3, ShowStatus=Status.Dropped},
                new UserShow{UserId=4, ShowId=1, ShowStatus=Status.Dropped},
                new UserShow{UserId=4, ShowId=2, ShowStatus=Status.PlanToWatch},
                new UserShow{UserId=4, ShowId=4}
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Show>().HasData(shows);
            modelBuilder.Entity<UserShow>().HasData(userShows);
        }
    }
}
