using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    System = table.Column<string>(type: "TEXT", nullable: false),
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
                    Name = table.Column<string>(type: "TEXT", nullable: false)
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
                    Password = table.Column<string>(type: "TEXT", nullable: false),
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
                values: new object[] { 1, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(3980), "Error number: 1", "System number: 3848321d-0c8b-4ed9-8c2c-2db49ee43569" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 2, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(3987), "Error number: 2", "System number: b6c03ce0-6b57-4ac8-8a33-3d5b77beea42" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 3, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(3991), "Error number: 3", "System number: c4fe8f45-a598-4124-a1ff-e6aa2a7d068e" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 4, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(3995), "Error number: 4", "System number: f661292b-a5a6-4b8a-80d8-d685ec19e0b8" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 5, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4000), "Error number: 5", "System number: eafa2179-ba04-4733-a7d7-acd69adba60c" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 6, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4006), "Error number: 6", "System number: 9491f1f1-aac4-4842-ba49-bd0f5986359c" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 7, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4010), "Error number: 7", "System number: 89f4a597-0c3c-438c-9394-313e6d3b1e55" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 8, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4014), "Error number: 8", "System number: 5729329d-0d0c-4319-b246-4537f222ec13" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 9, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4020), "Error number: 9", "System number: 41e29a09-eab3-476c-bf7f-d3640de1fcae" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 10, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4026), "Error number: 10", "System number: 80eb793b-d571-4d65-bcec-8610db2bb3f7" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 11, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4030), "Error number: 11", "System number: 67cf31af-e0e6-4fb5-b5a7-e6770a90ea8a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 12, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4034), "Error number: 12", "System number: a5b8c67c-f20c-4bc4-9a35-88b6b8876b10" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 13, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4038), "Error number: 13", "System number: 9ceea228-227c-43b4-89cb-06ebcfbee49f" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 14, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4042), "Error number: 14", "System number: 81662a95-dd59-4df1-b152-97ca0c495236" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 15, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4046), "Error number: 15", "System number: 2a48828f-acfe-47b3-89a3-29adf86e44bf" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 16, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4050), "Error number: 16", "System number: d016341f-0df2-4d0a-a526-8b2476b5ac76" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 17, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4055), "Error number: 17", "System number: fbf2d44b-8b38-424f-8069-b07e2e57b127" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 18, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4060), "Error number: 18", "System number: 764f4f66-5f1d-4381-9611-91d75cb00102" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 19, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4086), "Error number: 19", "System number: 012edb58-3a47-48b8-b0f4-323b441cbcab" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 20, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4090), "Error number: 20", "System number: a138193a-1bc5-4af1-9458-8d82839cae61" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 21, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4094), "Error number: 21", "System number: 7f47c5b5-d751-4922-9c7f-faa0eeaa29ed" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 22, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4098), "Error number: 22", "System number: 7639d711-51c0-4298-ad85-c3430481fdc1" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 23, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4102), "Error number: 23", "System number: 0c822955-81f6-4265-8e46-43ba399cae48" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 24, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4106), "Error number: 24", "System number: dd3e22a6-fa2d-4b4a-a036-a125d6089a46" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 25, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4112), "Error number: 25", "System number: 99fc682d-6f6c-4764-9ff1-9cff85c7f0ae" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 26, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4116), "Error number: 26", "System number: b5545e90-8532-452b-b781-ffdd606d38cc" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 27, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4119), "Error number: 27", "System number: 4a12349f-342e-4180-8bc3-d1c197e7a4cd" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 28, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4123), "Error number: 28", "System number: 8a3f9212-d04b-4bbd-a6c0-c10531f5e94b" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 29, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4127), "Error number: 29", "System number: 03866970-92eb-409b-bb38-6ab633a38cfc" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 30, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4131), "Error number: 30", "System number: 2bcd58d5-8f54-4279-aea7-cb3600e79973" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 31, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4135), "Error number: 31", "System number: d6b6641b-e962-49e6-aee4-4153f19f122f" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 32, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4139), "Error number: 32", "System number: 6eb9744c-edf5-4dfb-9acd-1fd1c8e6608b" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 33, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4144), "Error number: 33", "System number: bebb1d75-c108-4af7-abbc-600db9439152" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 34, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4148), "Error number: 34", "System number: 1fb576d7-443c-44b6-9040-0233ce2d2362" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 35, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4152), "Error number: 35", "System number: 8792e939-4b67-4942-a649-96270835f37a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 36, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4156), "Error number: 36", "System number: e4fd0c36-17ae-4a56-98aa-bb786bffe4d9" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 37, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4160), "Error number: 37", "System number: 1928153b-dde2-4148-8b0b-aed73c8a78ed" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 38, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4164), "Error number: 38", "System number: 525a9779-4272-4ea5-9a11-4b9f7d876ed9" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 39, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4167), "Error number: 39", "System number: 9aa9355c-14ce-492e-b8a6-ab1654043798" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 40, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4194), "Error number: 40", "System number: 5c895b70-8326-4fd5-bdee-ed50497bf488" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 41, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4200), "Error number: 41", "System number: ed174d8e-95da-4924-93ed-e298be9d67cc" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 42, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4204), "Error number: 42", "System number: 0fb6b9bb-5aac-4d0a-a2c6-90b1dbd8fd23" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 43, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4208), "Error number: 43", "System number: 31a1df4b-99b1-4b65-9101-33bcaa6d527c" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 44, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4212), "Error number: 44", "System number: 9c819b8d-2b93-4c58-955a-1fc5cc98efb2" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 45, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4216), "Error number: 45", "System number: 46f2a402-ccad-4573-9381-0e514405c57b" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 46, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4219), "Error number: 46", "System number: d11f65ca-2911-41ee-87c3-241993ca2a6d" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 47, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4223), "Error number: 47", "System number: 7e237df5-1b1f-45ac-a218-34094143aa43" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 48, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4227), "Error number: 48", "System number: 1417dc5c-e4e8-40aa-af4e-74324c67ce35" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 49, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4232), "Error number: 49", "System number: b2f750ae-fab9-4efb-ae12-d07da24ce840" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 50, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4236), "Error number: 50", "System number: 62e033d8-ee01-49ef-8d22-c1db19c73c76" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 51, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4240), "Error number: 51", "System number: 62ed296b-725a-4a09-a355-56fa49d306ad" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 52, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4244), "Error number: 52", "System number: 073533c9-7001-49c9-9c85-3c114e56987a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 53, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4248), "Error number: 53", "System number: 1d5f867b-02a9-4cd9-a304-6f29d457535d" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 54, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4251), "Error number: 54", "System number: 090fb4e9-9633-47d2-92ed-2ec80ad0d767" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 55, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4255), "Error number: 55", "System number: e0e37f3f-8e4c-4381-a96b-26d07d4fc63a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 56, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4259), "Error number: 56", "System number: d695c2af-75ea-48d6-ad6e-908cb25b30bd" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 57, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4264), "Error number: 57", "System number: 582d194c-1290-4fd7-8a7a-cecb670b5bd8" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 58, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4268), "Error number: 58", "System number: 1ceadd69-cd4a-425c-9ca7-780d8dd1de9a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 59, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4272), "Error number: 59", "System number: a13ffb50-410c-4cde-87af-28ffe40baa45" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 60, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4276), "Error number: 60", "System number: a67bcc02-c1cb-4279-be76-20c8e8119ce2" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 61, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4279), "Error number: 61", "System number: 1321c738-9524-461e-8b60-ee1cdab8600b" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 62, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4283), "Error number: 62", "System number: 14f9dec5-6ce0-493d-9848-c29a9802a87d" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 63, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4313), "Error number: 63", "System number: 560e937d-01ff-4445-9081-94737f22701b" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 64, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4317), "Error number: 64", "System number: 446fdb06-bb83-4966-88ad-0094ca940818" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 65, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4322), "Error number: 65", "System number: 4cfdf7b8-1fd0-4c14-b2b5-16d899ed769a" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 66, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4327), "Error number: 66", "System number: cb624e19-9dae-4463-96e5-d7f6b2185f20" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 67, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4331), "Error number: 67", "System number: f11bfa1d-6bf3-4fbf-a40c-7c808f168fa7" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 68, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4335), "Error number: 68", "System number: 7b073133-0b34-4611-8972-d213f4493fa8" });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Date", "Message", "System" },
                values: new object[] { 69, new DateTime(2022, 7, 3, 21, 8, 41, 375, DateTimeKind.Local).AddTicks(4339), "Error number: 69", "System number: cc3b2bef-b0e3-4ae5-9c0b-4b733d6b417a" });

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
                values: new object[] { new Guid("7758d964-e2ec-44e2-8bdd-3607a019d1ee"), true, "AQAAAAEAACcQAAAAEHe65MJzIMW/oSj6Tk/LGKGDp8KZMJfgozsfIQhooO72X9HaaE7MxpZdDRdn6HrJwg==", "", null, 1, "BasicUser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Password", "RefreshToken", "RefreshTokenExpiry", "RoleId", "Username" },
                values: new object[] { new Guid("d953617e-7b84-4a52-890e-ed944a4354ac"), true, "AQAAAAEAACcQAAAAEI6Z8CxXD4b9OekjIav7zXZYemZJ7oZxEEA01xvYWFHaiR/4BhDJ9wk+VMNTh+w3Kg==", "", null, 2, "AdminUser" });

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
