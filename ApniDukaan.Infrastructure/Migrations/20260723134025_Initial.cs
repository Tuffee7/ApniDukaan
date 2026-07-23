using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApniDukaan.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "UserId", "Email", "Gender", "Password", "PersonName" },
                values: new object[,]
                {
                    { new Guid("9194ab4e-f176-4e28-9bfb-e11d377b4489"), "seed@example.com", "Male", "seedpassword", "Seed User" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0001"), "john.doe@example.com", "Male", "John@123", "John Doe" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0002"), "jane.smith@example.com", "Female", "Jane@123", "Jane Smith" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0003"), "michael.brown@example.com", "Male", "Mike@123", "Michael Brown" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0004"), "emily.davis@example.com", "Female", "Emily@123", "Emily Davis" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0005"), "david.wilson@example.com", "Male", "David@123", "David Wilson" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0006"), "olivia.taylor@example.com", "Female", "Olivia@123", "Olivia Taylor" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0007"), "daniel.anderson@example.com", "Male", "Daniel@123", "Daniel Anderson" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0008"), "sophia.martin@example.com", "Female", "Sophia@123", "Sophia Martin" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0009"), "james.thomas@example.com", "Male", "James@123", "James Thomas" },
                    { new Guid("b6b7e2e0-1c43-4f89-8d1b-4d7d7b4a0010"), "ava.jackson@example.com", "Female", "Ava@123", "Ava Jackson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");
        }
    }
}
