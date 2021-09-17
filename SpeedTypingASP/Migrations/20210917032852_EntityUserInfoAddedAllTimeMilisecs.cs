using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityUserInfoAddedAllTimeMilisecs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllTimeMiliseconds",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                column: "ConcurrencyStamp",
                value: "e5463b7b-5984-4e38-a58c-d9bb77daf612");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc086066-451d-4cb1-a1ad-933352eb82b4",
                column: "ConcurrencyStamp",
                value: "94ce1c2e-942d-40af-9c2d-45132bc8d0c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1d83d7b-f964-4a35-adfc-2108cc5956ee", "AQAAAAEAACcQAAAAED5d0gptOYBaDrLongBaRKxFT+uUwC4fI9DSKeP7OyCYGR0xziCmPmAHAf4cRNID8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294e833-15e9-4066-8b41-61847ff6f0f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "389815ba-ef6c-4c90-8614-d439818043bd", "AQAAAAEAACcQAAAAEIcoufFC4DOTW3P5ugTPqCZtnOeYgmaCx6Tn5uJPry9WfuUJ2sZa9bZ1SnwE6pmDRw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllTimeMiliseconds",
                table: "AspNetUsers");

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
        }
    }
}
