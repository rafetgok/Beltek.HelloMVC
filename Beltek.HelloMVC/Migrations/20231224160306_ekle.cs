using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beltek.HelloMVC.Migrations
{
    public partial class ekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgretmenler",
                columns: table => new
                {
                    Tckimlik = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Ad = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Dtarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Alan = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgretmenler", x => x.Tckimlik);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgretmenler");
        }
    }
}
