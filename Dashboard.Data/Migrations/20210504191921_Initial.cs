using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    System = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: true),
                    RefreshTokenExpiry = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 1, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6348), "Error number: 1", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 343, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5044), "Error number: 343", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 342, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5020), "Error number: 342", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 341, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4996), "Error number: 341", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 340, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4973), "Error number: 340", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 339, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4949), "Error number: 339", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 338, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4925), "Error number: 338", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 337, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4902), "Error number: 337", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 336, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4878), "Error number: 336", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 335, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4854), "Error number: 335", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 334, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4831), "Error number: 334", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 333, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4807), "Error number: 333", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 332, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4783), "Error number: 332", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 331, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4760), "Error number: 331", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 330, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4737), "Error number: 330", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 329, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4712), "Error number: 329", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 328, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4689), "Error number: 328", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 327, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4665), "Error number: 327", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 326, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4642), "Error number: 326", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 325, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4618), "Error number: 325", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 324, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4594), "Error number: 324", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 323, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4571), "Error number: 323", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 322, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4547), "Error number: 322", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 321, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4523), "Error number: 321", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 320, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4500), "Error number: 320", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 319, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4475), "Error number: 319", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 318, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4452), "Error number: 318", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 317, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4406), "Error number: 317", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 344, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5068), "Error number: 344", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 316, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4381), "Error number: 316", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 345, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5091), "Error number: 345", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 347, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5139), "Error number: 347", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 374, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5800), "Error number: 374", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 373, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5772), "Error number: 373", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 372, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5754), "Error number: 372", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 371, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5730), "Error number: 371", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 370, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5706), "Error number: 370", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 369, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5682), "Error number: 369", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 368, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5659), "Error number: 368", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 367, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5631), "Error number: 367", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 366, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5607), "Error number: 366", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 365, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5587), "Error number: 365", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 364, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5560), "Error number: 364", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 363, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5536), "Error number: 363", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 362, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5512), "Error number: 362", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 361, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5489), "Error number: 361", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 360, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5465), "Error number: 360", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 359, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5441), "Error number: 359", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 358, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5418), "Error number: 358", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 357, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5394), "Error number: 357", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 356, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5370), "Error number: 356", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 355, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5346), "Error number: 355", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 354, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5323), "Error number: 354", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 353, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5280), "Error number: 353", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 352, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5256), "Error number: 352", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 351, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5233), "Error number: 351", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 350, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5209), "Error number: 350", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 349, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5186), "Error number: 349", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 348, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5163), "Error number: 348", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 346, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5114), "Error number: 346", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 315, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4357), "Error number: 315", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 314, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4334), "Error number: 314", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 313, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4311), "Error number: 313", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 280, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3511), "Error number: 280", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 279, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3487), "Error number: 279", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 278, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3463), "Error number: 278", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 277, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3440), "Error number: 277", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 276, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3417), "Error number: 276", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 275, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3392), "Error number: 275", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 274, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3369), "Error number: 274", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 273, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3345), "Error number: 273", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 272, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3322), "Error number: 272", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 271, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3298), "Error number: 271", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 270, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3274), "Error number: 270", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 269, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3251), "Error number: 269", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 268, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3227), "Error number: 268", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 267, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3203), "Error number: 267", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 266, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3180), "Error number: 266", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 265, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3155), "Error number: 265", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 264, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3132), "Error number: 264", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 263, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3109), "Error number: 263", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 262, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3086), "Error number: 262", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 261, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3061), "Error number: 261", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 260, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3037), "Error number: 260", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 259, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3014), "Error number: 259", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 258, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2991), "Error number: 258", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 257, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2943), "Error number: 257", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 256, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2920), "Error number: 256", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 255, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2896), "Error number: 255", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 254, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2872), "Error number: 254", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 281, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3534), "Error number: 281", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 282, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3558), "Error number: 282", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 283, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3601), "Error number: 283", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 284, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3624), "Error number: 284", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 312, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4287), "Error number: 312", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 311, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4263), "Error number: 311", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 310, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4240), "Error number: 310", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 309, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4216), "Error number: 309", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 308, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4192), "Error number: 308", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 307, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4169), "Error number: 307", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 306, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4145), "Error number: 306", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 305, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4121), "Error number: 305", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 304, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4098), "Error number: 304", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 303, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4074), "Error number: 303", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 302, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4050), "Error number: 302", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 301, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4026), "Error number: 301", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 300, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(4003), "Error number: 300", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 375, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5820), "Error number: 375", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 299, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3979), "Error number: 299", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 297, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3932), "Error number: 297", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 296, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3908), "Error number: 296", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 295, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3885), "Error number: 295", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 294, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3861), "Error number: 294", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 293, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3838), "Error number: 293", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 292, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3814), "Error number: 292", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 291, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3794), "Error number: 291", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 290, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3767), "Error number: 290", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 289, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3743), "Error number: 289", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 288, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3719), "Error number: 288", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 287, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3695), "Error number: 287", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 286, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3672), "Error number: 286", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 285, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3648), "Error number: 285", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 298, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(3956), "Error number: 298", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 253, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2849), "Error number: 253", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 376, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5848), "Error number: 376", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 378, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5896), "Error number: 378", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 468, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8129), "Error number: 468", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 467, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8105), "Error number: 467", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 466, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8086), "Error number: 466", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 465, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8058), "Error number: 465", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 464, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8039), "Error number: 464", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 463, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8015), "Error number: 463", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 462, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7991), "Error number: 462", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 461, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7968), "Error number: 461", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 460, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7944), "Error number: 460", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 459, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7920), "Error number: 459", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 458, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7873), "Error number: 458", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 457, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7854), "Error number: 457", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 456, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7826), "Error number: 456", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 455, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7803), "Error number: 455", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 454, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7779), "Error number: 454", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 453, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7755), "Error number: 453", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 452, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7732), "Error number: 452", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 451, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7708), "Error number: 451", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 450, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7684), "Error number: 450", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 449, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7660), "Error number: 449", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 448, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7637), "Error number: 448", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 447, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7613), "Error number: 447", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 446, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7589), "Error number: 446", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 445, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7565), "Error number: 445", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 444, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7542), "Error number: 444", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 443, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7518), "Error number: 443", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 442, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7494), "Error number: 442", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 469, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8152), "Error number: 469", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 441, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7471), "Error number: 441", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 470, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8176), "Error number: 470", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 472, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8227), "Error number: 472", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 499, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8890), "Error number: 499", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 498, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8867), "Error number: 498", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 497, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8843), "Error number: 497", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 496, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8819), "Error number: 496", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 495, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8796), "Error number: 495", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 494, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8744), "Error number: 494", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 493, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8725), "Error number: 493", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 492, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8702), "Error number: 492", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 491, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8677), "Error number: 491", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 490, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8653), "Error number: 490", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 489, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8630), "Error number: 489", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 488, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8607), "Error number: 488", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 487, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8582), "Error number: 487", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 486, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8559), "Error number: 486", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 485, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8536), "Error number: 485", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 484, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8512), "Error number: 484", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 483, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8488), "Error number: 483", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 482, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8465), "Error number: 482", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 481, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8440), "Error number: 481", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 480, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8417), "Error number: 480", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 479, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8394), "Error number: 479", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 478, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8370), "Error number: 478", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 477, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8346), "Error number: 477", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 476, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8322), "Error number: 476", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 475, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8299), "Error number: 475", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 474, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8276), "Error number: 474", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 473, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8247), "Error number: 473", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 471, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(8200), "Error number: 471", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 440, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7447), "Error number: 440", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 439, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7424), "Error number: 439", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 438, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7400), "Error number: 438", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 405, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6591), "Error number: 405", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 404, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6567), "Error number: 404", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 403, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6539), "Error number: 403", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 402, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6515), "Error number: 402", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 401, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6491), "Error number: 401", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 400, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6469), "Error number: 400", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 399, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6444), "Error number: 399", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 398, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6421), "Error number: 398", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 397, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6369), "Error number: 397", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 396, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6344), "Error number: 396", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 395, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6321), "Error number: 395", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 394, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6298), "Error number: 394", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 393, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6274), "Error number: 393", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 392, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6250), "Error number: 392", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 391, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6227), "Error number: 391", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 390, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6203), "Error number: 390", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 389, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6179), "Error number: 389", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 388, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6132), "Error number: 388", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 387, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6108), "Error number: 387", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 386, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6085), "Error number: 386", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 385, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6062), "Error number: 385", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 384, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6037), "Error number: 384", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 383, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6013), "Error number: 383", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 382, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5990), "Error number: 382", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 381, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5967), "Error number: 381", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 380, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5942), "Error number: 380", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 379, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5919), "Error number: 379", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 406, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6614), "Error number: 406", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 407, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6639), "Error number: 407", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 408, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6662), "Error number: 408", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 409, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6685), "Error number: 409", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 437, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7372), "Error number: 437", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 436, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7352), "Error number: 436", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 435, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7324), "Error number: 435", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 434, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7301), "Error number: 434", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 433, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7277), "Error number: 433", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 432, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7253), "Error number: 432", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 431, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7230), "Error number: 431", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 430, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7206), "Error number: 430", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 429, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7183), "Error number: 429", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 428, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7159), "Error number: 428", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 427, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7135), "Error number: 427", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 426, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7111), "Error number: 426", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 425, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7088), "Error number: 425", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 377, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(5872), "Error number: 377", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 424, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7064), "Error number: 424", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 422, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6998), "Error number: 422", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 421, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6974), "Error number: 421", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 420, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6946), "Error number: 420", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 419, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6922), "Error number: 419", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 418, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6899), "Error number: 418", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 417, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6875), "Error number: 417", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 416, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6851), "Error number: 416", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 415, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6828), "Error number: 415", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 414, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6804), "Error number: 414", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 413, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6780), "Error number: 413", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 412, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6757), "Error number: 412", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 411, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6733), "Error number: 411", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 410, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(6709), "Error number: 410", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 423, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(7021), "Error number: 423", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 252, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2825), "Error number: 252", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 251, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2801), "Error number: 251", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 125, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9688), "Error number: 125", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 93, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8912), "Error number: 93", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 92, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8894), "Error number: 92", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 91, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8870), "Error number: 91", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 90, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8846), "Error number: 90", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 89, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8822), "Error number: 89", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 88, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8799), "Error number: 88", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 87, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8775), "Error number: 87", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 86, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8751), "Error number: 86", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 85, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8727), "Error number: 85", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 84, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8704), "Error number: 84", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 83, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8685), "Error number: 83", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 82, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8661), "Error number: 82", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 81, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8633), "Error number: 81", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 80, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8609), "Error number: 80", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 79, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8586), "Error number: 79", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 78, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8563), "Error number: 78", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 77, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8539), "Error number: 77", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 76, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8514), "Error number: 76", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 75, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8496), "Error number: 75", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 74, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8473), "Error number: 74", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 73, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8444), "Error number: 73", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 72, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8424), "Error number: 72", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 71, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8401), "Error number: 71", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 70, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8378), "Error number: 70", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 69, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8354), "Error number: 69", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 68, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8330), "Error number: 68", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 67, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8307), "Error number: 67", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 94, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8936), "Error number: 94", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 66, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8283), "Error number: 66", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 95, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8960), "Error number: 95", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 97, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9007), "Error number: 97", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 124, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9664), "Error number: 124", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 123, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9636), "Error number: 123", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 122, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9612), "Error number: 122", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 121, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9594), "Error number: 121", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 120, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9570), "Error number: 120", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 119, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9546), "Error number: 119", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 118, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9522), "Error number: 118", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 117, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9499), "Error number: 117", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 116, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9475), "Error number: 116", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 115, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9452), "Error number: 115", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 114, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9427), "Error number: 114", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 113, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9404), "Error number: 113", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 112, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9381), "Error number: 112", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 111, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9357), "Error number: 111", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 110, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9333), "Error number: 110", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 109, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9310), "Error number: 109", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 108, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9286), "Error number: 108", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 107, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9262), "Error number: 107", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 106, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9239), "Error number: 106", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 105, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9215), "Error number: 105", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 104, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9191), "Error number: 104", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 103, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9167), "Error number: 103", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 102, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9144), "Error number: 102", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 101, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9121), "Error number: 101", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 100, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9096), "Error number: 100", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 99, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9072), "Error number: 99", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 98, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9031), "Error number: 98", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 96, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8983), "Error number: 96", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 65, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8236), "Error number: 65", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 64, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8212), "Error number: 64", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 63, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8188), "Error number: 63", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 30, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7412), "Error number: 30", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 29, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7360), "Error number: 29", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 28, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7336), "Error number: 28", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 27, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7313), "Error number: 27", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 26, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7289), "Error number: 26", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 25, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7266), "Error number: 25", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 24, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7243), "Error number: 24", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 23, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7219), "Error number: 23", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 22, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7199), "Error number: 22", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 21, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7176), "Error number: 21", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 20, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7148), "Error number: 20", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 19, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7124), "Error number: 19", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 18, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7100), "Error number: 18", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 17, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7076), "Error number: 17", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 16, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7053), "Error number: 16", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 15, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7029), "Error number: 15", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 14, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7005), "Error number: 14", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 13, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6982), "Error number: 13", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 12, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6958), "Error number: 12", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 11, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6934), "Error number: 11", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 10, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6911), "Error number: 10", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 9, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6882), "Error number: 9", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 8, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6859), "Error number: 8", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 7, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6835), "Error number: 7", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 6, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6812), "Error number: 6", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 5, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6783), "Error number: 5", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 4, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6759), "Error number: 4", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 31, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7435), "Error number: 31", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 32, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7464), "Error number: 32", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 33, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7484), "Error number: 33", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 34, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7512), "Error number: 34", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 62, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8165), "Error number: 62", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 61, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8142), "Error number: 61", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 60, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8117), "Error number: 60", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 59, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8093), "Error number: 59", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 58, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8070), "Error number: 58", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 57, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8047), "Error number: 57", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 56, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(8027), "Error number: 56", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 55, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7999), "Error number: 55", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 54, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7976), "Error number: 54", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 53, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7952), "Error number: 53", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 52, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7928), "Error number: 52", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 51, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7905), "Error number: 51", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 50, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7880), "Error number: 50", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 250, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2778), "Error number: 250", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 49, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7857), "Error number: 49", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 47, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7815), "Error number: 47", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 46, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7791), "Error number: 46", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 45, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7767), "Error number: 45", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 44, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7743), "Error number: 44", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 43, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7720), "Error number: 43", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 42, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7696), "Error number: 42", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 41, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7672), "Error number: 41", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 40, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7649), "Error number: 40", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 39, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7625), "Error number: 39", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 38, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7602), "Error number: 38", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 37, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7578), "Error number: 37", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 36, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7555), "Error number: 36", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 35, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7530), "Error number: 35", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 48, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(7838), "Error number: 48", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 3, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6731), "Error number: 3", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 126, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9712), "Error number: 126", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 128, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9759), "Error number: 128", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 218, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1945), "Error number: 218", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 217, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1926), "Error number: 217", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 216, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1902), "Error number: 216", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 215, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1879), "Error number: 215", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 214, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1855), "Error number: 214", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 213, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1831), "Error number: 213", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 212, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1807), "Error number: 212", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 211, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1784), "Error number: 211", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 210, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1761), "Error number: 210", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 209, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1736), "Error number: 209", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 208, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1712), "Error number: 208", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 207, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1690), "Error number: 207", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 206, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1666), "Error number: 206", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 205, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1642), "Error number: 205", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 204, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1619), "Error number: 204", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 203, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1595), "Error number: 203", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 202, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1571), "Error number: 202", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 201, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1548), "Error number: 201", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 200, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1524), "Error number: 200", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 199, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1500), "Error number: 199", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 198, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1476), "Error number: 198", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 197, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1453), "Error number: 197", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 196, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1429), "Error number: 196", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 195, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1405), "Error number: 195", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 194, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1363), "Error number: 194", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 193, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1339), "Error number: 193", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 192, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1316), "Error number: 192", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 219, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1968), "Error number: 219", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 191, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1292), "Error number: 191", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 220, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1997), "Error number: 220", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 222, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2044), "Error number: 222", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 249, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2754), "Error number: 249", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 248, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2730), "Error number: 248", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 247, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2706), "Error number: 247", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 246, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2678), "Error number: 246", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 245, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2659), "Error number: 245", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 244, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2631), "Error number: 244", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 243, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2607), "Error number: 243", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 242, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2583), "Error number: 242", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 241, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2560), "Error number: 241", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 240, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2536), "Error number: 240", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 239, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2513), "Error number: 239", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 238, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2489), "Error number: 238", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 237, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2465), "Error number: 237", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 236, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2442), "Error number: 236", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 235, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2419), "Error number: 235", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 234, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2394), "Error number: 234", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 233, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2370), "Error number: 233", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 232, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2347), "Error number: 232", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 231, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2323), "Error number: 231", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 230, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2229), "Error number: 230", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 229, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2205), "Error number: 229", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 228, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2182), "Error number: 228", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 227, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2157), "Error number: 227", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 226, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2139), "Error number: 226", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 225, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2111), "Error number: 225", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 224, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2087), "Error number: 224", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 223, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2067), "Error number: 223", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 221, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(2021), "Error number: 221", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 190, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1268), "Error number: 190", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 189, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1245), "Error number: 189", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 188, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1221), "Error number: 188", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 155, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(416), "Error number: 155", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 154, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(392), "Error number: 154", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 153, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(370), "Error number: 153", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 152, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(346), "Error number: 152", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 151, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(322), "Error number: 151", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 150, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(299), "Error number: 150", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 149, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(275), "Error number: 149", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 148, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(251), "Error number: 148", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 147, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(228), "Error number: 147", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 146, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(204), "Error number: 146", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 145, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(180), "Error number: 145", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 144, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(156), "Error number: 144", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 143, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(133), "Error number: 143", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 142, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(109), "Error number: 142", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 141, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(85), "Error number: 141", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 140, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(61), "Error number: 140", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 139, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(38), "Error number: 139", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 138, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(14), "Error number: 138", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 137, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9991), "Error number: 137", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 136, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9967), "Error number: 136", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 135, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9943), "Error number: 135", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 134, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9920), "Error number: 134", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 133, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9896), "Error number: 133", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 132, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9873), "Error number: 132", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 131, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9849), "Error number: 131", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 130, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9825), "Error number: 130", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 129, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9779), "Error number: 129", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 156, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(441), "Error number: 156", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 157, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(464), "Error number: 157", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 158, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(487), "Error number: 158", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 159, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(511), "Error number: 159", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 187, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1198), "Error number: 187", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 186, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1174), "Error number: 186", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 185, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1150), "Error number: 185", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 184, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1127), "Error number: 184", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 183, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1103), "Error number: 183", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 182, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1079), "Error number: 182", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 181, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1055), "Error number: 181", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 180, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1032), "Error number: 180", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 179, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(1008), "Error number: 179", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 178, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(984), "Error number: 178", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 177, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(961), "Error number: 177", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 176, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(937), "Error number: 176", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 175, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(914), "Error number: 175", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 127, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(9735), "Error number: 127", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 174, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(890), "Error number: 174", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 172, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(842), "Error number: 172", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 171, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(819), "Error number: 171", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 170, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(795), "Error number: 170", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 169, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(767), "Error number: 169", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 168, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(747), "Error number: 168", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 167, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(719), "Error number: 167", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 166, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(696), "Error number: 166", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 165, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(672), "Error number: 165", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 164, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(653), "Error number: 164", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 163, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(625), "Error number: 163", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 162, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(601), "Error number: 162", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 161, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(578), "Error number: 161", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 160, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(554), "Error number: 160", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 173, new DateTime(2021, 5, 4, 21, 19, 21, 694, DateTimeKind.Local).AddTicks(866), "Error number: 173", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 2, new DateTime(2021, 5, 4, 21, 19, 21, 693, DateTimeKind.Local).AddTicks(6707), "Error number: 2", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Basic" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Administrator" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "RefreshToken", "RefreshTokenExpiry", "RoleId", "Username" },
                values: new object[] { new Guid("14479b67-e3e4-4c8a-9bc0-a3848747697a"), true, "AQAAAAEAACcQAAAAEHEUf8ZtUKT69HUhODTZgtcYclxmUSgKS29DKbJrovDgb7RcW2dkqbMtkgS47nGRpA==", null, null, 1, "BasicUser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "RefreshToken", "RefreshTokenExpiry", "RoleId", "Username" },
                values: new object[] { new Guid("c94ed7d7-6b0a-40f5-9441-36f3ba5d5e5f"), true, "AQAAAAEAACcQAAAAEOVFQ/VDyhpSVu4+hWDpXqQr3pXfdXQFXE5MYwDqPncbq+Zs4F6I+1C1od+Uev2mTg==", null, null, 2, "AdminUser" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
