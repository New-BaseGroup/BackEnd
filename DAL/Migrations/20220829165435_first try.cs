using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class firsttry : Migration
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
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    { 1, "Adam@gmail.com", "qwerty123", "Adam" },
                    { 2, "Kim@gmail.com", "qwerty123", "Kim" },
                    { 3, "Omar@gmail.com", "qwerty123", "Omar" },
                    { 4, "Ahmad@gmail.com", "qwerty123", "Ahmad" }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetID", "Description", "EndDate", "Name", "StartDate", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr1", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 1 },
                    { 2, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr2", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 1 },
                    { 3, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr1", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 2 },
                    { 4, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr2", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 2 },
                    { 5, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr1", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 3 },
                    { 6, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr2", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 3 },
                    { 7, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr1", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 4 },
                    { 8, null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "budgetNr2", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 4 }
                });

            migrationBuilder.InsertData(
                table: "BudgetCategories",
                columns: new[] { "BudgetCategoryID", "BudgetID", "CategoryID", "CustomName", "MaxAmount" },
                values: new object[,]
                {
                    { 1, 1, 1, "BudgetCategory1", 10 },
                    { 2, 2, 2, "BudgetCategory2", 10 },
                    { 3, 3, 3, "BudgetCategory3", 10 },
                    { 4, 4, 4, "BudgetCategory4", 10 },
                    { 5, 5, 5, "BudgetCategory5", 10 },
                    { 6, 6, 1, "BudgetCategory6", 10 },
                    { 7, 7, 2, "BudgetCategory7", 10 },
                    { 8, 8, 3, "BudgetCategory8", 10 },
                    { 9, 1, 4, "BudgetCategory9", 10 },
                    { 10, 2, 5, "BudgetCategory10", 10 },
                    { 11, 3, 6, "BudgetCategory11", 10 },
                    { 12, 4, 6, "BudgetCategory12", 10 }
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
