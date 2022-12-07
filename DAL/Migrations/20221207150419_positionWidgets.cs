using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class positionWidgets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3722), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3726), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3728), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3732), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3734), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3737), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 11, 27, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 12, 7, 16, 4, 19, 395, DateTimeKind.Local).AddTicks(3781));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Widgets");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2453), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2455), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2459), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2461), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2465), new DateTime(2022, 11, 25, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 12, 5, 7, 11, 31, 821, DateTimeKind.Local).AddTicks(2522));
        }
    }
}
