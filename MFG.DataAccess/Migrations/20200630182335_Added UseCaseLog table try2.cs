using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class AddedUseCaseLogtabletry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 18, 23, 34, 301, DateTimeKind.Utc).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 30, 18, 20, 0, 972, DateTimeKind.Utc).AddTicks(6490));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UseCaseLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 18, 20, 0, 972, DateTimeKind.Utc).AddTicks(6490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 30, 18, 23, 34, 301, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 896, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 896, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 896, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 896, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 897, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 20, 0, 898, DateTimeKind.Utc).AddTicks(2641));
        }
    }
}
