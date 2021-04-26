using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Infrastructure.Migrations
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 1, new DateTime(2021, 4, 26, 14, 23, 23, 331, DateTimeKind.Local).AddTicks(9648), "Error number: 1", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 342, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8486), "Error number: 342", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 341, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8467), "Error number: 341", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 340, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8443), "Error number: 340", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 339, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8420), "Error number: 339", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 338, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8396), "Error number: 338", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 337, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8372), "Error number: 337", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 336, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8343), "Error number: 336", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 335, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8320), "Error number: 335", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 334, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8297), "Error number: 334", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 333, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8273), "Error number: 333", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 332, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8249), "Error number: 332", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 331, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8225), "Error number: 331", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 330, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8197), "Error number: 330", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 329, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8173), "Error number: 329", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 328, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8131), "Error number: 328", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 327, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8102), "Error number: 327", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 326, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8079), "Error number: 326", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 325, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8056), "Error number: 325", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 324, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8031), "Error number: 324", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 323, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8003), "Error number: 323", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 322, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7980), "Error number: 322", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 321, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7956), "Error number: 321", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 320, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7932), "Error number: 320", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 319, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7908), "Error number: 319", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 318, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7885), "Error number: 318", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 317, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7861), "Error number: 317", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 316, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7837), "Error number: 316", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 343, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8509), "Error number: 343", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 315, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7809), "Error number: 315", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 344, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8538), "Error number: 344", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 346, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8580), "Error number: 346", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 373, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9309), "Error number: 373", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 372, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9281), "Error number: 372", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 371, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9256), "Error number: 371", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 370, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9233), "Error number: 370", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 369, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9209), "Error number: 369", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 368, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9186), "Error number: 368", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 367, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9157), "Error number: 367", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 366, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9134), "Error number: 366", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 365, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9110), "Error number: 365", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 364, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9087), "Error number: 364", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 363, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8996), "Error number: 363", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 362, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8969), "Error number: 362", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 361, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8945), "Error number: 361", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 360, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8921), "Error number: 360", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 359, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8897), "Error number: 359", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 358, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8869), "Error number: 358", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 357, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8845), "Error number: 357", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 356, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8822), "Error number: 356", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 355, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8798), "Error number: 355", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 354, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8769), "Error number: 354", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 353, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8746), "Error number: 353", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 352, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8723), "Error number: 352", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 351, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8698), "Error number: 351", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 350, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8674), "Error number: 350", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 349, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8651), "Error number: 349", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 348, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8628), "Error number: 348", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 347, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8604), "Error number: 347", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 345, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8557), "Error number: 345", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 314, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7785), "Error number: 314", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 313, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7762), "Error number: 313", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 312, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7734), "Error number: 312", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 279, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6924), "Error number: 279", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 278, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6901), "Error number: 278", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 277, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6877), "Error number: 277", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 276, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6853), "Error number: 276", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 275, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6830), "Error number: 275", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 274, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6806), "Error number: 274", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 273, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6782), "Error number: 273", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 272, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6759), "Error number: 272", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 271, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6736), "Error number: 271", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 270, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6711), "Error number: 270", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 269, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6688), "Error number: 269", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 268, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6664), "Error number: 268", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 267, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6641), "Error number: 267", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 266, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6612), "Error number: 266", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 265, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6588), "Error number: 265", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 264, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6565), "Error number: 264", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 263, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6546), "Error number: 263", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 262, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6522), "Error number: 262", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 261, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6494), "Error number: 261", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 260, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6474), "Error number: 260", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 259, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6447), "Error number: 259", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 258, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6405), "Error number: 258", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 257, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6380), "Error number: 257", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 256, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6356), "Error number: 256", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 255, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6333), "Error number: 255", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 254, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6310), "Error number: 254", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 253, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6285), "Error number: 253", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 280, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6948), "Error number: 280", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 281, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6972), "Error number: 281", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 282, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6996), "Error number: 282", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 283, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7019), "Error number: 283", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 311, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7710), "Error number: 311", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 310, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7686), "Error number: 310", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 309, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7667), "Error number: 309", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 308, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7639), "Error number: 308", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 307, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7620), "Error number: 307", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 306, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7596), "Error number: 306", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 305, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7568), "Error number: 305", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 304, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7544), "Error number: 304", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 303, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7520), "Error number: 303", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 302, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7497), "Error number: 302", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 301, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7473), "Error number: 301", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 300, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7449), "Error number: 300", "System number: 300" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 299, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7426), "Error number: 299", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 374, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9337), "Error number: 374", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 298, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7403), "Error number: 298", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 296, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7354), "Error number: 296", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 295, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7331), "Error number: 295", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 294, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7308), "Error number: 294", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 293, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7260), "Error number: 293", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 292, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7232), "Error number: 292", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 291, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7208), "Error number: 291", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 290, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7185), "Error number: 290", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 289, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7161), "Error number: 289", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 288, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7138), "Error number: 288", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 287, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7114), "Error number: 287", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 286, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7090), "Error number: 286", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 285, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7067), "Error number: 285", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 284, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7038), "Error number: 284", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 297, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7378), "Error number: 297", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 252, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6262), "Error number: 252", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 375, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9361), "Error number: 375", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 377, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9408), "Error number: 377", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 467, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1712), "Error number: 467", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 466, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1690), "Error number: 466", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 465, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1665), "Error number: 465", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 464, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1641), "Error number: 464", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 463, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1618), "Error number: 463", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 462, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1590), "Error number: 462", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 461, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1565), "Error number: 461", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 460, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1542), "Error number: 460", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 459, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1519), "Error number: 459", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 458, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1495), "Error number: 458", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 457, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1471), "Error number: 457", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 456, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1448), "Error number: 456", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 455, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1423), "Error number: 455", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 454, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1400), "Error number: 454", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 453, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1377), "Error number: 453", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 452, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1353), "Error number: 452", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 451, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1329), "Error number: 451", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 450, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1305), "Error number: 450", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 449, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1282), "Error number: 449", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 448, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1258), "Error number: 448", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 447, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1234), "Error number: 447", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 446, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1210), "Error number: 446", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 445, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1182), "Error number: 445", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 444, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1159), "Error number: 444", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 443, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1135), "Error number: 443", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 442, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1112), "Error number: 442", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 441, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1088), "Error number: 441", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 468, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1736), "Error number: 468", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 440, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1060), "Error number: 440", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 469, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1759), "Error number: 469", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 471, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1826), "Error number: 471", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 498, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2479), "Error number: 498", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 497, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2455), "Error number: 497", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 496, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2427), "Error number: 496", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 495, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2408), "Error number: 495", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 494, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2384), "Error number: 494", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 493, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2356), "Error number: 493", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 492, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2332), "Error number: 492", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 491, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2308), "Error number: 491", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 490, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2285), "Error number: 490", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 489, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2262), "Error number: 489", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 488, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2242), "Error number: 488", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 487, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2218), "Error number: 487", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 486, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2190), "Error number: 486", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 485, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2167), "Error number: 485", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 484, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2143), "Error number: 484", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 483, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2119), "Error number: 483", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 482, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2096), "Error number: 482", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 481, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2072), "Error number: 481", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 480, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2048), "Error number: 480", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 479, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2021), "Error number: 479", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 478, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1991), "Error number: 478", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 477, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1968), "Error number: 477", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 476, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1944), "Error number: 476", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 475, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1921), "Error number: 475", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 474, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1896), "Error number: 474", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 473, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1873), "Error number: 473", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 472, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1849), "Error number: 472", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 470, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1802), "Error number: 470", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 439, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1036), "Error number: 439", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 438, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1012), "Error number: 438", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 437, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(988), "Error number: 437", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 404, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(165), "Error number: 404", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 403, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(142), "Error number: 403", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 402, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(118), "Error number: 402", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 401, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(94), "Error number: 401", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 400, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(71), "Error number: 400", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 399, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(23), "Error number: 399", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 398, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9999), "Error number: 398", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 397, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9976), "Error number: 397", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 396, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9948), "Error number: 396", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 395, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9924), "Error number: 395", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 394, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9900), "Error number: 394", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 393, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9872), "Error number: 393", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 392, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9848), "Error number: 392", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 391, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9815), "Error number: 391", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 390, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9787), "Error number: 390", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 389, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9758), "Error number: 389", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 388, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9730), "Error number: 388", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 387, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9702), "Error number: 387", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 386, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9678), "Error number: 386", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 385, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9640), "Error number: 385", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 384, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9602), "Error number: 384", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 383, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9573), "Error number: 383", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 382, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9541), "Error number: 382", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 381, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9512), "Error number: 381", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 380, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9484), "Error number: 380", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 379, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9456), "Error number: 379", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 378, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9436), "Error number: 378", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 405, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(189), "Error number: 405", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 406, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(217), "Error number: 406", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 407, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(241), "Error number: 407", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 408, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(265), "Error number: 408", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 436, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(969), "Error number: 436", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 435, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(942), "Error number: 435", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 434, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(903), "Error number: 434", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 433, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(879), "Error number: 433", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 432, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(856), "Error number: 432", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 431, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(828), "Error number: 431", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 430, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(804), "Error number: 430", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 429, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(776), "Error number: 429", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 428, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(752), "Error number: 428", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 427, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(728), "Error number: 427", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 426, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(705), "Error number: 426", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 425, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(681), "Error number: 425", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 424, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(657), "Error number: 424", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 376, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9385), "Error number: 376", "System number: 350" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 423, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(634), "Error number: 423", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 421, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(581), "Error number: 421", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 420, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(553), "Error number: 420", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 419, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(529), "Error number: 419", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 418, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(511), "Error number: 418", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 417, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(482), "Error number: 417", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 416, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(459), "Error number: 416", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 415, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(434), "Error number: 415", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 414, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(407), "Error number: 414", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 413, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(383), "Error number: 413", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 412, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(360), "Error number: 412", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 411, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(335), "Error number: 411", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 410, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(312), "Error number: 410", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 409, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(289), "Error number: 409", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 422, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(610), "Error number: 422", "System number: 400" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 251, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6239), "Error number: 251", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 250, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6215), "Error number: 250", "System number: 250" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 249, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6191), "Error number: 249", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 91, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2269), "Error number: 91", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 90, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2240), "Error number: 90", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 89, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2222), "Error number: 89", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 88, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2198), "Error number: 88", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 87, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2174), "Error number: 87", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 86, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2151), "Error number: 86", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 85, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2127), "Error number: 85", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 84, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2103), "Error number: 84", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 83, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2079), "Error number: 83", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 82, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2056), "Error number: 82", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 81, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2033), "Error number: 81", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 80, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2008), "Error number: 80", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 79, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1985), "Error number: 79", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 78, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1962), "Error number: 78", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 77, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1938), "Error number: 77", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 76, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1914), "Error number: 76", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 75, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1891), "Error number: 75", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 74, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1867), "Error number: 74", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 73, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1838), "Error number: 73", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 72, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1796), "Error number: 72", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 71, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1767), "Error number: 71", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 70, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1748), "Error number: 70", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 69, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1720), "Error number: 69", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 68, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1697), "Error number: 68", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 67, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1673), "Error number: 67", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 66, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1649), "Error number: 66", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 65, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1625), "Error number: 65", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 92, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2288), "Error number: 92", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 64, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1597), "Error number: 64", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 93, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2316), "Error number: 93", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 95, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2359), "Error number: 95", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 122, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3059), "Error number: 122", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 121, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3036), "Error number: 121", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 120, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3012), "Error number: 120", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 119, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2988), "Error number: 119", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 118, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2959), "Error number: 118", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 117, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2936), "Error number: 117", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 116, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2912), "Error number: 116", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 115, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2893), "Error number: 115", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 114, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2870), "Error number: 114", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 113, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2841), "Error number: 113", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 112, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2818), "Error number: 112", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 111, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2795), "Error number: 111", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 110, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2771), "Error number: 110", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 109, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2746), "Error number: 109", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 108, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2704), "Error number: 108", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 107, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2681), "Error number: 107", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 106, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2656), "Error number: 106", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 105, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2628), "Error number: 105", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 104, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2577), "Error number: 104", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 103, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2553), "Error number: 103", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 102, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2529), "Error number: 102", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 101, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2501), "Error number: 101", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 100, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2477), "Error number: 100", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 99, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2458), "Error number: 99", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 98, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2430), "Error number: 98", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 97, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2406), "Error number: 97", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 96, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2387), "Error number: 96", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 94, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2335), "Error number: 94", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 63, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1578), "Error number: 63", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 62, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1554), "Error number: 62", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 61, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1526), "Error number: 61", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 28, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(688), "Error number: 28", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 27, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(660), "Error number: 27", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 26, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(637), "Error number: 26", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 25, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(613), "Error number: 25", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 24, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(585), "Error number: 24", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 23, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(561), "Error number: 23", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 22, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(538), "Error number: 22", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 21, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(518), "Error number: 21", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 20, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(495), "Error number: 20", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 19, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(467), "Error number: 19", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 18, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(447), "Error number: 18", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 17, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(419), "Error number: 17", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 16, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(391), "Error number: 16", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 15, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(367), "Error number: 15", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 14, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(343), "Error number: 14", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 13, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(319), "Error number: 13", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 12, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(296), "Error number: 12", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 11, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(272), "Error number: 11", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 10, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(248), "Error number: 10", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 9, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(221), "Error number: 9", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 8, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(197), "Error number: 8", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 7, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(173), "Error number: 7", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 6, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(145), "Error number: 6", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 5, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(116), "Error number: 5", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 4, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(92), "Error number: 4", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 3, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(69), "Error number: 3", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 2, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(46), "Error number: 2", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 29, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(713), "Error number: 29", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 30, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(736), "Error number: 30", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 31, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(759), "Error number: 31", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 32, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(783), "Error number: 32", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 60, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1503), "Error number: 60", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 59, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1483), "Error number: 59", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 58, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1456), "Error number: 58", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 57, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1436), "Error number: 57", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 56, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1412), "Error number: 56", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 55, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1385), "Error number: 55", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 54, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1361), "Error number: 54", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 53, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1336), "Error number: 53", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 52, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1313), "Error number: 52", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 51, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1290), "Error number: 51", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 50, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1266), "Error number: 50", "System number: 50" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 49, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1242), "Error number: 49", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 48, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1214), "Error number: 48", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 123, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3082), "Error number: 123", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 47, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1185), "Error number: 47", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 45, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1143), "Error number: 45", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 44, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1115), "Error number: 44", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 43, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1090), "Error number: 43", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 42, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1067), "Error number: 42", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 41, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1044), "Error number: 41", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 40, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1015), "Error number: 40", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 39, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(954), "Error number: 39", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 38, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(930), "Error number: 38", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 37, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(906), "Error number: 37", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 36, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(883), "Error number: 36", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 35, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(859), "Error number: 35", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 34, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(835), "Error number: 34", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 33, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(812), "Error number: 33", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 46, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1162), "Error number: 46", "System number: 0" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 124, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3102), "Error number: 124", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 125, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3126), "Error number: 125", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 126, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3154), "Error number: 126", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 216, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5386), "Error number: 216", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 215, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5363), "Error number: 215", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 214, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5340), "Error number: 214", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 213, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5311), "Error number: 213", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 212, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5292), "Error number: 212", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 211, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5264), "Error number: 211", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 210, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5240), "Error number: 210", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 209, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5217), "Error number: 209", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 208, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5193), "Error number: 208", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 207, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5169), "Error number: 207", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 206, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5145), "Error number: 206", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 205, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5103), "Error number: 205", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 204, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5080), "Error number: 204", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 203, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5055), "Error number: 203", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 202, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5032), "Error number: 202", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 201, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5009), "Error number: 201", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 200, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4980), "Error number: 200", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 199, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4956), "Error number: 199", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 198, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4933), "Error number: 198", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 197, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4909), "Error number: 197", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 196, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4885), "Error number: 196", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 195, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4857), "Error number: 195", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 194, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4833), "Error number: 194", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 193, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4809), "Error number: 193", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 192, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4786), "Error number: 192", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 191, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4763), "Error number: 191", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 190, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4738), "Error number: 190", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 217, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5411), "Error number: 217", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 218, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5435), "Error number: 218", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 219, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5458), "Error number: 219", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 220, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5476), "Error number: 220", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 248, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6168), "Error number: 248", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 247, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6143), "Error number: 247", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 246, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6120), "Error number: 246", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 245, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6092), "Error number: 245", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 244, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6068), "Error number: 244", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 243, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6044), "Error number: 243", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 242, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6021), "Error number: 242", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 241, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5997), "Error number: 241", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 240, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5954), "Error number: 240", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 239, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5930), "Error number: 239", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 238, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5907), "Error number: 238", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 237, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5883), "Error number: 237", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 236, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5860), "Error number: 236", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 189, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4714), "Error number: 189", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 235, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5832), "Error number: 235", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 233, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5784), "Error number: 233", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 232, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5761), "Error number: 232", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 231, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5737), "Error number: 231", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 230, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5713), "Error number: 230", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 229, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5689), "Error number: 229", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 228, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5666), "Error number: 228", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 227, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5642), "Error number: 227", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 226, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5618), "Error number: 226", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 225, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5595), "Error number: 225", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 224, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5571), "Error number: 224", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 223, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5552), "Error number: 223", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 222, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5528), "Error number: 222", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 221, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5501), "Error number: 221", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 234, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5808), "Error number: 234", "System number: 200" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 499, new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2502), "Error number: 499", "System number: 450" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 188, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4687), "Error number: 188", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 186, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4639), "Error number: 186", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 153, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3816), "Error number: 153", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 152, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3797), "Error number: 152", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 151, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3770), "Error number: 151", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 150, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3745), "Error number: 150", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 149, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3721), "Error number: 149", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 148, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3698), "Error number: 148", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 147, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3675), "Error number: 147", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 146, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3650), "Error number: 146", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 145, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3627), "Error number: 145", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 144, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3603), "Error number: 144", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 143, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3580), "Error number: 143", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 142, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3556), "Error number: 142", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 141, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3532), "Error number: 141", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 140, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3503), "Error number: 140", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 139, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3480), "Error number: 139", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 138, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3457), "Error number: 138", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 137, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3433), "Error number: 137", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 136, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3409), "Error number: 136", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 135, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3367), "Error number: 135", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 134, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3343), "Error number: 134", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 133, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3319), "Error number: 133", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 132, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3295), "Error number: 132", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 131, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3272), "Error number: 131", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 130, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3248), "Error number: 130", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 129, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3225), "Error number: 129", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 128, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3201), "Error number: 128", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 127, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3178), "Error number: 127", "System number: 100" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 154, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3839), "Error number: 154", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 155, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3868), "Error number: 155", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 156, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3892), "Error number: 156", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 157, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3915), "Error number: 157", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 185, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4615), "Error number: 185", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 184, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4592), "Error number: 184", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 183, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4563), "Error number: 183", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 182, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4540), "Error number: 182", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 181, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4517), "Error number: 181", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 180, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4488), "Error number: 180", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 179, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4464), "Error number: 179", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 178, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4441), "Error number: 178", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 177, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4417), "Error number: 177", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 176, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4393), "Error number: 176", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 175, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4369), "Error number: 175", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 174, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4342), "Error number: 174", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 173, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4317), "Error number: 173", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 187, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4663), "Error number: 187", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 172, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4298), "Error number: 172", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 170, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4228), "Error number: 170", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 169, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4204), "Error number: 169", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 168, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4181), "Error number: 168", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 167, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4156), "Error number: 167", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 166, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4128), "Error number: 166", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 165, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4105), "Error number: 165", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 164, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4081), "Error number: 164", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 163, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4057), "Error number: 163", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 162, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4034), "Error number: 162", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 161, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4006), "Error number: 161", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 160, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3981), "Error number: 160", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 159, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3958), "Error number: 159", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 158, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3939), "Error number: 158", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 171, new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4270), "Error number: 171", "System number: 150" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "Username" },
                values: new object[] { new Guid("3ed05546-4f4a-4d30-8d1d-dbde32c58409"), true, "AQAAAAEAACcQAAAAEB7dPm4G8SmAMpSooIn1uP2S7VTOkw39oNHy3/xd/y0nWjf4JiQZnladW+TjRmoj2Q==", "Dashboard" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
