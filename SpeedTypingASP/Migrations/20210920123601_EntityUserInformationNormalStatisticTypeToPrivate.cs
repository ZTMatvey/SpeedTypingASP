using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserInformationNormalStatisticTypeToPrivate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "8435bf86-88c4-4371-b1d8-04dd5e769eb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "19c8d417-6c9e-4d25-a48c-3fa64b889e4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1b29b97-6ac6-4499-aed0-821f6cad2115", "AQAAAAEAACcQAAAAEDDjzS9s2EE3gdgKTze044vDhssLX7nHRk/+QPq+Wu1pDScPcBtHKY3cOjxN1bSGcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f407fffa-3e7d-45ff-9d6f-3c76c1667617", "AQAAAAEAACcQAAAAEAOTgg1oliSsZu2m02n6ahL0dccGQjTLbp7IKo36PTKVq+vVeab3KCBrXaKgNfcPSQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
