using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class addedRoleUseCases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 23, 22, 59, 734, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 30, 18, 23, 34, 301, DateTimeKind.Utc).AddTicks(4729));

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

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 624, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 623, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 23, 22, 59, 625, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.CreateIndex(
                name: "IX_RoleUseCases_RoleId",
                table: "RoleUseCases",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleUseCases");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 18, 23, 34, 301, DateTimeKind.Utc).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 30, 23, 22, 59, 734, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 217, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 217, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 217, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 217, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 218, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 23, 34, 219, DateTimeKind.Utc).AddTicks(5234));
        }
    }
}
