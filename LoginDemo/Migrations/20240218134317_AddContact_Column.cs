﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddContact_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "AspNetUsers");
        }
    }
}
