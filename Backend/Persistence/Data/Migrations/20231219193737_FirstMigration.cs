using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "country",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameCountry = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "gamaprodruct",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameGama = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "state",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameState = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdCountryFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "state_ibfk_1",
            //             column: x => x.IdCountryFk,
            //             principalTable: "country",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "product",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameProduct = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Price = table.Column<int>(type: "int", nullable: false),
            //         StockMin = table.Column<int>(type: "int", nullable: false),
            //         StockMax = table.Column<int>(type: "int", nullable: false),
            //         StateStock = table.Column<int>(type: "int", nullable: false),
            //         IdGamaProductFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "product_ibfk_1",
            //             column: x => x.IdGamaProductFk,
            //             principalTable: "gamaprodruct",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "city",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NameCity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdStateFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "city_ibfk_1",
            //             column: x => x.IdStateFk,
            //             principalTable: "state",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "address",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         tipo_via = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_principal = table.Column<short>(type: "smallint", nullable: false),
            //         letra_principal = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letra_secundaria = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinal_primario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_secundario = table.Column<short>(type: "smallint", nullable: false),
            //         cardinal_secundario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdCityFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "address_ibfk_1",
            //             column: x => x.IdCityFk,
            //             principalTable: "city",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "client",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdClient = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Telephone = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdAddressFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "client_ibfk_1",
            //             column: x => x.IdAddressFk,
            //             principalTable: "address",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "order",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         IdClientFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "order_ibfk_1",
            //             column: x => x.IdClientFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "order_product",
            //     columns: table => new
            //     {
            //         IdOrderFk = table.Column<int>(type: "int", nullable: false),
            //         IdProductFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => new { x.IdOrderFk, x.IdProductFk })
            //             .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //         table.ForeignKey(
            //             name: "order_product_ibfk_1",
            //             column: x => x.IdProductFk,
            //             principalTable: "product",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "order_product_ibfk_2",
            //             column: x => x.IdOrderFk,
            //             principalTable: "order",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "IdCityFk",
            //     table: "address",
            //     column: "IdCityFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdStateFk",
            //     table: "city",
            //     column: "IdStateFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdAddressFk",
            //     table: "client",
            //     column: "IdAddressFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdClientFk",
            //     table: "order",
            //     column: "IdClientFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdProductFk",
            //     table: "order_product",
            //     column: "IdProductFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdGamaProductFk",
            //     table: "product",
            //     column: "IdGamaProductFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCountryFk",
            //     table: "state",
            //     column: "IdCountryFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "order_product");

            // migrationBuilder.DropTable(
            //     name: "product");

            // migrationBuilder.DropTable(
            //     name: "order");

            // migrationBuilder.DropTable(
            //     name: "gamaprodruct");

            // migrationBuilder.DropTable(
            //     name: "client");

            // migrationBuilder.DropTable(
            //     name: "address");

            // migrationBuilder.DropTable(
            //     name: "city");

            // migrationBuilder.DropTable(
            //     name: "state");

            // migrationBuilder.DropTable(
            //     name: "country");
        }
    }
}
