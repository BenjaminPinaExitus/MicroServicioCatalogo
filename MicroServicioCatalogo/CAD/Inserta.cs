using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroServicioCatalogo.CAD
{
    public class Inserta
    {
        public static bool Catalogo(Models.Catalogo Obj)
        {
            var resultado = false;

            using (CatalogosMSEntities context = new CatalogosMSEntities())
            {
                var ent = new Catalogos
                {
                    Activo = Obj.Activo,
                    Descripcion = Obj.Descripcion,
                    Id = Obj.Id,
                    Nombre = Obj.Nombre,
                    Precio = Obj.Precio
                };

                context.Catalogos.Add(ent);
                context.SaveChanges();
                resultado = true;
            }

            return resultado;
        }
    }
}