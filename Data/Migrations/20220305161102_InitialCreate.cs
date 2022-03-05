using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "DateAdded", "GenreId", "Name", "NumberAvailable", "NumberInStock", "ReleaseDate" },
                values: new object[,]
                {
                    { 5, "Example1", new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, "Javascript", 0, 0, new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Example1", new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, "Python", 0, 0, new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "MembershipTypeId",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "MembershipTypeId",
                value: (byte)3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "MembershipTypeId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "MembershipTypeId",
                value: (byte)1);
        }
    }
}
