using VlearnBackend2.Models.Dto;
using VlearnBackend2.Models;

namespace VlearnBackend2.Interfaces
{
    public interface ITelefoneService
    {
        IList<Telefone> GetAllTelefone();
        Telefone GetTelefoneById(int id);
        Telefone CreateTelefone(TelefoneRequestDto Telefone);
        Telefone UpdateTelefoneById(int id, TelefoneRequestDto Telefone);
        void DeleteTelefoneById(int id);
    }
}
