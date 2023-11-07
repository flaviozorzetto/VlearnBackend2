using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Interfaces
{
    public interface IAlunoService
    {
        IList<Aluno> GetAllAluno();
        Aluno? GetAlunoById(int id);
        Aluno CreateAluno(AlunoRequestDto aluno);
        Aluno? UpdateAlunoById(int id, AlunoRequestDto aluno);
        bool DeleteAlunoById(int id);
    }
}
