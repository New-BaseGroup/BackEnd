using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class addedwidgets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    WidgetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.WidgetID);
                    table.ForeignKey(
                        name: "FK_Widgets_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_UserID",
                table: "Widgets",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4206), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4209), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4212), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4215), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4218), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4221), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4223), new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Changes",
                keyColumn: "ChangeID",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4282));
        }
    }
}
