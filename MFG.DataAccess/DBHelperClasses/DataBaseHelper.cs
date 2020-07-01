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
                    Name = "user"
                },
                new Role
                {
                    Id = 2,
                    Name = "seller"
                },
                new Role
                {
                    Id = 3,
                    Name = "admin"
                }
            };

            List<RoleUseCase> ruc = new List<RoleUseCase>

            {
                new RoleUseCase
                {
                    Id=1,
                    RoleId= 1 ,
                    UseCaseId= 1101
                },
                new RoleUseCase
                {
                    Id=2,
                    RoleId= 1 ,
                    UseCaseId= 1102
                },
                new RoleUseCase
                {
                    Id=3,
                    RoleId= 1 ,
                    UseCaseId= 1103
                },
                new RoleUseCase
                {
                    Id=4,
                    RoleId= 1 ,
                    UseCaseId= 2102
                },
                new RoleUseCase
                {
                    Id=5,
                    RoleId= 1 ,
                    UseCaseId= 1113
                },
                new RoleUseCase
                {
                    Id=6,
                    RoleId= 1 ,
                    UseCaseId= 222
                },

                new RoleUseCase
                {
                    Id=7,
                    RoleId= 1 ,
                    UseCaseId= 221
                },
                new RoleUseCase
                {
                    Id=8,
                    RoleId= 1 ,
                    UseCaseId= 232
                },
                new RoleUseCase
                {
                    Id=9,
                    RoleId= 1 ,
                    UseCaseId= 231
                },
                new RoleUseCase
                {
                    Id=10,
                    RoleId= 1 ,
                    UseCaseId= 262
                },
                new RoleUseCase
                {
                    Id=11,
                    RoleId= 1 ,
                    UseCaseId= 261
                },
                new RoleUseCase
                {
                    Id=12,
                    RoleId= 1 ,
                    UseCaseId= 282
                },
                new RoleUseCase
                {
                    Id=13,
                    RoleId= 1 ,
                    UseCaseId= 281
                },
                new RoleUseCase
                {
                    Id=14,
                    RoleId= 1 ,
                    UseCaseId= 292
                },
                new RoleUseCase
                {
                    Id=15,
                    RoleId= 1 ,
                    UseCaseId= 291
                },
                new RoleUseCase
                {
                    Id=16,
                    RoleId= 2 ,
                    UseCaseId= 1104
                },
                new RoleUseCase
                {
                    Id=17,
                    RoleId= 2 ,
                    UseCaseId= 2102
                },
                new RoleUseCase
                {
                    Id=18,
                    RoleId= 2 ,
                    UseCaseId= 1113
                },
                new RoleUseCase
                {
                    Id=19,
                    RoleId= 2 ,
                    UseCaseId= 222
                },

                new RoleUseCase
                {
                    Id=20,
                    RoleId= 2 ,
                    UseCaseId= 221
                },
                new RoleUseCase
                {
                    Id=21,
                    RoleId= 2 ,
                    UseCaseId= 232
                },
                new RoleUseCase
                {
                    Id=22,
                    RoleId= 2 ,
                    UseCaseId= 231
                },
                new RoleUseCase
                {
                    Id=23,
                    RoleId= 2 ,
                    UseCaseId= 262
                },
                new RoleUseCase
                {
                    Id=24,
                    RoleId= 2 ,
                    UseCaseId= 261
                },
                new RoleUseCase
                {
                    Id=25,
                    RoleId= 2 ,
                    UseCaseId= 282
                },
                new RoleUseCase
                {
                    Id=26,
                    RoleId= 2 ,
                    UseCaseId= 281
                },
                new RoleUseCase
                {
                    Id=27,
                    RoleId= 2 ,
                    UseCaseId= 292
                },
                new RoleUseCase
                {
                    Id=28,
                    RoleId= 2 ,
                    UseCaseId= 291
                },
                new RoleUseCase
                {
                    Id=29,
                    RoleId= 3 ,
                    UseCaseId= 222
                },

                new RoleUseCase
                {
                    Id=30,
                    RoleId= 3 ,
                    UseCaseId= 221
                },
                new RoleUseCase
                {
                    Id=31,
                    RoleId= 3 ,
                    UseCaseId= 232
                },
                new RoleUseCase
                {
                    Id=32,
                    RoleId= 3 ,
                    UseCaseId= 231
                },
                new RoleUseCase
                {
                    Id=33,
                    RoleId= 3 ,
                    UseCaseId= 262
                },
                new RoleUseCase
                {
                    Id=34,
                    RoleId= 3 ,
                    UseCaseId= 261
                },
                new RoleUseCase
                {
                    Id=35,
                    RoleId= 3 ,
                    UseCaseId= 282
                },
                new RoleUseCase
                {
                    Id=36,
                    RoleId= 3 ,
                    UseCaseId= 281
                },
                new RoleUseCase
                {
                    Id=37,
                    RoleId= 3 ,
                    UseCaseId= 292
                },
                new RoleUseCase
                {
                    Id=38,
                    RoleId= 3 ,
                    UseCaseId= 291
                },
                new RoleUseCase
                {
                    Id=39,
                    RoleId= 3 ,
                    UseCaseId= 1113
                },
                new RoleUseCase
                {
                    Id=40,
                    RoleId= 3 ,
                    UseCaseId= 1121
                },
                new RoleUseCase
                {
                    Id=41,
                    RoleId= 3 ,
                    UseCaseId= 111
                },
                new RoleUseCase
                {
                    Id=42,
                    RoleId= 3 ,
                    UseCaseId= 112
                },
                new RoleUseCase
                {
                    Id=43,
                    RoleId= 3 ,
                    UseCaseId= 113
                },
                new RoleUseCase
                {
                    Id=44,
                    RoleId= 3 ,
                    UseCaseId= 121
                },
                new RoleUseCase
                {
                    Id=45,
                    RoleId= 3 ,
                    UseCaseId= 122
                },
                new RoleUseCase
                {
                    Id=46,
                    RoleId= 3 ,
                    UseCaseId= 123
                },
                new RoleUseCase
                {
                    Id=47,
                    RoleId= 3 ,
                    UseCaseId= 131
                },
                new RoleUseCase
                {
                    Id=48,
                    RoleId= 3 ,
                    UseCaseId= 132
                },
                new RoleUseCase
                {
                    Id=49,
                    RoleId= 3 ,
                    UseCaseId= 133
                },
                new RoleUseCase
                {
                    Id=50,
                    RoleId= 3 ,
                    UseCaseId= 141
                },
                new RoleUseCase
                {
                    Id=51,
                    RoleId= 3 ,
                    UseCaseId= 142
                },
                new RoleUseCase
                {
                    Id=52,
                    RoleId= 3 ,
                    UseCaseId= 143
                },
                new RoleUseCase
                {
                    Id=53,
                    RoleId= 3 ,
                    UseCaseId= 151
                },
                new RoleUseCase
                {
                    Id=54,
                    RoleId= 3 ,
                    UseCaseId= 152
                },
                new RoleUseCase
                {
                    Id=55,
                    RoleId= 3 ,
                    UseCaseId= 153
                },
                new RoleUseCase
                {
                    Id=56,
                    RoleId= 3 ,
                    UseCaseId= 161
                },
                new RoleUseCase
                {
                    Id=57,
                    RoleId= 3 ,
                    UseCaseId= 162
                },
                new RoleUseCase
                {
                    Id=58,
                    RoleId= 3 ,
                    UseCaseId= 163
                },
                new RoleUseCase
                {
                    Id=59,
                    RoleId= 3 ,
                    UseCaseId= 171
                },
                new RoleUseCase
                {
                    Id=60,
                    RoleId= 3 ,
                    UseCaseId= 172
                },
                new RoleUseCase
                {
                    Id=61,
                    RoleId= 3 ,
                    UseCaseId= 173
                },

                new RoleUseCase
                {
                    Id=62,
                    RoleId= 3 ,
                    UseCaseId= 181
                },
                new RoleUseCase
                {
                    Id=63,
                    RoleId= 3 ,
                    UseCaseId= 182
                },
                new RoleUseCase
                {
                    Id=64,
                    RoleId= 3 ,
                    UseCaseId= 183
                },
                new RoleUseCase
                {
                    Id=65,
                    RoleId= 3 ,
                    UseCaseId= 191
                },
                new RoleUseCase
                {
                    Id=66,
                    RoleId= 3 ,
                    UseCaseId= 192
                },
                new RoleUseCase
                {
                    Id=67,
                    RoleId= 3 ,
                    UseCaseId= 193
                },
                new RoleUseCase
                {
                    Id=68,
                    RoleId= 3 ,
                    UseCaseId= 1112
                },
                new RoleUseCase
                {
                    Id=69,
                    RoleId= 3 ,
                    UseCaseId= 211
                },
                new RoleUseCase
                {
                    Id=70,
                    RoleId= 3 ,
                    UseCaseId= 212
                },
                new RoleUseCase
                {
                    Id=71,
                    RoleId= 3 ,
                    UseCaseId= 242
                },
                new RoleUseCase
                {
                    Id=72,
                    RoleId= 3 ,
                    UseCaseId= 241
                },
                new RoleUseCase
                {
                    Id=73,
                    RoleId= 3 ,
                    UseCaseId= 251
                },
                new RoleUseCase
                {
                    Id=74,
                    RoleId= 3 ,
                    UseCaseId= 252
                },
                new RoleUseCase
                {
                    Id=75,
                    RoleId= 3 ,
                    UseCaseId= 271
                },
                new RoleUseCase
                {
                    Id=76,
                    RoleId= 3 ,
                    UseCaseId= 272
                },
                new RoleUseCase
                {
                    Id=77,
                    RoleId= 3 ,
                    UseCaseId= 2101
                },
                new RoleUseCase
                {
                    Id=78,
                    RoleId= 3 ,
                    UseCaseId= 2102
                },
                new RoleUseCase
                {
                    Id=79,
                    RoleId= 3 ,
                    UseCaseId= 2111
                },
                new RoleUseCase
                {
                    Id=80,
                    RoleId= 3 ,
                    UseCaseId= 2111
                },
                new RoleUseCase
                {
                    Id=81,
                    RoleId= 3 ,
                    UseCaseId= 2121
                }
            };

            List<User> users = new List<User>
            {
                new User
                {
                    Id=1,
                    FirstName="Petar",
                    LastName="Peric",
                    Email="pera@gmail.com",
                    Username="admin",
                    Password="sifra123",
                    RoleID=3,
                    IsActive=true,
                    CreatedAt=DateTime.UtcNow
                },
                 new User
                {
                    Id=2,
                    FirstName="Mitar",
                    LastName="Miric",
                    Email="miki@gmail.com",
                    Username="seller",
                    Password="sifra123",
                    RoleID=2,
                    IsActive=true,
                    CreatedAt=DateTime.UtcNow
                }
            };
            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<Location>().HasData(locations);
            modelBuilder.Entity<Hall>().HasData(halls);
            modelBuilder.Entity<Place>().HasData(places);
            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<RoleUseCase>().HasData(ruc);
            modelBuilder.Entity<User>().HasData(users);
        }
    }
}