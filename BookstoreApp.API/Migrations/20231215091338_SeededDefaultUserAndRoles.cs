using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreApp.API.Migrations
{
    public partial class SeededDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3414d4ee-1968-4929-ae98-550d4479c094", "3898004b-45ed-4b17-815d-0b40e56f674e", "User", "USER" },
                    { "382f5ef0-20c0-473f-97ec-910dc29cb7f2", "737f9564-6582-45e6-a607-bd6bf792ef1b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e051aae-a05f-4cc6-8170-aa328ed47269", 0, "10c4f10e-3095-4dd3-8678-b051cc7b36d3", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEDRfk4RK8vxGvyFu/RETL3SSzb3tCR7MQ85YDCnfAuBsaKcHu5FvdkrUuAhmws5pzw==", null, false, "8fcc3efc-4178-4f51-8a33-c13225068182", false, "ADMIN@BOOKSTORE.COM" },
                    { "3e17210e-a083-4f2f-9cee-6b1d5e1bc1f1", 0, "3afc62a5-a7bc-4d83-832c-c0223868362e", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEB2cq6Kq42+3qW9Kb6HFQD4XvBhng+GPR6UfWsvWu+cIdh9cI0IYQw1C4T5GjKXAmg==", null, false, "7853c58d-eee1-4e86-b28e-55fdf9a8bb92", false, "USER@BOOKSTORE.COM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "382f5ef0-20c0-473f-97ec-910dc29cb7f2", "1e051aae-a05f-4cc6-8170-aa328ed47269" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3414d4ee-1968-4929-ae98-550d4479c094", "3e17210e-a083-4f2f-9cee-6b1d5e1bc1f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "382f5ef0-20c0-473f-97ec-910dc29cb7f2", "1e051aae-a05f-4cc6-8170-aa328ed47269" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3414d4ee-1968-4929-ae98-550d4479c094", "3e17210e-a083-4f2f-9cee-6b1d5e1bc1f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3414d4ee-1968-4929-ae98-550d4479c094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "382f5ef0-20c0-473f-97ec-910dc29cb7f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e051aae-a05f-4cc6-8170-aa328ed47269");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e17210e-a083-4f2f-9cee-6b1d5e1bc1f1");
        }
    }
}
