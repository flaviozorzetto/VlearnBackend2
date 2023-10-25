using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class LoginService : ILoginService
    {
        private readonly PlataformaContext _context;
        public LoginService(PlataformaContext context) 
        {
            _context = context;
        }

        public Login CreateLogin(LoginRequestDto loginDto)
        {
            var x = _context.Logins.Add(new Login { email = loginDto.email, senha = loginDto.senha});
            _context.SaveChanges();

            return x.Entity;
        }

        public void DeleteLoginById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Login> GetAllLogin()
        {
            return _context.Logins.ToList();
        }

        public Login GetLoginById(int id)
        {
            throw new NotImplementedException();
        }

        public Login UpdateLoginById(int id, LoginRequestDto Login)
        {
            throw new NotImplementedException();
        }
    }
}
