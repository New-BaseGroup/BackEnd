using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class firstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetID);
                    table.ForeignKey(
                        name: "FK_Budgets_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "BudgetCategories",
                columns: table => new
                {
                    BudgetCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAmount = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BudgetID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetCategories", x => x.BudgetCategoryID);
                    table.ForeignKey(
                        name: "FK_BudgetCategories_Budgets_BudgetID",
                        column: x => x.BudgetID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetID");
                    table.ForeignKey(
                        name: "FK_BudgetCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    ChangeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.ChangeID);
                    table.ForeignKey(
                        name: "FK_Changes_BudgetCategories_BudgetCategoryID",
                        column: x => x.BudgetCategoryID,
                        principalTable: "BudgetCategories",
                        principalColumn: "BudgetCategoryID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Fuel" },
                    { 3, "Clothes" },
                    { 4, "Furniture" },
                    { 5, "House" },
                    { 6, "NotHouse" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "Adam@gmail.com", "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==", "Adam" },
                    { 2, "Kim@gmail.com", "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==", "Kim" },
                    { 3, "Omar@gmail.com", "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==", "Omar" },
                    { 4, "Ahmad@gmail.com", "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==", "Ahmad" }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetID", "Description", "EndDate", "Name", "StartDate", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4199), "budgetNr1", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4166), 40000m, 1 },
                    { 2, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4206), "budgetNr2", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4205), 20000m, 1 },
                    { 3, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4209), "budgetNr1", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4208), 10000m, 2 },
                    { 4, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4212), "budgetNr2", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4211), 10000m, 2 },
                    { 5, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4215), "budgetNr1", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4214), 10000m, 3 },
                    { 6, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4218), "budgetNr2", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4217), 10000m, 3 },
                    { 7, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4221), "budgetNr1", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4219), 10000m, 4 },
                    { 8, null, new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4223), "budgetNr2", new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4222), 10000m, 4 }
                });

            migrationBuilder.InsertData(
                table: "BudgetCategories",
                columns: new[] { "BudgetCategoryID", "BudgetID", "CategoryID", "CustomName", "MaxAmount" },
                values: new object[,]
                {
                    { 1, 1, 1, "BudgetCategory1", 10000 },
                    { 2, 1, 2, "BudgetCategory2", 10000 },
                    { 3, 1, 3, "BudgetCategory3", 10000 },
                    { 4, 1, 4, "BudgetCategory4", 10000 },
                    { 5, 2, 5, "BudgetCategory5", 10000 },
                    { 6, 2, 1, "BudgetCategory6", 10000 },
                    { 7, 3, 2, "BudgetCategory7", 10000 },
                    { 8, 4, 3, "BudgetCategory8", 10000 },
                    { 9, 5, 4, "BudgetCategory9", 10000 },
                    { 10, 6, 5, "BudgetCategory10", 10000 },
                    { 11, 7, 6, "BudgetCategory11", 10000 },
                    { 12, 8, 6, "BudgetCategory12", 10000 }
                });

            migrationBuilder.InsertData(
                table: "Changes",
                columns: new[] { "ChangeID", "Amount", "BudgetCategoryID", "Date", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 11000, 1, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4266), "test Description 1", "income test test1" },
                    { 2, -2000, 1, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4268), "test Description 1", "income test test2" },
                    { 3, 30000, 2, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4270), "test Description 1", "income test test3" },
                    { 4, -1000, 2, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4272), "test Description 1", "income test test4" },
                    { 5, -2000, 3, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4273), "test Description 1", "income test test5" },
                    { 6, -3000, 4, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4274), "test Description 1", "income test test6" },
                    { 7, -3000, 5, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4276), "test Description 1", "income test test7" },
                    { 8, -3000, 6, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4277), "test Description 1", "income test test8" },
                    { 9, -3000, 7, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4278), "test Description 1", "income test test9" },
                    { 10, -3000, 8, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4280), "test Description 1", "income test test10" },
                    { 11, -3000, 3, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4281), "test Description 1", "income test test11" },
                    { 12, -3000, 3, new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4282), "test Description 1", "income test test12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategories_BudgetID",
                table: "BudgetCategories",
                column: "BudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategories_CategoryID",
                table: "BudgetCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_UserID",
                table: "Budgets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Changes_BudgetCategoryID",
                table: "Changes",
                column: "BudgetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "BudgetCategories");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
