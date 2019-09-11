using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCC.Data.Migrations
{
    public partial class InitDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChampionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    Magic = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionStats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Armor = table.Column<double>(nullable: false),
                    ArmorPerLevel = table.Column<double>(nullable: false),
                    AttackDamage = table.Column<double>(nullable: false),
                    AttackDamagePerLevel = table.Column<double>(nullable: false),
                    AttackRange = table.Column<double>(nullable: false),
                    AttackSpeedOffset = table.Column<double>(nullable: false),
                    AttackSpeedPerLevel = table.Column<double>(nullable: false),
                    Crit = table.Column<double>(nullable: false),
                    CritPerLevel = table.Column<double>(nullable: false),
                    Hp = table.Column<double>(nullable: false),
                    HpPerLevel = table.Column<double>(nullable: false),
                    HpRegen = table.Column<double>(nullable: false),
                    HpRegenPerLevel = table.Column<double>(nullable: false),
                    MoveSpeed = table.Column<double>(nullable: false),
                    Mp = table.Column<double>(nullable: false),
                    MpPerLevel = table.Column<double>(nullable: false),
                    MpRegen = table.Column<double>(nullable: false),
                    MpRegenPerLevel = table.Column<double>(nullable: false),
                    SpellBlock = table.Column<double>(nullable: false),
                    SpellBlockPerLevel = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lore = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Partype = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    StatsId = table.Column<int>(nullable: false),
                    PassiveId = table.Column<int>(nullable: false),
                    InfoId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true),
                    TagId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionInfos_InfoId",
                        column: x => x.InfoId,
                        principalTable: "ChampionInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_Passives_PassiveId",
                        column: x => x.PassiveId,
                        principalTable: "Passives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionStats_StatsId",
                        column: x => x.StatsId,
                        principalTable: "ChampionStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skins",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Num = table.Column<int>(nullable: false),
                    ChampionId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skins_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    EditedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: true),
                    ChampionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_InfoId",
                table: "Champions",
                column: "InfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champions_PassiveId",
                table: "Champions",
                column: "PassiveId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champions_StatsId",
                table: "Champions",
                column: "StatsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champions_TagId",
                table: "Champions",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Skins_ChampionId",
                table: "Skins",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ChampionId",
                table: "Tags",
                column: "ChampionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champions_Tags_TagId",
                table: "Champions",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champions_ChampionInfos_InfoId",
                table: "Champions");

            migrationBuilder.DropForeignKey(
                name: "FK_Champions_Passives_PassiveId",
                table: "Champions");

            migrationBuilder.DropForeignKey(
                name: "FK_Champions_ChampionStats_StatsId",
                table: "Champions");

            migrationBuilder.DropForeignKey(
                name: "FK_Champions_Tags_TagId",
                table: "Champions");

            migrationBuilder.DropTable(
                name: "Skins");

            migrationBuilder.DropTable(
                name: "ChampionInfos");

            migrationBuilder.DropTable(
                name: "Passives");

            migrationBuilder.DropTable(
                name: "ChampionStats");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Champions");
        }
    }
}
