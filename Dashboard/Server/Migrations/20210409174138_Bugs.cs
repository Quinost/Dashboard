using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Server.Migrations
{
    public partial class Bugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a8e303f-e53c-43db-a934-2bfc9509e639"));

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

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 1, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3227), "Error number: 1", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 342, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1989), "Error number: 342", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 341, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1965), "Error number: 341", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 340, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1941), "Error number: 340", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 339, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1918), "Error number: 339", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 338, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1895), "Error number: 338", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 337, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1870), "Error number: 337", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 336, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1846), "Error number: 336", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 335, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1823), "Error number: 335", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 334, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1800), "Error number: 334", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 333, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1776), "Error number: 333", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 332, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1752), "Error number: 332", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 331, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1724), "Error number: 331", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 330, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1700), "Error number: 330", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 329, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1677), "Error number: 329", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 328, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1653), "Error number: 328", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 327, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1629), "Error number: 327", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 326, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1605), "Error number: 326", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 325, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1582), "Error number: 325", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 324, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1558), "Error number: 324", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 323, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1534), "Error number: 323", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 322, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1510), "Error number: 322", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 321, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1482), "Error number: 321", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 320, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1435), "Error number: 320", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 319, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1411), "Error number: 319", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 318, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1388), "Error number: 318", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 317, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1345), "Error number: 317", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 316, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1322), "Error number: 316", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 343, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2012), "Error number: 343", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 315, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1298), "Error number: 315", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 344, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2036), "Error number: 344", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 346, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2083), "Error number: 346", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 373, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2750), "Error number: 373", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 372, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2727), "Error number: 372", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 371, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2703), "Error number: 371", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 370, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2680), "Error number: 370", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 369, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2656), "Error number: 369", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 368, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2633), "Error number: 368", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 367, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2608), "Error number: 367", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 366, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2585), "Error number: 366", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 365, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2561), "Error number: 365", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 364, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2538), "Error number: 364", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 363, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2513), "Error number: 363", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 362, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2490), "Error number: 362", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 361, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2467), "Error number: 361", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 360, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2438), "Error number: 360", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 359, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2419), "Error number: 359", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 358, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2391), "Error number: 358", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 357, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2367), "Error number: 357", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 356, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2343), "Error number: 356", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 355, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2320), "Error number: 355", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 354, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2296), "Error number: 354", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 353, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2253), "Error number: 353", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 352, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2230), "Error number: 352", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 351, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2206), "Error number: 351", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 350, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2182), "Error number: 350", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 349, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2154), "Error number: 349", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 348, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2131), "Error number: 348", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 347, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2112), "Error number: 347", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 345, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2060), "Error number: 345", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 314, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1274), "Error number: 314", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 313, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1251), "Error number: 313", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 312, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1228), "Error number: 312", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 279, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(423), "Error number: 279", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 278, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(399), "Error number: 278", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 277, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(375), "Error number: 277", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 276, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(352), "Error number: 276", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 275, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(329), "Error number: 275", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 274, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(304), "Error number: 274", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 273, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(281), "Error number: 273", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 272, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(253), "Error number: 272", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 271, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(233), "Error number: 271", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 270, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(210), "Error number: 270", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 269, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(186), "Error number: 269", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 268, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(163), "Error number: 268", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 267, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(139), "Error number: 267", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 266, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(110), "Error number: 266", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 265, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(87), "Error number: 265", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 264, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(63), "Error number: 264", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 263, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(40), "Error number: 263", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 262, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(16), "Error number: 262", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 261, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9993), "Error number: 261", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 260, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9968), "Error number: 260", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 259, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9945), "Error number: 259", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 258, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9922), "Error number: 258", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 257, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9827), "Error number: 257", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 256, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9808), "Error number: 256", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 255, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9779), "Error number: 255", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 254, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9756), "Error number: 254", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 253, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9732), "Error number: 253", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 280, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(446), "Error number: 280", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 281, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(470), "Error number: 281", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 282, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(494), "Error number: 282", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 283, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(536), "Error number: 283", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 311, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1203), "Error number: 311", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 310, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1179), "Error number: 310", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 309, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1156), "Error number: 309", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 308, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1132), "Error number: 308", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 307, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1108), "Error number: 307", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 306, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1085), "Error number: 306", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 305, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1061), "Error number: 305", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 304, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1038), "Error number: 304", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 303, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(1014), "Error number: 303", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 302, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(991), "Error number: 302", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 301, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(966), "Error number: 301", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 300, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(943), "Error number: 300", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 299, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(920), "Error number: 299", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 374, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2774), "Error number: 374", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 298, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(896), "Error number: 298", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 296, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(848), "Error number: 296", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 295, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(825), "Error number: 295", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 294, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(802), "Error number: 294", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 293, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(777), "Error number: 293", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 292, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(749), "Error number: 292", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 291, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(730), "Error number: 291", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 290, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(702), "Error number: 290", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 289, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(683), "Error number: 289", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 288, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(655), "Error number: 288", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 287, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(635), "Error number: 287", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 286, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(612), "Error number: 286", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 285, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(584), "Error number: 285", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 284, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(560), "Error number: 284", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 297, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(872), "Error number: 297", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 252, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9708), "Error number: 252", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 375, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2798), "Error number: 375", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 377, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2845), "Error number: 377", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 467, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5050), "Error number: 467", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 466, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5026), "Error number: 466", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 465, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5002), "Error number: 465", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 464, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4979), "Error number: 464", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 463, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4955), "Error number: 463", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 462, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4931), "Error number: 462", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 461, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4907), "Error number: 461", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 460, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4884), "Error number: 460", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 459, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4861), "Error number: 459", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 458, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4818), "Error number: 458", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 457, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4794), "Error number: 457", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 456, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4766), "Error number: 456", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 455, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4742), "Error number: 455", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 454, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4719), "Error number: 454", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 453, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4695), "Error number: 453", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 452, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4671), "Error number: 452", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 451, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4652), "Error number: 451", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 450, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4624), "Error number: 450", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 449, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4600), "Error number: 449", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 448, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4576), "Error number: 448", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 447, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4553), "Error number: 447", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 446, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4530), "Error number: 446", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 445, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4505), "Error number: 445", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 444, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4481), "Error number: 444", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 443, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4459), "Error number: 443", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 442, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4435), "Error number: 442", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 441, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4411), "Error number: 441", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 468, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5073), "Error number: 468", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 440, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4388), "Error number: 440", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 469, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5097), "Error number: 469", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 471, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5144), "Error number: 471", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 498, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5811), "Error number: 498", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 497, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5787), "Error number: 497", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 496, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5760), "Error number: 496", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 495, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5740), "Error number: 495", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 494, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5716), "Error number: 494", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 493, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5669), "Error number: 493", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 492, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5646), "Error number: 492", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 491, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5623), "Error number: 491", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 490, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5599), "Error number: 490", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 489, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5574), "Error number: 489", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 488, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5551), "Error number: 488", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 487, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5528), "Error number: 487", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 486, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5504), "Error number: 486", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 485, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5480), "Error number: 485", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 484, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5456), "Error number: 484", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 483, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5433), "Error number: 483", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 482, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5409), "Error number: 482", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 481, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5385), "Error number: 481", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 480, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5358), "Error number: 480", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 479, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5338), "Error number: 479", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 478, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5315), "Error number: 478", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 477, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5287), "Error number: 477", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 476, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5263), "Error number: 476", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 475, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5243), "Error number: 475", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 474, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5215), "Error number: 474", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 473, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5192), "Error number: 473", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 472, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5168), "Error number: 472", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 470, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5121), "Error number: 470", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 439, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4364), "Error number: 439", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 438, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4340), "Error number: 438", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 437, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4317), "Error number: 437", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 404, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3507), "Error number: 404", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 403, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3484), "Error number: 403", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 402, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3460), "Error number: 402", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 401, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3437), "Error number: 401", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 400, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3413), "Error number: 400", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 399, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3389), "Error number: 399", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 398, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3365), "Error number: 398", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 397, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3342), "Error number: 397", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 396, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3318), "Error number: 396", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 395, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3295), "Error number: 395", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 394, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3270), "Error number: 394", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 393, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3247), "Error number: 393", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 392, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3224), "Error number: 392", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 391, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3200), "Error number: 391", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 390, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3176), "Error number: 390", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 389, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3152), "Error number: 389", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 388, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3105), "Error number: 388", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 387, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3086), "Error number: 387", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 386, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3063), "Error number: 386", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 385, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3034), "Error number: 385", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 384, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3015), "Error number: 384", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 383, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2987), "Error number: 383", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 382, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2964), "Error number: 382", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 381, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2939), "Error number: 381", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 380, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2916), "Error number: 380", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 379, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2893), "Error number: 379", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 378, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2868), "Error number: 378", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 405, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3531), "Error number: 405", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 406, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3555), "Error number: 406", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 407, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3578), "Error number: 407", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 408, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3606), "Error number: 408", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 436, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4293), "Error number: 436", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 435, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4269), "Error number: 435", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 434, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4245), "Error number: 434", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 433, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4222), "Error number: 433", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 432, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4198), "Error number: 432", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 431, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4174), "Error number: 431", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 430, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4150), "Error number: 430", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 429, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4122), "Error number: 429", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 428, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4103), "Error number: 428", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 427, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4075), "Error number: 427", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 426, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4051), "Error number: 426", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 425, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4028), "Error number: 425", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 424, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(4004), "Error number: 424", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 376, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(2821), "Error number: 376", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 423, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3962), "Error number: 423", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 421, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3914), "Error number: 421", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 420, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3891), "Error number: 420", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 419, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3868), "Error number: 419", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 418, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3843), "Error number: 418", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 417, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3819), "Error number: 417", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 416, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3796), "Error number: 416", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 415, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3772), "Error number: 415", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 414, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3748), "Error number: 414", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 413, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3725), "Error number: 413", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 412, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3701), "Error number: 412", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 411, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3678), "Error number: 411", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 410, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3654), "Error number: 410", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 409, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3626), "Error number: 409", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 422, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(3938), "Error number: 422", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 251, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9685), "Error number: 251", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 250, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9661), "Error number: 250", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 249, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9637), "Error number: 249", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 91, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5772), "Error number: 91", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 90, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5743), "Error number: 90", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 89, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5720), "Error number: 89", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 88, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5696), "Error number: 88", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 87, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5672), "Error number: 87", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 86, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5649), "Error number: 86", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 85, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5626), "Error number: 85", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 84, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5601), "Error number: 84", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 83, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5578), "Error number: 83", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 82, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5554), "Error number: 82", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 81, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5531), "Error number: 81", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 80, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5507), "Error number: 80", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 79, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5483), "Error number: 79", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 78, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5460), "Error number: 78", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 77, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5436), "Error number: 77", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 76, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5412), "Error number: 76", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 75, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5389), "Error number: 75", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 74, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5365), "Error number: 74", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 73, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5341), "Error number: 73", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 72, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5318), "Error number: 72", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 71, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5295), "Error number: 71", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 70, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5270), "Error number: 70", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 69, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5246), "Error number: 69", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 68, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5223), "Error number: 68", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 67, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5200), "Error number: 67", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 66, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5176), "Error number: 66", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 65, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5129), "Error number: 65", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 92, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5791), "Error number: 92", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 64, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5110), "Error number: 64", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 93, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5819), "Error number: 93", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 95, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5867), "Error number: 95", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 122, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6529), "Error number: 122", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 121, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6505), "Error number: 121", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 120, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6481), "Error number: 120", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 119, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6458), "Error number: 119", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 118, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6434), "Error number: 118", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 117, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6411), "Error number: 117", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 116, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6387), "Error number: 116", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 115, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6364), "Error number: 115", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 114, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6339), "Error number: 114", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 113, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6316), "Error number: 113", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 112, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6293), "Error number: 112", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 111, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6268), "Error number: 111", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 110, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6245), "Error number: 110", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 109, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6221), "Error number: 109", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 108, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6198), "Error number: 108", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 107, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6174), "Error number: 107", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 106, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6150), "Error number: 106", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 105, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6123), "Error number: 105", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 104, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6098), "Error number: 104", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 103, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6080), "Error number: 103", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 102, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6056), "Error number: 102", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 101, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6028), "Error number: 101", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 100, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6003), "Error number: 100", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 99, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5980), "Error number: 99", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 98, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5938), "Error number: 98", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 97, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5913), "Error number: 97", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 96, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5890), "Error number: 96", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 94, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5843), "Error number: 94", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 63, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5081), "Error number: 63", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 62, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5058), "Error number: 62", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 61, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5034), "Error number: 61", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 28, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4220), "Error number: 28", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 27, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4197), "Error number: 27", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 26, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4173), "Error number: 26", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 25, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4149), "Error number: 25", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 24, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4125), "Error number: 24", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 23, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4102), "Error number: 23", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 22, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4078), "Error number: 22", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 21, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4055), "Error number: 21", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 20, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4030), "Error number: 20", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 19, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4012), "Error number: 19", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 18, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3984), "Error number: 18", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 17, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3960), "Error number: 17", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 16, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3936), "Error number: 16", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 15, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3912), "Error number: 15", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 14, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3889), "Error number: 14", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 13, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3870), "Error number: 13", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 12, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3846), "Error number: 12", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 11, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3823), "Error number: 11", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 10, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3794), "Error number: 10", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 9, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3771), "Error number: 9", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 8, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3747), "Error number: 8", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 7, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3724), "Error number: 7", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 6, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3699), "Error number: 6", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 5, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3671), "Error number: 5", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 4, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3643), "Error number: 4", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 3, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3619), "Error number: 3", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 2, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(3590), "Error number: 2", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 29, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4244), "Error number: 29", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 30, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4296), "Error number: 30", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 31, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4320), "Error number: 31", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 32, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4348), "Error number: 32", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 60, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(5010), "Error number: 60", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 59, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4987), "Error number: 59", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 58, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4963), "Error number: 58", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 57, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4939), "Error number: 57", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 56, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4915), "Error number: 56", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 55, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4892), "Error number: 55", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 54, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4868), "Error number: 54", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 53, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4845), "Error number: 53", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 52, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4821), "Error number: 52", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 51, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4798), "Error number: 51", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 50, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4774), "Error number: 50", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 49, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4750), "Error number: 49", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 48, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4727), "Error number: 48", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 123, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6552), "Error number: 123", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 47, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4703), "Error number: 47", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 45, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4656), "Error number: 45", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 44, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4632), "Error number: 44", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 43, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4608), "Error number: 43", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 42, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4584), "Error number: 42", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 41, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4561), "Error number: 41", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 40, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4537), "Error number: 40", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 39, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4513), "Error number: 39", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 38, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4490), "Error number: 38", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 37, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4466), "Error number: 37", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 36, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4443), "Error number: 36", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 35, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4419), "Error number: 35", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 34, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4395), "Error number: 34", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 33, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4371), "Error number: 33", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 46, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(4679), "Error number: 46", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 124, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6576), "Error number: 124", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 125, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6600), "Error number: 125", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 126, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6624), "Error number: 126", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 216, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8833), "Error number: 216", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 215, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8809), "Error number: 215", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 214, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8781), "Error number: 214", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 213, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8758), "Error number: 213", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 212, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8734), "Error number: 212", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 211, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8710), "Error number: 211", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 210, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8687), "Error number: 210", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 209, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8663), "Error number: 209", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 208, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8639), "Error number: 208", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 207, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8616), "Error number: 207", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 206, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8592), "Error number: 206", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 205, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8568), "Error number: 205", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 204, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8544), "Error number: 204", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 203, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8521), "Error number: 203", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 202, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8497), "Error number: 202", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 201, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8473), "Error number: 201", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 200, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8450), "Error number: 200", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 199, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8426), "Error number: 199", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 198, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8403), "Error number: 198", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 197, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8379), "Error number: 197", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 196, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8355), "Error number: 196", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 195, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8331), "Error number: 195", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 194, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8289), "Error number: 194", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 193, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8266), "Error number: 193", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 192, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8241), "Error number: 192", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 191, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8218), "Error number: 191", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 190, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8194), "Error number: 190", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 217, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8856), "Error number: 217", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 218, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8875), "Error number: 218", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 219, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8904), "Error number: 219", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 220, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8923), "Error number: 220", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 248, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9614), "Error number: 248", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 247, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9591), "Error number: 247", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 246, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9566), "Error number: 246", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 245, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9542), "Error number: 245", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 244, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9519), "Error number: 244", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 243, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9491), "Error number: 243", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 242, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9472), "Error number: 242", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 241, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9448), "Error number: 241", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 240, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9420), "Error number: 240", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 239, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9396), "Error number: 239", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 238, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9372), "Error number: 238", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 237, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9349), "Error number: 237", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 236, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9325), "Error number: 236", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 189, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8166), "Error number: 189", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 235, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9301), "Error number: 235", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 233, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9255), "Error number: 233", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 232, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9230), "Error number: 232", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 231, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9206), "Error number: 231", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 230, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9164), "Error number: 230", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 229, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9140), "Error number: 229", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 228, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9116), "Error number: 228", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 227, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9094), "Error number: 227", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 226, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9070), "Error number: 226", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 225, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9046), "Error number: 225", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 224, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9023), "Error number: 224", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 223, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8999), "Error number: 223", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 222, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8975), "Error number: 222", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 221, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8951), "Error number: 221", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 234, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(9278), "Error number: 234", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 499, new DateTime(2021, 4, 9, 19, 41, 38, 285, DateTimeKind.Local).AddTicks(5835), "Error number: 499", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 188, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8142), "Error number: 188", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 186, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8095), "Error number: 186", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 153, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7291), "Error number: 153", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 152, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7268), "Error number: 152", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 151, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7243), "Error number: 151", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 150, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7219), "Error number: 150", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 149, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7196), "Error number: 149", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 148, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7172), "Error number: 148", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 147, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7148), "Error number: 147", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 146, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7125), "Error number: 146", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 145, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7101), "Error number: 145", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 144, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7078), "Error number: 144", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 143, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7054), "Error number: 143", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 142, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7031), "Error number: 142", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 141, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7006), "Error number: 141", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 140, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6983), "Error number: 140", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 139, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6960), "Error number: 139", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 138, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6936), "Error number: 138", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 137, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6912), "Error number: 137", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 136, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6888), "Error number: 136", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 135, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6860), "Error number: 135", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 134, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6837), "Error number: 134", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 133, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6813), "Error number: 133", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 132, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6789), "Error number: 132", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 131, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6765), "Error number: 131", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 130, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6742), "Error number: 130", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 129, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6695), "Error number: 129", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 128, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6675), "Error number: 128", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 127, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(6652), "Error number: 127", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 154, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7314), "Error number: 154", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 155, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7338), "Error number: 155", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 156, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7362), "Error number: 156", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 157, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7390), "Error number: 157", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 185, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8071), "Error number: 185", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 184, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8048), "Error number: 184", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 183, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8024), "Error number: 183", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 182, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8000), "Error number: 182", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 181, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7976), "Error number: 181", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 180, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7953), "Error number: 180", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 179, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7930), "Error number: 179", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 178, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7905), "Error number: 178", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 177, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7882), "Error number: 177", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 176, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7859), "Error number: 176", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 175, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7835), "Error number: 175", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 174, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7811), "Error number: 174", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 173, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7788), "Error number: 173", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 187, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(8119), "Error number: 187", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 172, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7764), "Error number: 172", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 170, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7717), "Error number: 170", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 169, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7693), "Error number: 169", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 168, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7669), "Error number: 168", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 167, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7645), "Error number: 167", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 166, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7622), "Error number: 166", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 165, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7598), "Error number: 165", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 164, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7574), "Error number: 164", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 163, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7550), "Error number: 163", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 162, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7527), "Error number: 162", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 161, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7503), "Error number: 161", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 160, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7480), "Error number: 160", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 159, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7438), "Error number: 159", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 158, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7414), "Error number: 158", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 171, new DateTime(2021, 4, 9, 19, 41, 38, 284, DateTimeKind.Local).AddTicks(7740), "Error number: 171", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("73c5b736-8639-435e-9f07-e94557c91f55"), "AQAAAAEAACcQAAAAEO9WZ94JNXQOobqjInTVulpR4xqEhYpOzGchxoU4wmnegaVqKoiUuRkp44R8PclcdA==", "Dashboard" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73c5b736-8639-435e-9f07-e94557c91f55"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("6a8e303f-e53c-43db-a934-2bfc9509e639"), "AQAAAAEAACcQAAAAEAskc5U/1Go51MDCofosdsbF8a3AQCCgE9y5us7kj4TImEvjE4pHIlYabzI8sycY1A==", "Dashboard" });
        }
    }
}
