using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VlearnBackend2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ddd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddi = table.Column<int>(type: "int", nullable: false),
                    nr_telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginId = table.Column<int>(type: "int", nullable: true),
                    Telefoneid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Alunos_Telefones_Telefoneid",
                        column: x => x.Telefoneid,
                        principalTable: "Telefones",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    formacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    experiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idiomas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loginId = table.Column<int>(type: "int", nullable: true),
                    telefoneid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Professores_Logins_loginId",
                        column: x => x.loginId,
                        principalTable: "Logins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professores_Telefones_telefoneid",
                        column: x => x.telefoneid,
                        principalTable: "Telefones",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    preco = table.Column<double>(type: "float", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    professorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cursos_Professores_professorid",
                        column: x => x.professorid,
                        principalTable: "Professores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_LoginId",
                table: "Alunos",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Telefoneid",
                table: "Alunos",
                column: "Telefoneid");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_professorid",
                table: "Cursos",
                column: "professorid");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_loginId",
                table: "Professores",
                column: "loginId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_telefoneid",
                table: "Professores",
                column: "telefoneid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Telefones");
        }
    }
}
