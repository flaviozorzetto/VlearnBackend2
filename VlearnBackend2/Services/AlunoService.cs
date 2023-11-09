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
            var aluno = GetAlunoById(id);

            if (aluno == null)
            {
                return false;
            }

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return true;
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

            if(alunoRequestDto.Telefone == null)
            {
                foundAluno.Telefone = null;
            } else
            {

            }

            if(alunoRequestDto.Login == null)
            {
                foundAluno.Login = null;
            } 
            else
            {
                if (foundAluno.Login == null)
                {
                    var login = _context.Logins.Where(x => x.Id == alunoRequestDto.Login.Id).FirstOrDefault();

                    if(login != null)
                    {
                        foundAluno.Login = login;
                    } 
                    else
                    {
                        var createdLogin = 
                            _context.Logins.Add(new () { Email = alunoRequestDto.Login.Email, Senha = alunoRequestDto.Login.Senha}).Entity;
                        
                        foundAluno.Login = createdLogin;
                    }
                } else
                {
                    foundAluno.Login.Email = alunoRequestDto.Login.Email;
                    foundAluno.Login.Senha = alunoRequestDto.Login.Senha;
                }
                
            }

            var x = _context.Alunos.Update(foundAluno);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
