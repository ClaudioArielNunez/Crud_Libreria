using Crud_Libreria.Models.Entidades;

namespace Crud_Libreria.Services
{
    public interface IServicioUsuario
    {
        Task<Usuario> GetUsuario(string correo, string clave); //autentica el usuario
        Task<Usuario> SaveUsuario(Usuario usuario);
        Task<Usuario> GetUsuario(string nombreUsuario); //Trae el nombre del usuario autenticado
    }
}
