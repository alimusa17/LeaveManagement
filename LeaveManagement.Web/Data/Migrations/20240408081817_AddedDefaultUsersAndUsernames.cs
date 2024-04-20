using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "473e98e8-e3e7-41a8-a4c3-1f9f998374b5", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJVakPcoUu21z0ItknWnmKpZWkLZ+TB5Z6bR4ujJlGVLn2jBiTxxa5EN171HacmZjA==", "84aa8466-2eb4-49e1-850f-2238e14a67a7", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8320bd3b-a78c-4fb1-b2a1-8be25cddf466", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOY9z97DYh8H9bfu8usBPA2Ku/yTpLF7J/+fxAAUxrs9RFhmtNHaDES7jiS6DP3PqQ==", "d8aea1b8-6cf0-4ada-b820-751bc18e5d5f", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5d47ba67-22b9-4967-b59a-986b3cc2a78e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8fc92c26-10fa-4e90-9e32-bdb64ad3da89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "15f521b7-695b-4fd2-8146-3dbcf9a5e626", false, null, "AQAAAAEAACcQAAAAEPYNmRe2GjasMuReaTEmmZa3oAqRIswFiGcrPe5IIyB+UX84CydP6MGusIRQpWE0Hg==", "a105184c-5ab4-4afe-b1c6-8a626f6cbc57", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe03f5ed-21ff-4000-8a2f-f8ce72ad6877", false, null, "AQAAAAEAACcQAAAAEKs6bAORHVSCVi86AxRhyM4K+OnnBwBYjzya1jJGZQ1DsnfweJqmHf93ut/4xK5shw==", "41bfffbe-3680-4a3f-ae22-c9e9f3d8a23a", null });
        }
    }
}
