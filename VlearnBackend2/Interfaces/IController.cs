using Microsoft.AspNetCore.Mvc;

namespace VlearnBackend2.Interfaces
{
    public interface IController<T>
    {
        IActionResult Index();
        IActionResult FindById(int id);
        IActionResult Add(T dto);
        IActionResult Delete(int id);
        IActionResult Update(int id, T dto);
    }
}
