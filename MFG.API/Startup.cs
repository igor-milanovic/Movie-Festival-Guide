using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MFG.API.Core;
using MFG.Application;
using MFG.Application.Commands.AdminCommands;
using MFG.Application.Commands.CityCommands;
using MFG.Application.Commands.DirectorCommands;
using MFG.Application.Commands.FestivalCommands;
using MFG.Application.Commands.HallCommands;
using MFG.Application.Commands.LocationCommands;
using MFG.Application.Commands.MovieCommands;
using MFG.Application.Commands.PlaceCommands;
using MFG.Application.Commands.ProjectionCommands;
using MFG.Application.Commands.TicketCommands;
using MFG.Application.Commands.TicketReservationCommands;
using MFG.Application.Commands.UserCommands;
using MFG.Application.Queries;
using MFG.DataAccess;
using MFG.Implementation.Commands.AdminCommands;
using MFG.Implementation.Commands.CityCommands;
using MFG.Implementation.Commands.DirectorCommands;
using MFG.Implementation.Commands.FestivalCommands;
using MFG.Implementation.Commands.HallCommands;
using MFG.Implementation.Commands.LocationCommands;
using MFG.Implementation.Commands.MovieCommands;
using MFG.Implementation.Commands.PlaceCommands;
using MFG.Implementation.Commands.ProjectionCommand;
using MFG.Implementation.Commands.TicketCommands;
using MFG.Implementation.Commands.TicketReservationCommands;
using MFG.Implementation.Commands.UserCommands;
using MFG.Implementation.Logging;
using MFG.Implementation.Queries;
using MFG.Implementation.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MFG.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAutoMapper(typeof(ConsoleUseCaseLogger).Assembly);

            services.AddTransient<IApplicationActor, FakeActor>();
            services.AddTransient<IUseCaseLogger, ConsoleUseCaseLogger>();

            services.AddTransient<ICreateCityCommand, CreateCityCommand>();
            services.AddTransient<IDeleteCityCommand, DeleteCityCommand>();
            services.AddTransient<IEditCityCommand, EditCityCommand>();
            services.AddTransient<IGetCitiesQuery, GetCitiesQuery>();

            services.AddTransient<ICreateDirectorCommand, CreateDirectorCommand>();
            services.AddTransient<IDeleteDirectorCommand, DeleteDirectorCommand>();
            services.AddTransient<IEditDirectorCommand, EditDirectorCommand>();
            services.AddTransient<IGetDirectorsQuery, GetDirectorsQuery>();

            services.AddTransient<ICreateFestivalCommand, CreateFestivalCommand>();
            services.AddTransient<IDeleteFestivalCommand, DeleteFestivalCommand>();
            services.AddTransient<IEditFestivalCommand, EditFestivalCommand>();
            services.AddTransient<IGetFestivalsQuery, GetFestivalsQuery>();

            services.AddTransient<ICreateHallCommand, CreateHallCommand>();
            services.AddTransient<IDeleteHallCommand, DeleteHallCommand>();
            services.AddTransient<IEditHallCommand, EditHallCommand>();
            services.AddTransient<IGetHallsQuery, GetHallsQuery>();

            services.AddTransient<ICreateLocationCommand, CreateLocationCommand>();
            services.AddTransient<IDeleteLocationCommand, DeleteLocationCommand>();
            services.AddTransient<IEditLocationCommand, EditLocationCommand>();
            services.AddTransient<IGetLocationsQuery, GetLocationsQuery>();

            services.AddTransient<ICreateMovieCommand, CreateMovieCommand>();
            services.AddTransient<IDeleteMovieCommand, DeleteMovieCommand>();
            services.AddTransient<IEditMovieCommand, EditMovieCommand>();
            services.AddTransient<IGetMoviesQuery, GetMoviesQuery>();

            services.AddTransient<ICreatePlaceCommand, CreatePlaceCommand>();
            services.AddTransient<IDeletePlaceCommand, DeletePlaceCommand>();
            services.AddTransient<IEditPlaceCommand, EditPlaceCommand>();
            services.AddTransient<IGetPlacesQuery, GetPlacesQuery>();

            services.AddTransient<ICreateProjectionCommand, CreateProjectionCommand>();
            services.AddTransient<IDeleteProjectionCommand, DeleteProjectionCommand>();
            services.AddTransient<IEditProjectionCommand, EditProjectionCommand>();
            services.AddTransient<IGetProjectionsQuery, GetProjectionsQuery>();

            services.AddTransient<ICreateTicketCommand, CreateTicketCommand>();
            services.AddTransient<IDeleteTicketCommand, DeleteTicketCommand>();
            services.AddTransient<IEditTicketCommand, EditTicketCommand>();
            services.AddTransient<IGetTicketsQuery, GetTicketsQuery>();

            services.AddTransient<ICreateTicketReservationCommand, CreateTicketReservationCommand>();
            services.AddTransient<IDeleteTicketReservationCommand, DeleteTicketReservationCommand>();
            services.AddTransient<IEditTicketReservationCommand, EditTicketReservationCommand>();
            services.AddTransient<IPickTicketReservationCommand, PickTicketReservationCommand>();
            services.AddTransient<IGetTicketReservationsQuery, GetTicketReservationQuery>();

            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
            services.AddTransient<IEditUserCommand, EditUserCommand>();
            services.AddTransient<IChangeUserRoleCommand, ChangeUserRoleCommand>();
            services.AddTransient<IGetUsersQuery, GetUsersQuery>();

            services.AddTransient<MFGContext>();
            services.AddTransient<UseCaseExecutor>();

            services.AddTransient<CityValidator>();
            services.AddTransient<EditCityValidator>();

            services.AddTransient<DirectorValidator>();

            services.AddTransient<FestivalValidator>();
            services.AddTransient<EditFestivalValidator>();

            services.AddTransient<HallValidator>();
            services.AddTransient<LocationValidator>();
            services.AddTransient<MovieValidator>();
            services.AddTransient<PlaceValidator>();
            services.AddTransient<ProjectionValidator>();

            services.AddTransient<TicketReservationValidator>();
            services.AddTransient<BuyTicketReservationValidator>();

            services.AddTransient<TicketValidator>();

            services.AddTransient<UserValidator>();

            services.AddTransient<UserRoleValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //         app.UseMiddleware<GlobalExceptionHandler>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}