using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFG.DataAccess.Migrations
{
    public partial class Removednameuniquefromlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 27, 19, 46, 55, 492, DateTimeKind.Utc).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 27, 19, 46, 12, 801, DateTimeKind.Utc).AddTicks(9279));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "TicketReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 27, 19, 46, 12, 801, DateTimeKind.Utc).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 27, 19, 46, 55, 492, DateTimeKind.Utc).AddTicks(7593));
        }
    }
}
