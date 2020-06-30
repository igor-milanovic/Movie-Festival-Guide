using Bogus;
using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.DataAccess.DBHelperClasses
{
    public class DataBaseHelper
    {
        public void SetInitialValues(ModelBuilder modelBuilder)
        {
            var cities = new List<City>
            {
                new City
                {
                    Id=1,
                    Name="Beograd",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new City
                {
                    Id=2,
                    Name="Novi Sad",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new City
                {
                    Id=3,
                    Name="Niš",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new City
                {
                    Id=4,
                    Name="Vrnjačka banja",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                }
            };

            var locations = new List<Location>
            {
                new Location
                {
                    Id=1,
                    CityID=1,
                    Name="Sava Centar",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Location
                {
                    Id=2,
                    CityID=1,
                    Name="Dom sindikata",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Location
                {
                    Id=3,
                    CityID=1,
                    Name="Dom omladine",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Location
                {
                    Id=4,
                    CityID=1,
                    Name="Centar za kulturu Vlada Divljan",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Location
                {
                    Id=5,
                    CityID=4,
                    Name="Bioskop"
                },
               new Location
                {
                    Id=6,
                    CityID=4,
                    Name="Letnja pozornica",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
               new Location
                {
                    Id=7,
                    CityID=2,
                    Name="Kulturni centar Novog Sada",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
               new Location
                {
                    Id=8,
                    CityID=3,
                    Name="Niški kulturni centar",
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
            };

            var halls = new List<Hall> {
                new Hall
                    {
                        Id=1,
                        Name="Sala 1",
                        LocationID=1,
                        NumberOfSeats=412,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                    {
                        Id=2,
                        Name="Aneks A",
                        LocationID=1,
                        NumberOfSeats=198,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                    {
                        Id=3,
                        Name="Aneks B",
                        LocationID=1,
                        NumberOfSeats=198,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                    {
                        Id=4,
                        Name="Japanski salon",
                        LocationID=1,
                        NumberOfSeats=140,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                    {
                        Id=5,
                        Name="Velika dvorana",
                        LocationID=1,
                        NumberOfSeats=3672,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                    {
                        Id=6,
                        Name="Amfiteatar",
                        LocationID=1,
                        NumberOfSeats=454,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                    },
                new Hall
                        {
                        Id=7,
                        Name="Sala 1",
                        LocationID=2,
                        NumberOfSeats=1382,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=8,
                        Name="Sala 2",
                        LocationID=2,
                        NumberOfSeats=78,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=9,
                        Name="Sala 3",
                        LocationID=2,
                        NumberOfSeats=72,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=10,
                        Name="Velika sala",
                        LocationID=3,
                        NumberOfSeats=483,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=11,
                        Name="Sala amerikana",
                        LocationID=3,
                        NumberOfSeats=200,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=12,
                        Name="Sala 1",
                        LocationID=4,
                        NumberOfSeats=78,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=13,
                        Name="Sala 2",
                        LocationID=4,
                        NumberOfSeats=298,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=14,
                        Name="Sala 1",
                        LocationID=5,
                        NumberOfSeats=125,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=15,
                        Name="Sala 2",
                        LocationID=5,
                        NumberOfSeats=278,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=16,
                        Name="Letnja pozornica",
                        LocationID=6,
                        NumberOfSeats=370,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=17,
                        Name="Sala 1",
                        LocationID=7,
                        NumberOfSeats=158,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=18,
                        Name="Sala 2",
                        LocationID=7,
                        NumberOfSeats=326,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=19,
                        Name="Velika sala",
                        LocationID=7,
                        NumberOfSeats=1580,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                        {
                        Id=20,
                        Name="Sala 1",
                        LocationID=8,
                        NumberOfSeats=324,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                         },
                new Hall
                    {
                    Id=21,
                    Name="Sala 2",
                    LocationID=8,
                    NumberOfSeats=279,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                     }
            };

            var places = new List<Place>
            {
                new Place
                {
                    Id=1,
                    CityID=1,
                    LocationID=1,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Place
                {
                    Id=2,
                    CityID=1,
                    LocationID=2,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Place
                {
                    Id=3,
                    CityID=1,
                    LocationID=3,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Place
                {
                    Id=4,
                    CityID=1,
                    LocationID=4,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },

                new Place
                {
                    Id=5,
                    CityID=4,
                    LocationID=5,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },

                new Place
                {
                    Id=6,
                    CityID=4,
                    LocationID=6,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Place
                {
                    Id=7,
                    CityID=2,
                    LocationID=7,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
                new Place
                {
                    Id=8,
                    CityID=3,
                    LocationID=8,
                    CreatedAt=DateTime.UtcNow,
                    IsActive=true
                },
            };
            List<Role> roles = new List<Role>

            {
                new Role
                {
                    Id=1,
                    Name = "admin"
                },
                new Role
                {
                    Id = 2,
                    Name = "seller"
                },
                new Role
                {
                    Id = 3,
                    Name = "user"
                }
            };

            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<Location>().HasData(locations);
            modelBuilder.Entity<Hall>().HasData(halls);
            modelBuilder.Entity<Place>().HasData(places);
            modelBuilder.Entity<Role>().HasData(roles);
        }
    }
}