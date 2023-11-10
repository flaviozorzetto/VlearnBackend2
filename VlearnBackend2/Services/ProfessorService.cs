using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly PlataformaContext _context;
        public ProfessorService(PlataformaContext context)
        {
            _context = context;
        }

        public Professor CreateProfessor(ProfessorRequestDto professor)
        {
            var x = _context.Professores.Add(new Professor
            {
                Experiencia = professor.Experiencia,
                Formacao = professor.Formacao,
                Idiomas = professor.Idiomas,
                Nome = professor.Nome,
                Status = professor.Status,
                Login = professor.Login,
                Telefone = professor.Telefone,
            });
            _context.SaveChanges();

            return x.Entity;
        }

        public bool DeleteProfessorById(int id)
        {
            var professor = GetProfessorById(id);

            if (professor == null)
            {
                return false;
            }

            _context.Professores.Remove(professor);

            _context.SaveChanges();

            return true;
        }

        public IList<Professor> GetAllProfessor()
        {
            return _context.Professores.Include(x => x.Login).Include(x => x.Telefone).ToList();
        }

        public Professor? GetProfessorById(int id)
        {
            return _context.Professores.Include(x => x.Login).Include(x => x.Telefone).Where(x => x.Id == id).FirstOrDefault();
        }

        public Professor? UpdateProfessorById(int id, ProfessorRequestDto professorRequestDto)
        {
            var foundProfessor = GetProfessorById(id);

            if (foundProfessor == null)
            {
                return null;
            }

            foundProfessor.Nome = professorRequestDto.Nome;
            foundProfessor.Status = professorRequestDto.Status;
            foundProfessor.Experiencia = professorRequestDto.Experiencia;
            foundProfessor.Formacao = professorRequestDto.Formacao;
            foundProfessor.Idiomas = professorRequestDto.Idiomas;

            if (professorRequestDto.Telefone == null)
            {
                foundProfessor.Telefone = null;
            }
            else
            {
                if (foundProfessor.Telefone == null)
                {
                    var telefone = _context.Telefones.Where(x => x.Id == professorRequestDto.Telefone.Id).FirstOrDefault();

                    if (telefone != null)
                    {
                        foundProfessor.Telefone = telefone;
                    }
                    else
                    {
                        var createdTelefone = _context.Telefones.Add(new Telefone()
                        {
                            Nr_telefone = professorRequestDto.Telefone.Nr_telefone,
                            Ddd = professorRequestDto.Telefone.Ddd,
                            Ddi = professorRequestDto.Telefone.Ddi
                        }).Entity;

                        foundProfessor.Telefone = createdTelefone;
                    }

                }
                else
                {
                    foundProfessor.Telefone.Nr_telefone = professorRequestDto.Telefone.Nr_telefone;
                    foundProfessor.Telefone.Ddd = professorRequestDto.Telefone.Ddd;
                    foundProfessor.Telefone.Ddi = professorRequestDto.Telefone.Ddi;
                }
            }

            if (professorRequestDto.Login == null)
            {
                foundProfessor.Login = null;
            }
            else
            {
                if (foundProfessor.Login == null)
                {
                    var login = _context.Logins.Where(x => x.Id == professorRequestDto.Login.Id).FirstOrDefault();

                    if (login != null)
                    {
                        foundProfessor.Login = login;
                    }
                    else
                    {
                        var createdLogin =
                            _context.Logins.Add(new() { Email = professorRequestDto.Login.Email, Senha = professorRequestDto.Login.Senha }).Entity;

                        foundProfessor.Login = createdLogin;
                    }
                }
                else
                {
                    foundProfessor.Login.Email = professorRequestDto.Login.Email;
                    foundProfessor.Login.Senha = professorRequestDto.Login.Senha;
                }

            }

            var x = _context.Professores.Update(foundProfessor);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
