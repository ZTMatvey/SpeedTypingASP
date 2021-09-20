using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserInfoAddedStatisticTypeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllTimeMiliseconds",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JsonTextsStatistics",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "NormalStatisticTypeId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatisticTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JsonTextsStatistics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllTimeMiliseconds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "b5367030-3b3a-40b6-a6af-315eef7ffd35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "56df2938-e42e-4916-9b3e-ddf85cb1b7e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e75d1dce-f7ca-4253-98db-662d9818e10d", "AQAAAAEAACcQAAAAEEOMANdHyVr2MSD2EzTnqxgpENgKlVpm2tRKJdZvyDu3BMzc5tOsq2LbUxyNlzv2tA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07955c5b-e1cf-419b-bdb9-2aa5561606c9", "AQAAAAEAACcQAAAAEDnguPdab3uSubfgFMQMt8XBhTVqqNR9Vm4Aw2NJjsIJ/nJP0eJvEu44ykuw9eyuTA==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NormalStatisticTypeId",
                table: "AspNetUsers",
                column: "NormalStatisticTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StatisticTypes_NormalStatisticTypeId",
                table: "AspNetUsers",
                column: "NormalStatisticTypeId",
                principalTable: "StatisticTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StatisticTypes_NormalStatisticTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StatisticTypes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NormalStatisticTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalStatisticTypeId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AllTimeMiliseconds",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JsonTextsStatistics",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "b57da36c-90ea-424c-9719-2dd1a850b195");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "86c9fc8c-cc7c-49ef-9715-b91b05ebb1af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70cb872b-5635-463b-9497-5c7d2c77188b", "AQAAAAEAACcQAAAAEC233VhrqKML47Ejxow3RF1/V/KRDZMdsRfbnhxiXj53eoffvUgpzuEzOETQXvca7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b97547a3-0ea6-4250-a4c7-6dac7c2f5d72", "AQAAAAEAACcQAAAAEG/7jTmUKWnAJlY0YpmkSm6+Ft0mBk6r8TpUlSJFp7SSqoNlBKqWQoZv+TS0afGlSg==" });
        }
    }
}
