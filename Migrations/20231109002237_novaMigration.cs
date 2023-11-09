using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSTO_ERP.Migrations
{
    public partial class novaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    CNPJ_CPF = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    CLIENTES = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.CNPJ_CPF);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES");
        }
    }
}
