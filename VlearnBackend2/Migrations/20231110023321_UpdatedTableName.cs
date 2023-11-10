using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VlearnBackend2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Logins_LoginId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Telefones_Telefoneid",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Professores_professorid",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Logins_loginId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Telefones_telefoneid",
                table: "Professores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professores",
                table: "Professores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "TABLE_VLEARN_TELEFONE");

            migrationBuilder.RenameTable(
                name: "Professores",
                newName: "TABLE_VLEARN_PROFESSOR");

            migrationBuilder.RenameTable(
                name: "Logins",
                newName: "TABLE_VLEARN_LOGIN");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "TABLE_VLEARN_CURSO");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "TABLE_VLEARN_ALUNO");

            migrationBuilder.RenameColumn(
                name: "nr_telefone",
                table: "TABLE_VLEARN_TELEFONE",
                newName: "Nr_telefone");

            migrationBuilder.RenameColumn(
                name: "ddi",
                table: "TABLE_VLEARN_TELEFONE",
                newName: "Ddi");

            migrationBuilder.RenameColumn(
                name: "ddd",
                table: "TABLE_VLEARN_TELEFONE",
                newName: "Ddd");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TABLE_VLEARN_TELEFONE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "telefoneid",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "TelefoneId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "loginId",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "LoginId");

            migrationBuilder.RenameColumn(
                name: "idiomas",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Idiomas");

            migrationBuilder.RenameColumn(
                name: "formacao",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Formacao");

            migrationBuilder.RenameColumn(
                name: "experiencia",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Experiencia");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Professores_telefoneid",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "IX_TABLE_VLEARN_PROFESSOR_TelefoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Professores_loginId",
                table: "TABLE_VLEARN_PROFESSOR",
                newName: "IX_TABLE_VLEARN_PROFESSOR_LoginId");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "TABLE_VLEARN_LOGIN",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "TABLE_VLEARN_LOGIN",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "professorid",
                table: "TABLE_VLEARN_CURSO",
                newName: "ProfessorId");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "TABLE_VLEARN_CURSO",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "TABLE_VLEARN_CURSO",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "duracao",
                table: "TABLE_VLEARN_CURSO",
                newName: "Duracao");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "TABLE_VLEARN_CURSO",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "autor",
                table: "TABLE_VLEARN_CURSO",
                newName: "Autor");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TABLE_VLEARN_CURSO",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_professorid",
                table: "TABLE_VLEARN_CURSO",
                newName: "IX_TABLE_VLEARN_CURSO_ProfessorId");

            migrationBuilder.RenameColumn(
                name: "Telefoneid",
                table: "TABLE_VLEARN_ALUNO",
                newName: "TelefoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_Telefoneid",
                table: "TABLE_VLEARN_ALUNO",
                newName: "IX_TABLE_VLEARN_ALUNO_TelefoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_LoginId",
                table: "TABLE_VLEARN_ALUNO",
                newName: "IX_TABLE_VLEARN_ALUNO_LoginId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLE_VLEARN_TELEFONE",
                table: "TABLE_VLEARN_TELEFONE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLE_VLEARN_PROFESSOR",
                table: "TABLE_VLEARN_PROFESSOR",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLE_VLEARN_LOGIN",
                table: "TABLE_VLEARN_LOGIN",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLE_VLEARN_CURSO",
                table: "TABLE_VLEARN_CURSO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABLE_VLEARN_ALUNO",
                table: "TABLE_VLEARN_ALUNO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_LOGIN_LoginId",
                table: "TABLE_VLEARN_ALUNO",
                column: "LoginId",
                principalTable: "TABLE_VLEARN_LOGIN",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_TELEFONE_TelefoneId",
                table: "TABLE_VLEARN_ALUNO",
                column: "TelefoneId",
                principalTable: "TABLE_VLEARN_TELEFONE",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TABLE_VLEARN_CURSO_TABLE_VLEARN_PROFESSOR_ProfessorId",
                table: "TABLE_VLEARN_CURSO",
                column: "ProfessorId",
                principalTable: "TABLE_VLEARN_PROFESSOR",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_LOGIN_LoginId",
                table: "TABLE_VLEARN_PROFESSOR",
                column: "LoginId",
                principalTable: "TABLE_VLEARN_LOGIN",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_TELEFONE_TelefoneId",
                table: "TABLE_VLEARN_PROFESSOR",
                column: "TelefoneId",
                principalTable: "TABLE_VLEARN_TELEFONE",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_LOGIN_LoginId",
                table: "TABLE_VLEARN_ALUNO");

            migrationBuilder.DropForeignKey(
                name: "FK_TABLE_VLEARN_ALUNO_TABLE_VLEARN_TELEFONE_TelefoneId",
                table: "TABLE_VLEARN_ALUNO");

            migrationBuilder.DropForeignKey(
                name: "FK_TABLE_VLEARN_CURSO_TABLE_VLEARN_PROFESSOR_ProfessorId",
                table: "TABLE_VLEARN_CURSO");

            migrationBuilder.DropForeignKey(
                name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_LOGIN_LoginId",
                table: "TABLE_VLEARN_PROFESSOR");

            migrationBuilder.DropForeignKey(
                name: "FK_TABLE_VLEARN_PROFESSOR_TABLE_VLEARN_TELEFONE_TelefoneId",
                table: "TABLE_VLEARN_PROFESSOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLE_VLEARN_TELEFONE",
                table: "TABLE_VLEARN_TELEFONE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLE_VLEARN_PROFESSOR",
                table: "TABLE_VLEARN_PROFESSOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLE_VLEARN_LOGIN",
                table: "TABLE_VLEARN_LOGIN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLE_VLEARN_CURSO",
                table: "TABLE_VLEARN_CURSO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TABLE_VLEARN_ALUNO",
                table: "TABLE_VLEARN_ALUNO");

            migrationBuilder.RenameTable(
                name: "TABLE_VLEARN_TELEFONE",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "TABLE_VLEARN_PROFESSOR",
                newName: "Professores");

            migrationBuilder.RenameTable(
                name: "TABLE_VLEARN_LOGIN",
                newName: "Logins");

            migrationBuilder.RenameTable(
                name: "TABLE_VLEARN_CURSO",
                newName: "Cursos");

            migrationBuilder.RenameTable(
                name: "TABLE_VLEARN_ALUNO",
                newName: "Alunos");

            migrationBuilder.RenameColumn(
                name: "Nr_telefone",
                table: "Telefones",
                newName: "nr_telefone");

            migrationBuilder.RenameColumn(
                name: "Ddi",
                table: "Telefones",
                newName: "ddi");

            migrationBuilder.RenameColumn(
                name: "Ddd",
                table: "Telefones",
                newName: "ddd");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Telefones",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TelefoneId",
                table: "Professores",
                newName: "telefoneid");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Professores",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Professores",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "Professores",
                newName: "loginId");

            migrationBuilder.RenameColumn(
                name: "Idiomas",
                table: "Professores",
                newName: "idiomas");

            migrationBuilder.RenameColumn(
                name: "Formacao",
                table: "Professores",
                newName: "formacao");

            migrationBuilder.RenameColumn(
                name: "Experiencia",
                table: "Professores",
                newName: "experiencia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Professores",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_TABLE_VLEARN_PROFESSOR_TelefoneId",
                table: "Professores",
                newName: "IX_Professores_telefoneid");

            migrationBuilder.RenameIndex(
                name: "IX_TABLE_VLEARN_PROFESSOR_LoginId",
                table: "Professores",
                newName: "IX_Professores_loginId");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Logins",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Logins",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "Cursos",
                newName: "professorid");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Cursos",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cursos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Duracao",
                table: "Cursos",
                newName: "duracao");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Cursos",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "Cursos",
                newName: "autor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cursos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_TABLE_VLEARN_CURSO_ProfessorId",
                table: "Cursos",
                newName: "IX_Cursos_professorid");

            migrationBuilder.RenameColumn(
                name: "TelefoneId",
                table: "Alunos",
                newName: "Telefoneid");

            migrationBuilder.RenameIndex(
                name: "IX_TABLE_VLEARN_ALUNO_TelefoneId",
                table: "Alunos",
                newName: "IX_Alunos_Telefoneid");

            migrationBuilder.RenameIndex(
                name: "IX_TABLE_VLEARN_ALUNO_LoginId",
                table: "Alunos",
                newName: "IX_Alunos_LoginId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professores",
                table: "Professores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Logins_LoginId",
                table: "Alunos",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Telefones_Telefoneid",
                table: "Alunos",
                column: "Telefoneid",
                principalTable: "Telefones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Professores_professorid",
                table: "Cursos",
                column: "professorid",
                principalTable: "Professores",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Logins_loginId",
                table: "Professores",
                column: "loginId",
                principalTable: "Logins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Telefones_telefoneid",
                table: "Professores",
                column: "telefoneid",
                principalTable: "Telefones",
                principalColumn: "id");
        }
    }
}
