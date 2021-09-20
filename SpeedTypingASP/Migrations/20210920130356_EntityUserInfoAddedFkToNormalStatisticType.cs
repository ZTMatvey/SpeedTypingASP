using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserInfoAddedFkToNormalStatisticType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "3e8a80cc-b6c4-41e0-9bd4-f8425a1c6beb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "602221d9-a9e1-48b7-a642-12e717d8bc62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12acb9be-426c-49b2-89c4-c9181eed72f5", "AQAAAAEAACcQAAAAEAlEEwX8Jxkwrh3QTgadEkPlUOEPJ/IqfYV6IhDsK0PWkYkvONvufMEKtZs6+xGxPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da278478-9eaf-4cac-a4e0-bdae43f1a1ae", "AQAAAAEAACcQAAAAEHckV6eWLXneWytE8cNOasa0k4pSHKJcJGFpAGOXQgPQPxRpfNghUnsZzFCY746R3g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
