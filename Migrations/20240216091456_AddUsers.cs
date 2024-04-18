﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });


            migrationBuilder.InsertData(
            table: "Users",
            columns: new string[] { "Username", "Password" },
            columnTypes: new string[] { "TEXT", "TEXT" },
            values: new object[,] {
                    {"admin", "hunter2"},
                    {"thomas", "ken sent me"},
                    {"fmulder", "TrustNo1"}
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
