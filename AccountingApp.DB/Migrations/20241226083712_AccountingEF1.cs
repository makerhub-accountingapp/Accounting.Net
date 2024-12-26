using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AccountingApp.DB.Migrations
{
    /// <inheritdoc />
    public partial class AccountingEF1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "\"Category\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TransactionDetailId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"Category\"", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "\"Repetition\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SetDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 12, 26, 9, 37, 11, 636, DateTimeKind.Local).AddTicks(8392)),
                    NextDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransactionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"Repetition\"", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "\"TransactionType\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"TransactionType\"", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "\"User\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"User\"", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "\"Account\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Balance = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 0m),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"Account\"", x => x.Id);
                    table.ForeignKey(
                        name: "FK_\"Account\"_\"User\"_UserId",
                        column: x => x.UserId,
                        principalTable: "\"User\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "\"Transaction\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    RepetitionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"Transaction\"", x => x.Id);
                    table.ForeignKey(
                        name: "FK_\"Transaction\"_\"Account\"_AccountId",
                        column: x => x.AccountId,
                        principalTable: "\"Account\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_\"Transaction\"_\"Repetition\"_RepetitionId",
                        column: x => x.RepetitionId,
                        principalTable: "\"Repetition\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "\"Detail\"",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 12, 26, 9, 37, 11, 639, DateTimeKind.Local).AddTicks(6534)),
                    Note = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    TransactionId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_\"Detail\"", x => x.Id);
                    table.ForeignKey(
                        name: "FK_\"Detail\"_\"Category\"_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "\"Category\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_\"Detail\"_\"Transaction\"_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "\"Transaction\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_\"Detail\"_\"TransactionType\"_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "\"TransactionType\"",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_\"Account\"_UserId",
                table: "\"Account\"",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_\"Detail\"_CategoryId",
                table: "\"Detail\"",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_\"Detail\"_TransactionId",
                table: "\"Detail\"",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_\"Detail\"_TransactionTypeId",
                table: "\"Detail\"",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_\"Transaction\"_AccountId",
                table: "\"Transaction\"",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_\"Transaction\"_RepetitionId",
                table: "\"Transaction\"",
                column: "RepetitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "\"Detail\"");

            migrationBuilder.DropTable(
                name: "\"Category\"");

            migrationBuilder.DropTable(
                name: "\"Transaction\"");

            migrationBuilder.DropTable(
                name: "\"TransactionType\"");

            migrationBuilder.DropTable(
                name: "\"Account\"");

            migrationBuilder.DropTable(
                name: "\"Repetition\"");

            migrationBuilder.DropTable(
                name: "\"User\"");
        }
    }
}
