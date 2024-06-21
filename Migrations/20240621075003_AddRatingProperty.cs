using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efapi.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "VideoGames",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "VideoGames");
        }
    }
}
