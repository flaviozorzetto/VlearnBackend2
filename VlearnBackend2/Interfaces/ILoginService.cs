using VlearnBackend2.Models.Dto;
using VlearnBackend2.Models;

namespace VlearnBackend2.Interfaces
{
    public interface ILoginService
    {
        IList<Login> GetAllLogin();
        Login GetLoginById(int id);
        Login CreateLogin(LoginRequestDto Login);
        Login UpdateLoginById(int id, LoginRequestDto Login);
        void DeleteLoginById(int id);
    }
}
