using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviManagmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Firstinitialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movieRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movieRatings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movieReviews_Movies_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoviesDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    MovieLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviesDetails_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoviesMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoviedId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviesMedia_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserFavourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFavourites_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userMoviesLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userMoviesLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userMoviesLogs_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movieRatings_MovieId",
                table: "movieRatings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_movieReviews_MovieId1",
                table: "movieReviews",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesDetails_MovieId",
                table: "MoviesDetails",
                column: "MovieId",
                unique: true,
                filter: "[MovieId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesMedia_MovieId",
                table: "MoviesMedia",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavourites_MovieId",
                table: "UserFavourites",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_userMoviesLogs_MovieId",
                table: "userMoviesLogs",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieRatings");

            migrationBuilder.DropTable(
                name: "movieReviews");

            migrationBuilder.DropTable(
                name: "MoviesDetails");

            migrationBuilder.DropTable(
                name: "MoviesMedia");

            migrationBuilder.DropTable(
                name: "UserFavourites");

            migrationBuilder.DropTable(
                name: "userMoviesLogs");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
