using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class finalinitalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Year = table.Column<int>(maxLength: 4, nullable: false),
                    AvgRating = table.Column<float>(maxLength: 4, nullable: false),
                    Length = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UseCaseLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    UseCaseName = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCaseLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieDirector",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false),
                    DirectorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDirector", x => new { x.DirectorID, x.MovieID });
                    table.ForeignKey(
                        name: "FK_MovieDirector_Directors_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieDirector_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleUseCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    UseCaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUseCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleUseCases_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    Username = table.Column<string>(maxLength: 30, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    NumberOfSeats = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Halls_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CityID = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    About = table.Column<string>(type: "text", nullable: false),
                    MaxTickets = table.Column<int>(maxLength: 3, nullable: false),
                    PlaceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Festivals_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    BeginsAt = table.Column<DateTime>(nullable: false),
                    EndsAt = table.Column<DateTime>(nullable: false),
                    MovieID = table.Column<int>(nullable: false),
                    HallID = table.Column<int>(nullable: false),
                    FestivalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projections_Festivals_FestivalID",
                        column: x => x.FestivalID,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projections_Halls_HallID",
                        column: x => x.HallID,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projections_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(maxLength: 10, nullable: false),
                    ProjectionID = table.Column<int>(nullable: false),
                    FestivalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Festivals_FestivalID",
                        column: x => x.FestivalID,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Projections_ProjectionID",
                        column: x => x.ProjectionID,
                        principalTable: "Projections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketReservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    TicketID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(maxLength: 3, nullable: false),
                    TotalPrice = table.Column<decimal>(maxLength: 20, nullable: false),
                    ReservationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 7, 1, 1, 47, 29, 688, DateTimeKind.Utc).AddTicks(4313)),
                    Bought = table.Column<DateTime>(nullable: true),
                    ReservationCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketReservations_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketReservations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(3773), null, true, null, "Beograd" },
                    { 2, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5298), null, true, null, "Novi Sad" },
                    { 3, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5352), null, true, null, "Niš" },
                    { 4, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5371), null, true, null, "Vrnjačka banja" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "user" },
                    { 2, "seller" },
                    { 3, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityID", "CreatedAt", "DeletedAt", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8833), null, true, null, "Sava Centar" },
                    { 2, 1, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8965), null, true, null, "Dom sindikata" },
                    { 3, 1, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8984), null, true, null, "Dom omladine" },
                    { 4, 1, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9004), null, true, null, "Centar za kulturu Vlada Divljan" },
                    { 7, 2, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9048), null, true, null, "Kulturni centar Novog Sada" },
                    { 8, 3, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9063), null, true, null, "Niški kulturni centar" },
                    { 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Bioskop" },
                    { 6, 4, new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9033), null, true, null, "Letnja pozornica" }
                });

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "Id", "RoleId", "UseCaseId" },
                values: new object[,]
                {
                    { 59, 3, 171 },
                    { 58, 3, 163 },
                    { 57, 3, 162 },
                    { 56, 3, 161 },
                    { 55, 3, 153 },
                    { 54, 3, 152 },
                    { 53, 3, 151 },
                    { 52, 3, 143 },
                    { 48, 3, 132 },
                    { 50, 3, 141 },
                    { 49, 3, 133 },
                    { 60, 3, 172 },
                    { 47, 3, 131 },
                    { 46, 3, 123 },
                    { 45, 3, 122 },
                    { 44, 3, 121 },
                    { 43, 3, 113 },
                    { 51, 3, 142 },
                    { 61, 3, 173 },
                    { 65, 3, 191 },
                    { 63, 3, 182 },
                    { 80, 3, 2111 },
                    { 79, 3, 2111 },
                    { 78, 3, 2102 },
                    { 77, 3, 2101 },
                    { 76, 3, 272 },
                    { 75, 3, 271 },
                    { 74, 3, 252 },
                    { 73, 3, 251 },
                    { 72, 3, 241 },
                    { 71, 3, 242 },
                    { 70, 3, 212 },
                    { 69, 3, 211 },
                    { 68, 3, 1112 },
                    { 67, 3, 193 },
                    { 66, 3, 192 },
                    { 42, 3, 112 },
                    { 64, 3, 183 },
                    { 62, 3, 181 },
                    { 41, 3, 111 },
                    { 37, 3, 292 },
                    { 39, 3, 1113 },
                    { 17, 2, 2102 },
                    { 16, 2, 1104 },
                    { 15, 1, 291 },
                    { 14, 1, 292 },
                    { 13, 1, 281 },
                    { 12, 1, 282 },
                    { 11, 1, 261 },
                    { 10, 1, 262 },
                    { 9, 1, 231 },
                    { 8, 1, 232 },
                    { 7, 1, 221 },
                    { 6, 1, 222 },
                    { 5, 1, 1113 },
                    { 4, 1, 2102 },
                    { 3, 1, 1103 },
                    { 2, 1, 1102 },
                    { 1, 1, 1101 },
                    { 18, 2, 1113 },
                    { 19, 2, 222 },
                    { 20, 2, 221 },
                    { 21, 2, 232 },
                    { 38, 3, 291 },
                    { 81, 3, 2121 },
                    { 36, 3, 281 },
                    { 35, 3, 282 },
                    { 34, 3, 261 },
                    { 33, 3, 262 },
                    { 32, 3, 231 },
                    { 31, 3, 232 },
                    { 40, 3, 1121 },
                    { 30, 3, 221 },
                    { 28, 2, 291 },
                    { 27, 2, 292 },
                    { 26, 2, 281 },
                    { 25, 2, 282 },
                    { 24, 2, 261 },
                    { 23, 2, 262 },
                    { 22, 2, 231 },
                    { 29, 3, 222 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "LastName", "ModifiedAt", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 7, 1, 1, 47, 29, 595, DateTimeKind.Utc).AddTicks(105), null, "miki@gmail.com", "Mitar", true, "Miric", null, "sifra123", 2, "miki" },
                    { 1, new DateTime(2020, 7, 1, 1, 47, 29, 594, DateTimeKind.Utc).AddTicks(9944), null, "pera@gmail.com", "Petar", true, "Peric", null, "sifra123", 3, "petko" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "LocationID", "ModifiedAt", "Name", "NumberOfSeats" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3047), null, true, 1, null, "Sala 1", 412 },
                    { 15, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3399), null, true, 5, null, "Sala 2", 278 },
                    { 14, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3380), null, true, 5, null, "Sala 1", 125 },
                    { 21, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3531), null, true, 8, null, "Sala 2", 279 },
                    { 20, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3482), null, true, 8, null, "Sala 1", 324 },
                    { 19, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3468), null, true, 7, null, "Velika sala", 1580 },
                    { 18, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3448), null, true, 7, null, "Sala 2", 326 },
                    { 17, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3428), null, true, 7, null, "Sala 1", 158 },
                    { 13, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3365), null, true, 4, null, "Sala 2", 298 },
                    { 16, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3414), null, true, 6, null, "Letnja pozornica", 370 },
                    { 11, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3331), null, true, 3, null, "Sala amerikana", 200 },
                    { 12, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3350), null, true, 4, null, "Sala 1", 78 },
                    { 9, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3296), null, true, 2, null, "Sala 3", 72 },
                    { 8, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3277), null, true, 2, null, "Sala 2", 78 },
                    { 2, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3164), null, true, 1, null, "Aneks A", 198 },
                    { 7, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3262), null, true, 2, null, "Sala 1", 1382 },
                    { 3, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3184), null, true, 1, null, "Aneks B", 198 },
                    { 6, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3243), null, true, 1, null, "Amfiteatar", 454 },
                    { 10, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3316), null, true, 3, null, "Velika sala", 483 },
                    { 5, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3218), null, true, 1, null, "Velika dvorana", 3672 },
                    { 4, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3204), null, true, 1, null, "Japanski salon", 140 }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CityID", "CreatedAt", "DeletedAt", "IsActive", "LocationID", "ModifiedAt" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7022), null, true, 2, null },
                    { 5, 4, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7076), null, true, 5, null },
                    { 7, 2, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7115), null, true, 7, null },
                    { 1, 1, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(6934), null, true, 1, null },
                    { 4, 1, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7061), null, true, 4, null },
                    { 3, 1, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7042), null, true, 3, null },
                    { 8, 3, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7139), null, true, 8, null },
                    { 6, 4, new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7100), null, true, 6, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Festivals_PlaceID",
                table: "Festivals",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_LocationID",
                table: "Halls",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityID",
                table: "Locations",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirector_MovieID",
                table: "MovieDirector",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Places_LocationID",
                table: "Places",
                column: "LocationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_CityID_LocationID",
                table: "Places",
                columns: new[] { "CityID", "LocationID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projections_FestivalID",
                table: "Projections",
                column: "FestivalID");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_HallID",
                table: "Projections",
                column: "HallID");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_MovieID",
                table: "Projections",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUseCases_RoleId",
                table: "RoleUseCases",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservations_ReservationCode",
                table: "TicketReservations",
                column: "ReservationCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservations_TicketID",
                table: "TicketReservations",
                column: "TicketID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservations_UserID",
                table: "TicketReservations",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FestivalID",
                table: "Tickets",
                column: "FestivalID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProjectionID",
                table: "Tickets",
                column: "ProjectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDirector");

            migrationBuilder.DropTable(
                name: "RoleUseCases");

            migrationBuilder.DropTable(
                name: "TicketReservations");

            migrationBuilder.DropTable(
                name: "UseCaseLogs");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Festivals");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
