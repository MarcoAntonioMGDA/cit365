﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Scripture_Journal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(maxLength: 60, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Chapter = table.Column<int>(nullable: false),
                    Verse = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
