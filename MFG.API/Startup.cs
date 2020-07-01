using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using MFG.Application.Email;
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
using MFG.Implementation.Email;
using MFG.Implementation.Logging;
using MFG.Implementation.Queries;
using MFG.Implementation.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

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

            services.AddTransient<IUseCaseLogger, DbUseCaseLogger>();
            services.AddTransient<ISetFakeDataCommand, SetFakeDataCommand>();

            services.AddTransient<ICreateCityCommand, CreateCityCommand>();
            services.AddTransient<IDeleteCityCommand, DeleteCityCommand>();
            services.AddTransient<IEditCityCommand, EditCityCommand>();
            services.AddTransient<IGetCitiesQuery, GetCitiesQuery>();
            services.AddTransient<IGetCityQuery, GetCityQuery>();

            services.AddTransient<ICreateDirectorCommand, CreateDirectorCommand>();
            services.AddTransient<IDeleteDirectorCommand, DeleteDirectorCommand>();
            services.AddTransient<IEditDirectorCommand, EditDirectorCommand>();
            services.AddTransient<IGetDirectorsQuery, GetDirectorsQuery>();
            services.AddTransient<IGetDirectorQuery, GetDirectorQuery>();

            services.AddTransient<ICreateFestivalCommand, CreateFestivalCommand>();
            services.AddTransient<IDeleteFestivalCommand, DeleteFestivalCommand>();
            services.AddTransient<IEditFestivalCommand, EditFestivalCommand>();
            services.AddTransient<IGetFestivalsQuery, GetFestivalsQuery>();
            services.AddTransient<IGetFestivalQuery, GetFestivalQuery>();

            services.AddTransient<ICreateHallCommand, CreateHallCommand>();
            services.AddTransient<IDeleteHallCommand, DeleteHallCommand>();
            services.AddTransient<IEditHallCommand, EditHallCommand>();
            services.AddTransient<IGetHallsQuery, GetHallsQuery>();
            services.AddTransient<IGetHallQuery, GetHallQuery>();

            services.AddTransient<ICreateLocationCommand, CreateLocationCommand>();
            services.AddTransient<IDeleteLocationCommand, DeleteLocationCommand>();
            services.AddTransient<IEditLocationCommand, EditLocationCommand>();
            services.AddTransient<IGetLocationsQuery, GetLocationsQuery>();
            services.AddTransient<IGetLocationQuery, GetLocationQuery>();

            services.AddTransient<ICreateMovieCommand, CreateMovieCommand>();
            services.AddTransient<IDeleteMovieCommand, DeleteMovieCommand>();
            services.AddTransient<IEditMovieCommand, EditMovieCommand>();
            services.AddTransient<IGetMoviesQuery, GetMoviesQuery>();
            services.AddTransient<IGetMovieQuery, GetMovieQuery>();

            services.AddTransient<ICreatePlaceCommand, CreatePlaceCommand>();
            services.AddTransient<IDeletePlaceCommand, DeletePlaceCommand>();
            services.AddTransient<IEditPlaceCommand, EditPlaceCommand>();
            services.AddTransient<IGetPlacesQuery, GetPlacesQuery>();
            services.AddTransient<IGetPlaceQuery, GetPlaceQuery>();

            services.AddTransient<ICreateProjectionCommand, CreateProjectionCommand>();
            services.AddTransient<IDeleteProjectionCommand, DeleteProjectionCommand>();
            services.AddTransient<IEditProjectionCommand, EditProjectionCommand>();
            services.AddTransient<IGetProjectionsQuery, GetProjectionsQuery>();
            services.AddTransient<IGetProjectionQuery, GetProjectionQuery>();

            services.AddTransient<ICreateTicketCommand, CreateTicketCommand>();
            services.AddTransient<IDeleteTicketCommand, DeleteTicketCommand>();
            services.AddTransient<IEditTicketCommand, EditTicketCommand>();
            services.AddTransient<IGetTicketsQuery, GetTicketsQuery>();
            services.AddTransient<IGetTicketQuery, GetTicketQuery>();

            services.AddTransient<ICreateTicketReservationCommand, CreateTicketReservationCommand>();
            services.AddTransient<IDeleteTicketReservationCommand, DeleteTicketReservationCommand>();
            services.AddTransient<IEditTicketReservationCommand, EditTicketReservationCommand>();
            services.AddTransient<IPickTicketReservationCommand, PickTicketReservationCommand>();
            services.AddTransient<IGetTicketReservationsQuery, GetTicketReservationsQuery>();
            services.AddTransient<IGetTicketReservationQuery, GetTicketReservationQuery>();

            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
            services.AddTransient<IEditUserCommand, EditUserCommand>();
            services.AddTransient<IChangeUserRoleCommand, ChangeUserRoleCommand>();
            services.AddTransient<IGetUsersQuery, GetUsersQuery>();
            services.AddTransient<IGetUserQuery, GetUserQuery>();

            services.AddTransient<IEmailSender, SmtpEmailSender>();

            services.AddTransient<IGetUseCaseLogsQuery, GetUseCaseLogsQuery>();

            services.AddHttpContextAccessor();

            services.AddTransient<IApplicationActor>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();
                //izvuci token
                //pozicionirati se na payload
                //izvuci ActorData claim
                //Deserijalizovati actorData string u c# objekat

                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    //throw new InvalidOperationException("Actor data doesnt exist in token.");
                    return new UnauthorizedActor();
                }

                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;
            });

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

            services.AddTransient<JwtManager>();

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "asp_api",
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MFG api key for jwt")),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Movie Festival Guide", Version = "v1" });
                /* c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                 {
                     Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                       Enter 'Bearer' [space] and then your token in the text input below.
                       \r\n\r\nExample: 'Bearer 12345abcdef'",
                     Name = "Authorization",
                     In = ParameterLocation.Header,
                     Type = SecuritySchemeType.ApiKey,
                     Scheme = "Bearer"
                 });*/

                /* c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                 {
                     {
                         new OpenApiSecurityScheme
                           {
                             Reference = new OpenApiReference
                               {
                                 Type = ReferenceType.SecurityScheme,
                                 Id = "Bearer"
                               },
                               Scheme = "oauth2",
                               Name = "Bearer",
                               In = ParameterLocation.Header,
                             },
                             new List<string>()
                           }
                     });*/
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // za swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });
            //  gotovo za swagger
            app.UseRouting();

            app.UseMiddleware<GlobalExceptionHandler>();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}