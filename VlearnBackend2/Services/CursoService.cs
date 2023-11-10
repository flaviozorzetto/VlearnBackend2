using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class CursoService : ICursoService
    {
        private readonly PlataformaContext _context;
        public CursoService(PlataformaContext context)
        {
            _context = context;
        }

        public Curso CreateCurso(CursoRequestDto curso)
        {
            var x = _context.Cursos.Add(new Curso()
            {
                Autor = curso.Autor,
                Descricao = curso.Descricao,
                Duracao = curso.Duracao,
                Nome = curso.Nome,
                Preco = curso.Preco,
                Professor = curso.Professor,
            });

            _context.SaveChanges();
            return x.Entity;
        }

        public bool DeleteCursoById(int id)
        {
            var curso = GetCursoById(id);

            if (curso == null)
            {
                return false;
            }

            _context.Cursos.Remove(curso);

            _context.SaveChanges();

            return true;
        }

        public IList<Curso> GetAllCurso()
        {
            return _context.Cursos
                .Include(x => x.Professor).ThenInclude(x => x.Login)
                .Include(x => x.Professor).ThenInclude(x => x.Telefone)
                .ToList();
        }

        public Curso? GetCursoById(int id)
        {
            return _context.Cursos
                .Include(x => x.Professor).ThenInclude(x => x.Login)
                .Include(x => x.Professor).ThenInclude(x => x.Telefone)
                .Where(x => x.Id == id).FirstOrDefault();
        }

        public Curso? UpdateCursoById(int id, CursoRequestDto cursoRequestDto)
        {
            var foundCurso = GetCursoById(id);

            if (foundCurso == null)
            {
                return null;
            }

            foundCurso.Autor = cursoRequestDto.Autor;
            foundCurso.Duracao = cursoRequestDto.Duracao;
            foundCurso.Descricao = cursoRequestDto.Descricao;
            foundCurso.Preco = cursoRequestDto.Preco;

            if(cursoRequestDto.Professor != null && foundCurso.Professor == null)
            {
                var professor = _context.Professores.Where(x => x.Id == cursoRequestDto.Professor.Id).FirstOrDefault();

                if (professor != null)
                {
                    foundCurso.Professor = professor;
                }
            }

            var x = _context.Cursos.Update(foundCurso);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
