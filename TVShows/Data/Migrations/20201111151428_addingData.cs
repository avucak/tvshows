using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserShows",
                columns: new[] { "ShowId", "UserId", "ShowStatus" },
                values: new object[] { 2, 1, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserShows",
                keyColumns: new[] { "ShowId", "UserId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
