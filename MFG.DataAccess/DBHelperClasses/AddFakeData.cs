using Bogus;
using MFG;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MFG.DataAccess.DBHelperClasses
{
    public class AddFakeData
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public ICollection<Movie> CreateFakeMovies(int num)
        {
            ICollection<Movie> movies = new HashSet<Movie>();

            for (var i = 0; i < num; i++)
            {
                var fakeMovie = new Faker<Movie>()
               .RuleFor(x => x.Name, f => f.Commerce.ProductName())
               .RuleFor(x => x.Year, f => f.Random.Int(1970, 2020))
               .RuleFor(x => x.Length, f => f.Random.Int(30, 210))
               .RuleFor(x => x.AvgRating, f =>
               {
                   var _ = f.Random.Float() * 10;
                   var m = Math.Round(_, 1);
                   return Convert.ToSingle(m);
               })
               .RuleFor(x => x.CreatedAt, f => DateTime.UtcNow)
               .RuleFor(x => x.IsActive, true);

                movies.Add(fakeMovie);
            }
            return movies;
        }

        public ICollection<Director> CreateFakeDirectors(int num)
        {
            ICollection<Director> directors = new HashSet<Director>();

            for (var i = 0; i < num; i++)
            {
                var fakeDirector = new Faker<Director>()
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.CreatedAt, DateTime.UtcNow)
                    .RuleFor(x => x.IsActive, true);

                directors.Add(fakeDirector);
            }

            return directors;
        }

        private void CreateFakeFestival(ICollection<Festival> festivals, int j)
        {
            //ICollection<Festival> festivals = new HashSet<Festival>();

            String[] names = new string[5] { "Movie festival", "SciFI festival", "Movie gatherings", "Screenfest", "Modern movie festival" };
            String[] start = new string[5] { "27", "12", "18", "1", "23" };
            String[] end = new string[5] { "31", "19", "25", "20", "25" };
            // String[] month = new string[5] { "Jan", "Jun", "Avg", "Oct", "Dec" };
            String[] month = new string[5] { "01", "06", "08", "10", "12" };

            int placeID = 1;

            var tmpGod = 2001;
            //DateTime.Parse("Jan 1, 2009")
            for (var i = 0; i < 5; i++)
            {
                switch (j)
                {
                    case 0:
                        placeID = RandomNumber(1, 4);
                        break;

                    case 1:
                        placeID = RandomNumber(1, 4);
                        break;

                    case 2:
                        placeID = RandomNumber(5, 6);
                        break;

                    case 3:
                        placeID = 7;
                        break;

                    case 4:
                        placeID = 8;
                        break;
                }

                var fakeFest = new Faker<Festival>()
                    .RuleFor(x => x.Name, f => names[j])
                    .RuleFor(x => x.PlaceID, placeID)                   //month[j] + " " + start[j] + ", " + tmpGod)
                    .RuleFor(x => x.StartDate, f => DateTime.Parse(tmpGod + "-" + month[j] + "-" + start[j]))
                    .RuleFor(x => x.EndDate, f => DateTime.Parse(tmpGod + "-" + month[j] + "-" + end[j]))  //month[j] + " " + end[j] + ", " + tmpGod)
                    .RuleFor(x => x.About, f => f.Lorem.Text())
                    .RuleFor(x => x.CreatedAt, DateTime.UtcNow)
                    .RuleFor(x => x.IsActive, true)
                    .RuleFor(x => x.MaxTickets, f => RandomNumber(5, 20));

                festivals.Add(fakeFest);
                tmpGod++;
            }
        }

        public void CreateFakeFestivals(MFGContext context)
        {
            ICollection<Festival> festivals = new HashSet<Festival>();
            for (var i = 0; i < 5; i++)
            {
                CreateFakeFestival(festivals, i);
            }
            context.Festivals.AddRange(festivals);
            context.SaveChanges();
        }

        private void CreateFakeProjection(MFGContext context, int festivalID)
        {
            var hrs = Enumerable.Range(8, 14).ToArray();
            int[] mins = { 0, 30 };

            ICollection<Projection> fakeProjections = new HashSet<Projection>();

            var movieIDs = Enumerable.Range(1, 30).ToArray(); //because i initially added 30 movies

            //             Kad proradi povezivanje moze ovo  umesto onog dole.
            //ICollection<Hall> halls = context.Festivals.Find(festivalID).Place.Location.Halls;

            //-------------------------------------------------- umesto ovoga ---------
            var placeID = context.Festivals.Find(1).PlaceID;

            var locationID = context.Places.Find(placeID).LocationID;

            var halls = context.Halls.Where(x => x.LocationID == locationID).ToList();

            //-------------------------------------------------- umesto ovoga ---------

            var end = context.Festivals.Find(festivalID).EndDate.Day;
            var start = context.Festivals.Find(festivalID).StartDate.Day;
            var month = context.Festivals.Find(festivalID).EndDate.Month;
            var year = context.Festivals.Find(festivalID).EndDate.Year;

            foreach (var ha in halls)
            {
                for (var d = start; d <= end; d++)
                {
                    var numOfMovies = RandomNumber(3, 5);

                    for (var i = 0; i < numOfMovies; i++)
                    {
                        var hr = hrs[RandomNumber(0, hrs.Length - 1)];
                        var mn = mins[RandomNumber(0, 1)];
                        DateTime beginsAt = new DateTime(year, month, d);
                        TimeSpan ts = new TimeSpan(hr, mn, 0);
                        var s2 = beginsAt + ts;

                        var movieID = RandomNumber(1, 50);
                        var movieLength = context.Movies.Find(movieID).Length;

                        var e2 = s2.AddMinutes(movieLength);

                        //    s1  i e1  - pocetak i kraj vec zakazane projekcije
                        //    s2 i e2   -   pocetak i kraj nove projekcije
                        // uslov  :   e2<s1  ||  s2 > e1

                        var x = context.Projections
                            .Where(x => x.FestivalID == festivalID)
                            .Where(x => x.HallID == ha.Id)
                            .Where(
                                x => x.BeginsAt > e2 ||
                                x.EndsAt > s2);

                        if (

                            context.Projections
                            .Where(x => x.FestivalID == festivalID)
                            .Where(x => x.HallID == ha.Id).Count(
                                x => x.BeginsAt > e2 ||
                                x.EndsAt > s2) == 0
                            )
                        {
                            /*   fakeProjections.Add(
                                    new Projection
                                    {
                                        BeginsAt = s2,
                                        Ends = e2,
                                        MovieID = movieID,
                                        HallID = ha.Id,
                                        FestivalID = festivalID,
                                        CreatedAt = DateTime.UtcNow,
                                        IsActive = true
                                    }
                                   );*/

                            context.Projections.Add(
                                 new Projection
                                 {
                                     BeginsAt = s2,
                                     EndsAt = e2,
                                     MovieID = movieID,
                                     HallID = ha.Id,
                                     FestivalID = festivalID,
                                     CreatedAt = DateTime.UtcNow,
                                     IsActive = true
                                 }
                                );
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        public void CreateFakeProjections(MFGContext context)
        {
            var festivals = context.Festivals.ToList();

            foreach (var f in festivals)
            {
                CreateFakeProjection(context, f.Id);
            }
        }

        public void CreateFakeTickets(MFGContext context)
        {
            var projections = context.Projections.ToList();

            foreach (var p in projections)
            {
                context.Tickets.Add(
                    new Ticket
                    {
                        Price = RandomNumber(150, 990),
                        FestivalID = p.FestivalID,
                        ProjectionID = p.Id,
                        CreatedAt = DateTime.UtcNow,
                        IsActive = true
                    }
                );
            }
            context.SaveChanges();
        }

        public void CreateFakeUsers(int numOfUsers, MFGContext context)
        {
            ICollection<User> fakeUsers = new HashSet<User>();
            for (var i = 0; i < numOfUsers; i++)
            {
                var fakeUser = new Faker<User>()
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.Username, f => f.Internet.UserName())
                    .RuleFor(x => x.Email, f => f.Internet.Email())
                    .RuleFor(x => x.Password, f => f.Internet.Password())
                    .RuleFor(x => x.CreatedAt, DateTime.UtcNow)
                    .RuleFor(x => x.IsActive, true)
                    .RuleFor(x => x.RoleID, 1);

                fakeUsers.Add(fakeUser);
            }
            context.Users.AddRange(fakeUsers);
            context.SaveChanges();
        }

        public void CreateFakeTicketResevations(MFGContext context)
        {
            ICollection<TicketReservation> ticketReservations = new HashSet<TicketReservation>();

            var users = context.Users.Where(x => x.RoleID == 1).ToList();

            int[] projectionIDs = context.Projections.Select(x => x.Id).ToArray();
            foreach (var u in users)
            {
                var numOfReservations = RandomNumber(0, 15);

                for (var i = 0; i < numOfReservations; i++)
                {
                    var projectionID = projectionIDs[RandomNumber(0, projectionIDs.Length - 1)];

                    Ticket ticket = context.Tickets.Where(x => x.ProjectionID == projectionID).FirstOrDefault();

                    var maxNumOfTickets = context.Festivals.Where(x => ticket.FestivalID == x.Id).FirstOrDefault().MaxTickets;
                    var quantity = RandomNumber(1, maxNumOfTickets);
                    var totalPrice = quantity * ticket.Price;
                    var code = GenerateReservationCode(10);
                    ticketReservations.Add(
                        new TicketReservation
                        {
                            UserID = u.Id,
                            TicketID = ticket.Id,
                            Quantity = quantity,
                            TotalPrice = totalPrice,
                            ReservationDate = DateTime.UtcNow,
                            ReservationCode = code
                        }
                        ); ;
                }

                context.TicketReservations.AddRange(ticketReservations);
            }
            context.SaveChanges();
        }

        public string GenerateReservationCode(int length = 10)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnoprstuwyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#@$%^&*.~";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void SetInitialValuesMovie(MFGContext context)
        {
            var fakeDataMaker = new AddFakeData();

            var fakeMovies = fakeDataMaker.CreateFakeMovies(50);

            var fakeDirectors = fakeDataMaker.CreateFakeDirectors(150).ToList();

            foreach (var m in fakeMovies)
            {
                var numOfDierctors = fakeDataMaker.RandomNumber(1, 2);

                for (var i = 0; i < numOfDierctors; i++)
                {
                    var _ = fakeDataMaker.RandomNumber(0, 59);
                    m.MovieDirectors.Add(
                        new MovieDirector
                        {
                            Director = fakeDirectors[_]
                        });
                }
            }

            context.Movies.AddRange(fakeMovies);
            context.SaveChanges();
        }

        public void GenerateAllFakeData(MFGContext context)
        {
            // automatsko dodavanje Movie, Director, MovieDirector
            SetInitialValuesMovie(context);

            // Dodavanje Fake Festivala
            CreateFakeFestivals(context);

            //Dodavanje projekcija

            CreateFakeProjections(context);

            // dodavanje fake tickets-a

            CreateFakeTickets(context);

            // Dodavanje Fake Usera
            CreateFakeUsers(15, context);

            //  Dodavanje fake Ticket Reservationa

            CreateFakeTicketResevations(context);
        }
    }
}