using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TerrariaWiki.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BiomeInformations",
                columns: table => new
                {
                    BiomeInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHardmode = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiomeInformations", x => x.BiomeInformationID);
                });

            migrationBuilder.CreateTable(
                name: "VersionChanges",
                columns: table => new
                {
                    VersionChangesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMajorVersion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionChanges", x => x.VersionChangesID);
                });

            migrationBuilder.CreateTable(
                name: "MobInformations",
                columns: table => new
                {
                    MobInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBoss = table.Column<bool>(type: "bit", nullable: false),
                    SpawnItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiomeInformationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobInformations", x => x.MobInformationID);
                    table.ForeignKey(
                        name: "FK_MobInformations_BiomeInformations_BiomeInformationID",
                        column: x => x.BiomeInformationID,
                        principalTable: "BiomeInformations",
                        principalColumn: "BiomeInformationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NpcInformations",
                columns: table => new
                {
                    NpcInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Housing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHardmode = table.Column<bool>(type: "bit", nullable: false),
                    BiomeInformationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcInformations", x => x.NpcInformationId);
                    table.ForeignKey(
                        name: "FK_NpcInformations_BiomeInformations_BiomeInformationID",
                        column: x => x.BiomeInformationID,
                        principalTable: "BiomeInformations",
                        principalColumn: "BiomeInformationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StructureInformations",
                columns: table => new
                {
                    StructureInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasLoot = table.Column<bool>(type: "bit", nullable: false),
                    IsItemNeededForAccess = table.Column<bool>(type: "bit", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    BiomeInformationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureInformations", x => x.StructureInformationID);
                    table.ForeignKey(
                        name: "FK_StructureInformations_BiomeInformations_BiomeInformationID",
                        column: x => x.BiomeInformationID,
                        principalTable: "BiomeInformations",
                        principalColumn: "BiomeInformationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemInformations",
                columns: table => new
                {
                    ItemInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasValue = table.Column<bool>(type: "bit", nullable: false),
                    CopperValue = table.Column<int>(type: "int", nullable: false),
                    SilverValue = table.Column<int>(type: "int", nullable: false),
                    GoldValue = table.Column<int>(type: "int", nullable: false),
                    PlatinumValue = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsHardmode = table.Column<bool>(type: "bit", nullable: false),
                    SellingNpcId = table.Column<int>(type: "int", nullable: false),
                    SellingNpcNpcInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInformations", x => x.ItemInformationID);
                    table.ForeignKey(
                        name: "FK_ItemInformations_NpcInformations_SellingNpcId",
                        column: x => x.SellingNpcId,
                        principalTable: "NpcInformations",
                        principalColumn: "NpcInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemInformations_NpcInformations_SellingNpcNpcInformationId",
                        column: x => x.SellingNpcNpcInformationId,
                        principalTable: "NpcInformations",
                        principalColumn: "NpcInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemInformations_SellingNpcId",
                table: "ItemInformations",
                column: "SellingNpcId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInformations_SellingNpcNpcInformationId",
                table: "ItemInformations",
                column: "SellingNpcNpcInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_MobInformations_BiomeInformationID",
                table: "MobInformations",
                column: "BiomeInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_NpcInformations_BiomeInformationID",
                table: "NpcInformations",
                column: "BiomeInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_StructureInformations_BiomeInformationID",
                table: "StructureInformations",
                column: "BiomeInformationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemInformations");

            migrationBuilder.DropTable(
                name: "MobInformations");

            migrationBuilder.DropTable(
                name: "StructureInformations");

            migrationBuilder.DropTable(
                name: "VersionChanges");

            migrationBuilder.DropTable(
                name: "NpcInformations");

            migrationBuilder.DropTable(
                name: "BiomeInformations");
        }
    }
}
