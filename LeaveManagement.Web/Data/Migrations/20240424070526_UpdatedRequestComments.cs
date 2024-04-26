using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0abd4f87-46f8-42dc-821c-dc523f4e2526");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "1a579b4e-fdd8-48bb-8365-a61cbbb84a58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1feb66a-f21b-4ddb-a4ce-736d8d0e9cc4", "AQAAAAEAACcQAAAAEFQXQZAo2EVrRlyVWyuD5rZQ+/L23549uRJGtvgtzSivPTc1OCuH66aZIzaxJ1UHGg==", "679687e7-b56f-4b7f-a208-feb7d38ff619" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c3fa201-1502-45a4-8c0b-510061b4bfbf", "AQAAAAEAACcQAAAAEPbWXuK5GUdd8u3eEcgk+BtQL0TTcJxQUVrkjr2WR+749XNqM3LVmT/qO5EKdGtjlw==", "c9a197ea-73fa-4932-936e-74e9d4159869" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "bf9c81d1-2612-47a5-94cd-090e97c7d160");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9ce6b55d-4d57-49fc-a163-6e1056c111da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac42476-a1c5-4bee-9f62-78476c2140cb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c1992fa-1877-468c-b78a-82654b8f9c7f", "AQAAAAEAACcQAAAAEPl2zWzliMEzkriKZRlQGu/Ic3G/BslhYqW/sTOFszykIRsaUbEJdZHALQrMCpjOXQ==", "3a81ef77-bfa7-40dd-8da4-c47296fa4cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf247ace-7823-4c14-bbd1-11df3484a2ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec79c3cb-4da4-4078-8575-f383dcd289f3", "AQAAAAEAACcQAAAAEOCfN/kF8HRDD7OmN13nuhqkfhQyUxmR13LUqgIDvL8/+atAKPPlfdw6BuUnfm4tHw==", "5a60a28a-0519-42ad-943e-0d644a006ada" });
        }
    }
}
