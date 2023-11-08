using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly PlataformaContext _context;
        public AlunoService(PlataformaContext context)
        {
            _context = context;
        }
        public Aluno CreateAluno(AlunoRequestDto alunoDto)
        {
            var x = _context.Alunos.Add(new Aluno { Nome = alunoDto.Nome, TipoPcd = alunoDto.TipoPcd, Login = alunoDto.Login, Telefone = alunoDto.Telefone });
            _context.SaveChanges();

            return x.Entity;
        }

        public bool DeleteAlunoById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> GetAllAluno()
        {
            return _context.Alunos.Include(x => x.Login).ToList();
        }

        public Aluno? GetAlunoById(int id)
        {
            return _context.Alunos.Include(x => x.Login).Where(x => x.Id == id).FirstOrDefault();
        }

        public Aluno? UpdateAlunoById(int id, AlunoRequestDto alunoRequestDto)
        {
            var foundAluno = GetAlunoById(id);

            if (foundAluno == null)
            {
                return null;
            }

            foundAluno.Nome = alunoRequestDto.Nome;
            foundAluno.TipoPcd = alunoRequestDto.TipoPcd;
            foundAluno.Telefone = alunoRequestDto.Telefone;
            if(alunoRequestDto.Login == null)
            {
                foundAluno.Login = null;
            } else
            {
                if (alunoRequestDto.Login.Id != 0 && foundAluno.Login == null)
                {
                    foundAluno.Login = new Login() { Id = alunoRequestDto.Login.Id };
                }
                foundAluno.Login.Email = alunoRequestDto.Login.Email;
                foundAluno.Login.Senha = alunoRequestDto.Login.Senha;
            }

            var x = _context.Alunos.Update(foundAluno);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
