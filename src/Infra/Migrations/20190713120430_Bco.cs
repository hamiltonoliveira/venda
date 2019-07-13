using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Bco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 30, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Contato = table.Column<string>(maxLength: 50, nullable: true),
                    cnpjcpf = table.Column<string>(maxLength: 15, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Celular = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Endereco = table.Column<string>(maxLength: 60, nullable: true),
                    Complemento = table.Column<string>(maxLength: 20, nullable: true),
                    Bairro = table.Column<string>(maxLength: 30, nullable: true),
                    Cidade = table.Column<string>(maxLength: 30, nullable: true),
                    Estado = table.Column<string>(maxLength: 2, nullable: true),
                    Cep = table.Column<string>(maxLength: 8, nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataPedido = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataEntrega = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataDevolucao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Numero = table.Column<string>(maxLength: 100, nullable: true),
                    ProdutoId = table.Column<int>(nullable: true),
                    VendedorId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: true),
                    Observacao = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 30, nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    CodigoBarra = table.Column<string>(maxLength: 15, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime", nullable: false),
                    Volume = table.Column<string>(maxLength: 20, nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    PrecoCompra = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Fornecedor = table.Column<int>(nullable: false),
                    Imagem = table.Column<string>(maxLength: 20, nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PerfilId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 80, nullable: true),
                    CodigoUsuario = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 40, nullable: true),
                    CnpjCpf = table.Column<string>(maxLength: 15, nullable: true),
                    Senha = table.Column<string>(maxLength: 200, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataUltimoLog = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
