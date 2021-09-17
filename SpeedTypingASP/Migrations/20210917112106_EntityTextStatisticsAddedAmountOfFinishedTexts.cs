using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeedTypingASP.Migrations
{
    public partial class EntityTextStatisticsAddedAmountOfFinishedTexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
