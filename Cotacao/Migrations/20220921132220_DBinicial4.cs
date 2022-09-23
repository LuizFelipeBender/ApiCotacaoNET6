using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cotacao.Migrations
{
    public partial class DBinicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BTCBRL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTCBRL", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EURBRL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EURBRL", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MoedaGenericas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoedaGenericas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MOEDAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOEDAS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUBBRL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUBBRL", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USDBRL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Converterde = table.Column<string>(name: "Converter de", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Converterpara = table.Column<string>(name: "Converter para", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaodaconvercao = table.Column<string>(name: "Descricao da convercao", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altadamoeda = table.Column<string>(name: "Alta da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaixadaMoeda = table.Column<string>(name: "Baixa da Moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Variaçãodamoeda = table.Column<string>(name: "Variação da moeda", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porcetagemdevariação = table.Column<string>(name: "Porcetagem de variação", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Venda = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carimbodedatahora = table.Column<string>(name: "Carimbo de data/hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<string>(name: "Data/Hora", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USDBRL", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USDBRLId = table.Column<int>(type: "int", nullable: true),
                    EURBRLId = table.Column<int>(type: "int", nullable: true),
                    BTCBRLId = table.Column<int>(type: "int", nullable: true),
                    RUBBRLId = table.Column<int>(type: "int", nullable: true),
                    MOEDASId = table.Column<int>(type: "int", nullable: true),
                    MoedaGenericasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roots_BTCBRL_BTCBRLId",
                        column: x => x.BTCBRLId,
                        principalTable: "BTCBRL",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roots_EURBRL_EURBRLId",
                        column: x => x.EURBRLId,
                        principalTable: "EURBRL",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roots_MoedaGenericas_MoedaGenericasId",
                        column: x => x.MoedaGenericasId,
                        principalTable: "MoedaGenericas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roots_MOEDAS_MOEDASId",
                        column: x => x.MOEDASId,
                        principalTable: "MOEDAS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roots_RUBBRL_RUBBRLId",
                        column: x => x.RUBBRLId,
                        principalTable: "RUBBRL",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roots_USDBRL_USDBRLId",
                        column: x => x.USDBRLId,
                        principalTable: "USDBRL",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_BTCBRLId",
                table: "Roots",
                column: "BTCBRLId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_EURBRLId",
                table: "Roots",
                column: "EURBRLId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_MoedaGenericasId",
                table: "Roots",
                column: "MoedaGenericasId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_MOEDASId",
                table: "Roots",
                column: "MOEDASId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_RUBBRLId",
                table: "Roots",
                column: "RUBBRLId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_USDBRLId",
                table: "Roots",
                column: "USDBRLId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropTable(
                name: "BTCBRL");

            migrationBuilder.DropTable(
                name: "EURBRL");

            migrationBuilder.DropTable(
                name: "MoedaGenericas");

            migrationBuilder.DropTable(
                name: "MOEDAS");

            migrationBuilder.DropTable(
                name: "RUBBRL");

            migrationBuilder.DropTable(
                name: "USDBRL");
        }
    }
}
