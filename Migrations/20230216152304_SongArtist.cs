using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SongsAPI.Migrations
{
    /// <inheritdoc />
    public partial class SongArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongArtist",
                table: "Songs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongArtist",
                table: "Songs");
        }
    }
}
