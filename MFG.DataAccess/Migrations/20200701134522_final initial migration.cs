using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class finalinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 13, 45, 21, 430, DateTimeKind.Utc).AddTicks(827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 1, 47, 29, 688, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 351, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 13, 45, 21, 352, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "Id", "RoleId", "UseCaseId" },
                values: new object[,]
                {
                    { 85, 2, 1103 },
                    { 84, 2, 1102 },
                    { 83, 2, 1101 },
                    { 82, 2, 2101 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Username" },
                values: new object[] { new DateTime(2020, 7, 1, 13, 45, 21, 353, DateTimeKind.Utc).AddTicks(6610), "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Username" },
                values: new object[] { new DateTime(2020, 7, 1, 13, 45, 21, 353, DateTimeKind.Utc).AddTicks(6737), "seller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 1, 47, 29, 688, DateTimeKind.Utc).AddTicks(4313),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 13, 45, 21, 430, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 592, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 1, 47, 29, 593, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Username" },
                values: new object[] { new DateTime(2020, 7, 1, 1, 47, 29, 594, DateTimeKind.Utc).AddTicks(9944), "petko" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Username" },
                values: new object[] { new DateTime(2020, 7, 1, 1, 47, 29, 595, DateTimeKind.Utc).AddTicks(105), "miki" });
        }
    }
}
