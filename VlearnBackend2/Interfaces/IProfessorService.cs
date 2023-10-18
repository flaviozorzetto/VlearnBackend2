using VlearnBackend2.Models.Dto;
using VlearnBackend2.Models;

namespace VlearnBackend2.Interfaces
{
    public interface IProfessorService
    {
        IList<Professor> GetAllProfessor();
        Professor GetProfessorById(int id);
        Professor CreateProfessor(ProfessorRequestDto Professor);
        Professor UpdateProfessorById(int id, ProfessorRequestDto Professor);
        void DeleteProfessorById(int id);
    }
}
