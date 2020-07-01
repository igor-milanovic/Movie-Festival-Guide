using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class AddedUseCaseLogtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 18, 20, 0, 972, DateTimeKind.Utc).AddTicks(6490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 30, 16, 59, 54, 40, DateTimeKind.Utc).AddTicks(2198));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 30, 16, 59, 54, 40, DateTimeKind.Utc).AddTicks(2198),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 30, 18, 20, 0, 972, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 954, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 16, 59, 53, 955, DateTimeKind.Utc).AddTicks(5114));
        }
    }
}
