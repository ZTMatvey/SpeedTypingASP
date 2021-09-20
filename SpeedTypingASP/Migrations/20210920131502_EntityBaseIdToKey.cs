using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityBaseIdToKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "6a808ce5-2662-4e85-b2cc-fdb01611ab92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "8daff970-a7b5-43c3-a945-9cf524799c2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f43388c-30bc-48c6-ae79-8c64617d9c77", "AQAAAAEAACcQAAAAEGhN15n5ZQ67dnInsdIacZt10jUE4XMBaQsHUMr62vITrkLGG5MbGjjxnE5wDDZVTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb064f2-3663-4ecd-ac98-b66b2b83d22b", "AQAAAAEAACcQAAAAEPgcoPvWv2c61KjyZRCqSmmIG+uxVUsOehdLY8WWpa+HLIpehTkhKuqUtsSesEOskA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
