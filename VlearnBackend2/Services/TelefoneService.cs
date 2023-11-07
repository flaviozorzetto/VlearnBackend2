using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly PlataformaContext _context;
        public TelefoneService(PlataformaContext context)
        {
            _context = context;
        }
        public Telefone CreateTelefone(TelefoneRequestDto telefoneDto)
        {
            var x = _context.Telefones.Add(new Telefone { Ddd = telefoneDto.Ddd, Ddi = telefoneDto.Ddi, Nr_telefone = telefoneDto.Nr_telefone });
            _context.SaveChanges();

            return x.Entity;
        }

        public bool DeleteTelefoneById(int id)
        {
            var telefone = GetTelefoneById(id);

            if (telefone == null)
            {
                return false;
            }

            _context.Telefones.Remove(telefone);
            _context.SaveChanges();

            return true;
        }

        public IList<Telefone> GetAllTelefone()
        {
            return _context.Telefones.ToList();
        }

        public Telefone? GetTelefoneById(int id)
        {
            return _context.Telefones.Find(id);
        }

        public Telefone? UpdateTelefoneById(int id, TelefoneRequestDto telefone)
        {
            var foundTelefone = GetTelefoneById(id);

            if (foundTelefone == null)
            {
                return null;
            }

            foundTelefone.Nr_telefone = telefone.Nr_telefone;
            foundTelefone.Ddd = telefone.Ddd;
            foundTelefone.Ddi = telefone.Ddi;

            var x = _context.Telefones.Update(foundTelefone);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
