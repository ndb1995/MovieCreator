using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCreator.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    isFinished = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Name", "Rating", "isFinished" },
                values: new object[] { 1, "My favorite movie", "Shawshank Redemption", 10.0, null });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Name", "Rating", "isFinished" },
                values: new object[] { 2, "Stupidly funny", "Weekend at Bernies", 8.0, null });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Name", "Rating", "isFinished" },
                values: new object[] { 3, "Interesting movie", "The Matrix", 9.0999999999999996, null });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Name", "Rating", "isFinished" },
                values: new object[] { 4, "Lot of classic jokes", "Airplane!", 8.6999999999999993, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
