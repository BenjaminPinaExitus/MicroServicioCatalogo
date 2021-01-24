using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroServicioCatalogo.CAD
{
    public class Consulta
    {
        public static List<Models.Catalogo> Catalogo()
        {
            var resultado = new List<Models.Catalogo>();

            using(CatalogosMSEntities context = new CatalogosMSEntities())
            {
                resultado = (from c in context.Catalogos
                             select new Models.Catalogo
                             {
                                 Activo = c.Activo,
                                 Descripcion = c.Descripcion,
                                 Id = c.Id,
                                 Nombre = c.Nombre,
                                 Precio = c.Precio
                             }).ToList();
            }

            return resultado;
        }
    }
}