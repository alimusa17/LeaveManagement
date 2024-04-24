using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "faa2ba8d-1134-4a98-896c-f7c91c00c3ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9425fd91-754e-4311-a493-dc2f18b2198f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7199fcc1-c4a9-4d82-b994-29e6e5c5c893", "AQAAAAEAACcQAAAAELEdjswJ9BAIVJB2vFMKhka+ewJB6RfFiy8OPuxaBlRfIBxivHLehljImS+tu3HglQ==", "27e9e934-ccf4-4582-a7c8-dff1da84654b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84da14e2-5d48-4481-97f1-a69631be931f", "AQAAAAEAACcQAAAAEIu79xivTDFNPQhIwIJdoXQpF2dZjnhW1XQ2ajTKz+6Np7GnmrsZKEEOD9nfQcQ8Dw==", "0bf68b13-9289-4d31-994e-ea3ee97fa795" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
