using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud_Libreria.Services
{
    public interface IServicioLista
    {
        //Cargamos desplegables
        Task<IEnumerable<SelectListItem>> GetListaAutores();
        Task<IEnumerable<SelectListItem>> GetListaCategorias();
    }
}
