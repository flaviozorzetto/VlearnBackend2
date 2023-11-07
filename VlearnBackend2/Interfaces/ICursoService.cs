using VlearnBackend2.Models.Dto;
using VlearnBackend2.Models;

namespace VlearnBackend2.Interfaces
{
    public interface ICursoService
    {
        IList<Curso> GetAllCurso();
        Curso? GetCursoById(int id);
        Curso CreateCurso(CursoRequestDto Curso);
        Curso? UpdateCursoById(int id, CursoRequestDto Curso);
        bool DeleteCursoById(int id);
    }
}
