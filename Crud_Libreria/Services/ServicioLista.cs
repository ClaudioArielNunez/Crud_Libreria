using Crud_Libreria.Datalayer;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Crud_Libreria.Services
{
    public class ServicioLista : IServicioLista
    {
        private readonly LibreriaContext _context;

        public ServicioLista(LibreriaContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<SelectListItem>> GetListaAutores()
        {
            List<SelectListItem> list = await _context.Autores.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = x.Id.ToString()
            }).OrderBy(x => x.Text).ToListAsync();
                        
            //insertamos en la primera posicion un nuevo elemento
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un autor.....]",
                Value = "0"
            });

            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaCategorias()
        {
            List<SelectListItem> list = await _context.Categorias.Select(x => new SelectListItem { Text = x.Nombre, Value = x.Id.ToString()}).OrderBy(x =>x.Text).ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoria.....]",
                Value = "0"
            });

            return list;
        }
    }
}
