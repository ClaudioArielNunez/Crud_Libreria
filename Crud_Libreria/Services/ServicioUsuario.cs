using Crud_Libreria.Datalayer;
using Crud_Libreria.Models.Entidades;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Crud_Libreria.Services
{
    public class ServicioUsuario : IServicioUsuario
    {
        private readonly LibreriaContext context;

        public ServicioUsuario(LibreriaContext context)
        {
            this.context = context;
        }
        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario = await context.Usuarios.Where(x => x.Correo == correo && x.Clave == clave).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<Usuario> GetUsuario(string nombreUsuario)
        {
            var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == nombreUsuario);
            return usuario;
        }

        public async Task<Usuario> SaveUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();
            return usuario;            
        }
    }
}
