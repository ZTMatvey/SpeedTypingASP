using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserChangedJsonTextsToPublic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "81108cf2-451b-43c6-98b5-2dca93f07d6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "86b8c655-5103-4a03-babc-080d8b7c3ec8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab55fcb2-7e7c-4f25-8dc1-f20af2cf0d6d", "AQAAAAEAACcQAAAAEJw2hOx6e5CreC3IPX0PKIGSqzP/wQAMhH4q/M2P9L6ld+daOHBCP9E5coTBggamHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5738de2e-18b5-40c9-95ed-c45599f664f0", "AQAAAAEAACcQAAAAEJBVY2GanAcxHjAVohZOlbdFFM8COUs8EC3DOOX+CBwoDo7I70pZiAJyNkfqdgkb1g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JsonTextsStatistics",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "cedb55e7-a4b1-4cb9-bd91-d289ca06b31d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "ccfc0d28-de91-408e-b26c-6902af376a29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03416ac2-9885-4de2-b701-b5bf266dba7b", "AQAAAAEAACcQAAAAEAxfSEELUA7JtSKoOEw55UtfW4uk3sBgJK8RaOvNp7ZSVd6L3bPMpSkKzLDMjeE+BQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c30a0384-30b5-4313-a9a4-1b17bde21fd3", "AQAAAAEAACcQAAAAEPCS4kx5TDNHZyXNetEiLgkWCgEWLovG2YM9zjU3kPJhrToCgBF+zaeVVjqir89vdA==" });
        }
    }
}
