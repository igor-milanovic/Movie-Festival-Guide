using MFG.DataAccess.Configurations;
using MFG.DataAccess.DBHelperClasses;
using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess
{
    public class MFGContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=10;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataBaseHelper dbHelper = new DataBaseHelper();
            dbHelper.SetInitialValues(modelBuilder);

            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new FestivalConfiguration());
            modelBuilder.ApplyConfiguration(new HallConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new MovieDirectorConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectionConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new TicketReservationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<City>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Director>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Festival>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Hall>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Location>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Movie>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Place>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Projection>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<Ticket>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<TicketReservation>().HasQueryFilter(x => !(x.DeletedAt != null));
            modelBuilder.Entity<User>().HasQueryFilter(x => !(x.DeletedAt != null));
        }

        public override int SaveChanges()
        {
            foreach (var en in ChangeTracker.Entries())
            {
                if (en.Entity is Entity e)
                {
                    switch (en.State)
                    {
                        case EntityState.Added:
                            e.CreatedAt = DateTime.UtcNow;
                            e.IsActive = true;
                            break;

                        case EntityState.Modified:
                            e.ModifiedAt = DateTime.UtcNow;
                            break;
                    }
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDirector> MovieDirector { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Projection> Projections { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketReservation> TicketReservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UseCaseLog> UseCaseLogs { get; set; }
        public DbSet<RoleUseCase> RoleUseCases { get; set; }
    }
}