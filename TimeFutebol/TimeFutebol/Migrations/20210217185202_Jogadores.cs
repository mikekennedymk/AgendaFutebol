using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeFutebol.Migrations
{
    public partial class Jogadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    qtdTilutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.id);
                });
          
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropColumn(
                name: "time",
                table: "Jogadores");
        }
    }
}
