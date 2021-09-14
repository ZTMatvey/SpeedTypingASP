using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityTextTitleIsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "a07cbda8-058c-4550-8d39-bdf27e6b5180");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "46b370e2-4097-42c1-81ac-e81ee6508af1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cd836d8-a196-4ad3-bed3-6cde15f162cd", "AQAAAAEAACcQAAAAEMB+MgXqyzHthVnTi26re4vgAg+pMWeuTjB2wyiNwlVO2y8qWG6Nwp+THe4MamjQsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fdf391d-5db2-4492-a471-065610e11c6f", "AQAAAAEAACcQAAAAEHCvQaE4i5yTMkHoNM6D9mp49XsSK+uJQwrlUridnWZ9lyD7lSdE+0DW4ya4j2IBSQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Texts_Title",
                table: "Texts",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Texts_Title",
                table: "Texts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
