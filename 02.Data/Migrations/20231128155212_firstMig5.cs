﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02.Data.Migrations
{
    /// <inheritdoc />
    public partial class firstMig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Services",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Services");
        }
    }
}
