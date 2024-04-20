using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "5d47ba67-22b9-4967-b59a-986b3cc2a78e", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "8fc92c26-10fa-4e90-9e32-bdb64ad3da89", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7ac42476-a1c5-4bee-9f62-78476c2140cb", 0, "15f521b7-695b-4fd2-8146-3dbcf9a5e626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEPYNmRe2GjasMuReaTEmmZa3oAqRIswFiGcrPe5IIyB+UX84CydP6MGusIRQpWE0Hg==", null, false, "a105184c-5ab4-4afe-b1c6-8a626f6cbc57", null, false, null },
                    { "cf247ace-7823-4c14-bbd1-11df3484a2ff", 0, "fe03f5ed-21ff-4000-8a2f-f8ce72ad6877", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKs6bAORHVSCVi86AxRhyM4K+OnnBwBYjzya1jJGZQ1DsnfweJqmHf93ut/4xK5shw==", null, false, "41bfffbe-3680-4a3f-ae22-c9e9f3d8a23a", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "7ac42476-a1c5-4bee-9f62-78476c2140cb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "cf247ace-7823-4c14-bbd1-11df3484a2ff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "7ac42476-a1c5-4bee-9f62-78476c2140cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "cf247ace-7823-4c14-bbd1-11df3484a2ff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff");
        }
    }
}
