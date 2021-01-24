using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroServicioCatalogo.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("Catalogo")]
    public class CatalogoController : ApiController
    {
        [HttpGet]
        [Route("GetCatalogo")]
        public IHttpActionResult Items()
        {
            var resultado = CAD.Consulta.Catalogo();
            return Ok(resultado);
        }


        [HttpPost]
        [Route("SetCatalogo")]
        public IHttpActionResult Create(Models.Catalogo Obj)
        {
            var resultado = CAD.Inserta.Catalogo(Obj);

            return Ok(resultado);
        }

    }
}
