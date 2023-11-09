using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSTO_ERP.Migrations
{
    public partial class novaMigrationIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    UserName = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    Email = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    PasswordHash = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    LockoutEnd = table.Column<string>(type: "VARCHAR(48)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
