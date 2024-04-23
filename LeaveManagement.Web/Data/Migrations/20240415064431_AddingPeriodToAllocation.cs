using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "68b1e504-10de-4c36-bf12-3f48199f6112");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "4b32e14f-34ed-4a99-bf3b-354c769e6a9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef16586c-00d3-4c01-9e0b-be340bc07fbf", "AQAAAAEAACcQAAAAEJTfa1Ll29sEMSwYJt0tG3FsjnOLfzsDwpgqPqeAEdIV3fFB9dXR7MaBgcWxNwaYIQ==", "a72c0909-eb4a-440b-b144-d2284b6ecb07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761a8db3-26a6-4270-9bb2-3fc72298b30a", "AQAAAAEAACcQAAAAEHsjiyO2aT1EhIjlqH9vDw4uR3y133J6U+GO/xROQs4YTR14CNwO+ocyy0zI3gI9Dg==", "9f6d10c3-1e30-421f-9ed8-6f99a522938c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0448c5e5-5658-4444-849c-d65a2c4ad809");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "337d606f-c9fd-48d5-ba50-85b434942e2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "473e98e8-e3e7-41a8-a4c3-1f9f998374b5", "AQAAAAEAACcQAAAAEJVakPcoUu21z0ItknWnmKpZWkLZ+TB5Z6bR4ujJlGVLn2jBiTxxa5EN171HacmZjA==", "84aa8466-2eb4-49e1-850f-2238e14a67a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8320bd3b-a78c-4fb1-b2a1-8be25cddf466", "AQAAAAEAACcQAAAAEOY9z97DYh8H9bfu8usBPA2Ku/yTpLF7J/+fxAAUxrs9RFhmtNHaDES7jiS6DP3PqQ==", "d8aea1b8-6cf0-4ada-b820-751bc18e5d5f" });
        }
    }
}
