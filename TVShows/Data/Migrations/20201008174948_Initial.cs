using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Synopsis = table.Column<string>(nullable: true),
                    EpisodeLength = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserShows",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ShowId = table.Column<int>(nullable: false),
                    ShowStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShows", x => new { x.UserId, x.ShowId });
                    table.ForeignKey(
                        name: "FK_UserShows_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserShows_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "EpisodeLength", "Name", "Synopsis" },
                values: new object[,]
                {
                    { 1, 60.0, "Umbrella Academy", "It's sort of like the fantastic four or X-men" },
                    { 2, 23.5, "Love is war", "They think they're smart but they are basically tsunderes" },
                    { 3, 24.0, "Fullmetal Alchemist: Brotherhood", "Many would say it's the best show ever made" },
                    { 4, 58.0, "The Boys", "Superheroes, again" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Username" },
                values: new object[,]
                {
                    { 1, "Carson" },
                    { 2, "Meredith" },
                    { 3, "Arthur" },
                    { 4, "Lila" }
                });

            migrationBuilder.InsertData(
                table: "UserShows",
                columns: new[] { "UserId", "ShowId", "ShowStatus" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 1, 4, 0 },
                    { 2, 4, 0 },
                    { 3, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 1, 2 },
                    { 4, 2, 1 },
                    { 4, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserShows_ShowId",
                table: "UserShows",
                column: "ShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserShows");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
