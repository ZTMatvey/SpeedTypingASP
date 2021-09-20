using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserInfoStatisticTypeToVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "bce8cc14-2058-47c1-a845-60e22aed7f03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "f142399a-9e13-434f-a947-3a89aec78981");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7321bd9-951c-4da8-8d2b-43e541b86b2b", "AQAAAAEAACcQAAAAECxFpXqqE8UlgEPpiX3UHJcg12DMi/xL4Lts/fkG55n9fHkq3aBebgOc33rV9X5BAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56a269a0-7522-4bc8-8364-fe96921149d6", "AQAAAAEAACcQAAAAEDc/B2emonmyMGLTBkiHb/xY85twz1SRnbzRWw/SHPzYn6zECPBd5RCokJcrs7P2+Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
