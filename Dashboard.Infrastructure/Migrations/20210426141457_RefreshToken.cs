using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Infrastructure.Migrations
{
    public partial class RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ed05546-4f4a-4d30-8d1d-dbde32c58409"));

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiry",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 201,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 202,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 203,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 204,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 205,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 206,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 207,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 208,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 209,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 210,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 211,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 212,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 213,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 214,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 215,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 216,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 217,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 218,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 219,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 220,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 221,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 222,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 223,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 224,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 225,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 226,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 227,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 228,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 229,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 230,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 231,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 232,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 233,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 234,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 235,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 236,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 237,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 919, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 238,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 239,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 240,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 241,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 242,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 243,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 244,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 245,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 246,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 247,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 248,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 249,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 250,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 251,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 252,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 253,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 254,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 255,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 256,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 257,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 258,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 259,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 260,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 261,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 262,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 263,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 264,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 265,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 266,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 267,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 268,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 269,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 270,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 271,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 272,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 273,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 274,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 275,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 276,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 277,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 278,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 279,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 280,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 281,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 282,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 283,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 284,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 285,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 286,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 287,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 288,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 289,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 290,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 291,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 292,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 293,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 294,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 295,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 296,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 297,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 298,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 299,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 300,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 301,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 302,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 303,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 304,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 305,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 306,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 307,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 308,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 309,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 310,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 311,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 312,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 313,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 314,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 315,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 316,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 317,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 318,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 319,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 320,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 321,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 322,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 323,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 324,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 325,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 326,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 327,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 328,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 329,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 330,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 331,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 332,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 333,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 334,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 335,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 336,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 337,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 338,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 339,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 340,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 341,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 342,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 343,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 344,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 345,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 346,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 347,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 348,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 349,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 350,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 351,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 352,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 353,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 354,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 355,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 356,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 357,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 358,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 359,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 360,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 361,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 362,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 363,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 364,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 365,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 366,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 367,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 368,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 369,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 370,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 371,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 372,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 373,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 374,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 375,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 376,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 377,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 378,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 379,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 380,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 381,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 382,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 383,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 384,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 385,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 386,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 387,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 388,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 389,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 390,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 391,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 392,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 393,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 394,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 395,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 396,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 397,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 398,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 399,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 400,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 401,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 402,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 403,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 404,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 405,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 406,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 407,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 408,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 409,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 410,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 411,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 412,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 413,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 414,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 415,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 416,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 417,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 418,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 419,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 420,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 421,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 422,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 423,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 424,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 425,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 426,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 427,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 428,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 429,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 430,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 431,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 432,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 433,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 434,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 435,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 436,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 437,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 438,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 439,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 440,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 441,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 442,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 443,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 444,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 445,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 446,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 447,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 448,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 449,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 450,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 451,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 452,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 453,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 454,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 455,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 456,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 457,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 458,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 459,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 460,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 461,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 462,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 463,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 464,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 465,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 466,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 467,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 468,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 469,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 470,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 471,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 472,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 473,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 474,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 475,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 476,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 477,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 478,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 479,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 480,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 481,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 482,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 483,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 484,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 485,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 486,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 487,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 488,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 489,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 490,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 491,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 492,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 493,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 494,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 495,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 496,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 497,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 498,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 499,
                column: "Date",
                value: new DateTime(2021, 4, 26, 16, 14, 56, 920, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "RefreshToken", "RefreshTokenExpiry", "Username" },
                values: new object[] { new Guid("0ec870d9-f1a0-40ff-98b2-35df40b0b728"), true, "AQAAAAEAACcQAAAAEKszcLyPC0BBJ12SuDky5uNU1TmF0JchXqp9LnjIQmPnwkcQfoZfjSM6Fpko0dFeSg==", null, null, "Dashboard" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec870d9-f1a0-40ff-98b2-35df40b0b728"));

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiry",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 331, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 201,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 202,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 203,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 204,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 205,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 206,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 207,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 208,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 209,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 210,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 211,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 212,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 213,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 214,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 215,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 216,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 217,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 218,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 219,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 220,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 221,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 222,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 223,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 224,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 225,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 226,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 227,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 228,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 229,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 230,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 231,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 232,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 233,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 234,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 235,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 236,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 237,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 238,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 239,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 240,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 241,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 242,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 243,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 244,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 245,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 246,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 247,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 248,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 249,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 250,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 251,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 252,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 253,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 254,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 255,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 256,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 257,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 258,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 259,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 260,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 261,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 262,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 263,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 264,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 265,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 266,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 267,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 268,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 269,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 270,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 271,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 272,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 273,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 274,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 275,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 276,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 277,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 278,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 279,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 280,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 281,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 282,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 283,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 284,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 285,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 286,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 287,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 288,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 289,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 290,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 291,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 292,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 293,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 294,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 295,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 296,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 297,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 298,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 299,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 300,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 301,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 302,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 303,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 304,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 305,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 306,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 307,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 308,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 309,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 310,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 311,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 312,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 313,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 314,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 315,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 316,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 317,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 318,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 319,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 320,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 321,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 322,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 323,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 324,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 325,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 326,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 327,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 328,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 329,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 330,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 331,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 332,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 333,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 334,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 335,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 336,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 337,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 338,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 339,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 340,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 341,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 342,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 343,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 344,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 345,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 346,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 347,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 348,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 349,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 350,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 351,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 352,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 353,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 354,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 355,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 356,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 357,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 358,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 359,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 360,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 361,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 362,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 363,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 364,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 365,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 366,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 367,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 368,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 369,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 370,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 371,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 372,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 373,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 374,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 375,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 376,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 377,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 378,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 379,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 380,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 381,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 382,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 383,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 384,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 385,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 386,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 387,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 388,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 389,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 390,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 391,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 392,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 393,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 394,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 395,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 396,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 397,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 398,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 332, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 399,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 400,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 401,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 402,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 403,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 404,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 405,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 406,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 407,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 408,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 409,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 410,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 411,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 412,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 413,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 414,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 415,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 416,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 417,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 418,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 419,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 420,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 421,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 422,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 423,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 424,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 425,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 426,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 427,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 428,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 429,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 430,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 431,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 432,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 433,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 434,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 435,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 436,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 437,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 438,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 439,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 440,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 441,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 442,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 443,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 444,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 445,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 446,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 447,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 448,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 449,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 450,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 451,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 452,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 453,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 454,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 455,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 456,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 457,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 458,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 459,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 460,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 461,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 462,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 463,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 464,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 465,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 466,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 467,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 468,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 469,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 470,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 471,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 472,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 473,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 474,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 475,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 476,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 477,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 478,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 479,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 480,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 481,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 482,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 483,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 484,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 485,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 486,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 487,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 488,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 489,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 490,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 491,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 492,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 493,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 494,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 495,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 496,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 497,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 498,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 499,
                column: "Date",
                value: new DateTime(2021, 4, 26, 14, 23, 23, 333, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "Username" },
                values: new object[] { new Guid("3ed05546-4f4a-4d30-8d1d-dbde32c58409"), true, "AQAAAAEAACcQAAAAEB7dPm4G8SmAMpSooIn1uP2S7VTOkw39oNHy3/xd/y0nWjf4JiQZnladW+TjRmoj2Q==", "Dashboard" });
        }
    }
}
