using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VlearnBackend2.Migrations
{
    /// <inheritdoc />
    public partial class InitialInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TABLE_VLEARN_LOGIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLE_VLEARN_LOGIN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TABLE_VLEARN_TELEFONE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ddd = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ddi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nr_telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLE_VLEARN_TELEFONE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TABLE_VLEARN_ALUNO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TipoPcd = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LoginId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TelefoneId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLE_VLEARN_ALUNO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_LOGIN_LoginId",
                        column: x => x.LoginId,
                        principalTable: "TABLE_VLEARN_LOGIN",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_TELEFONE_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "TABLE_VLEARN_TELEFONE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TABLE_VLEARN_PROFESSOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Formacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Experiencia = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Idiomas = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LoginId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TelefoneId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLE_VLEARN_PROFESSOR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_LOGIN_LoginId",
                        column: x => x.LoginId,
                        principalTable: "TABLE_VLEARN_LOGIN",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_TELEFONE_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "TABLE_VLEARN_TELEFONE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TABLE_VLEARN_CURSO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Preco = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Autor = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Duracao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ProfessorId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLE_VLEARN_CURSO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TABLE_VLEARN_CURSO_TABLE_VLEARN_PROFESSOR_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "TABLE_VLEARN_PROFESSOR",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TABLE_VLEARN_ALUNO_LoginId",
                table: "TABLE_VLEARN_ALUNO",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_TABLE_VLEARN_ALUNO_TelefoneId",
                table: "TABLE_VLEARN_ALUNO",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_TABLE_VLEARN_CURSO_ProfessorId",
                table: "TABLE_VLEARN_CURSO",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_TABLE_VLEARN_PROFESSOR_LoginId",
                table: "TABLE_VLEARN_PROFESSOR",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_TABLE_VLEARN_PROFESSOR_TelefoneId",
                table: "TABLE_VLEARN_PROFESSOR",
                column: "TelefoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TABLE_VLEARN_ALUNO");

            migrationBuilder.DropTable(
                name: "TABLE_VLEARN_CURSO");

            migrationBuilder.DropTable(
                name: "TABLE_VLEARN_PROFESSOR");

            migrationBuilder.DropTable(
                name: "TABLE_VLEARN_LOGIN");

            migrationBuilder.DropTable(
                name: "TABLE_VLEARN_TELEFONE");
        }
    }
}
