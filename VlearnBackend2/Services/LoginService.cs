using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Services
{
    public class LoginService : ILoginService
    {
        private readonly PlataformaContext _context;
        private readonly ILogger<LoginService> _logger;
        public LoginService(PlataformaContext context, ILogger<LoginService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Login CreateLogin(LoginRequestDto loginDto)
        {
            var x = _context.Logins.Add(new Login { Email = loginDto.Email, Senha = loginDto.Senha });
            _context.SaveChanges();

            return x.Entity;
        }

        public bool DeleteLoginById(int id)
        {
            var login = GetLoginById(id);

            if (login == null)
            {
                return false;
            }

            _context.Logins.Remove(login);
            _context.SaveChanges();

            return true;
        }

        public IList<Login> GetAllLogin()
        {
            _logger.LogInformation("Getting all logins");
            return _context.Logins.ToList();
        }

        public Login? GetLoginById(int id)
        {
            return _context.Logins.Find(id);
        }

        public Login? UpdateLoginById(int id, LoginRequestDto login)
        {
            var foundLogin = GetLoginById(id);

            if (foundLogin == null)
            {
                return null;
            }

            foundLogin.Senha = login.Senha;
            foundLogin.Email = login.Email;

            var x = _context.Logins.Update(foundLogin);
            _context.SaveChanges();

            return x.Entity;
        }
    }
}
