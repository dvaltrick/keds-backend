using keds.DAO;
using keds.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {
        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<Usuario> Post([FromBody] Usuario toSave,
                                          [FromServices] UsuarioDao dao)
        {
            try {
                return dao.add(toSave);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(400);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get([FromServices] UsuarioDao dao)
        {
            return dao.findAll().ToList();
        }
    }
}
