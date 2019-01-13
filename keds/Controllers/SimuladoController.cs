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
    public class SimuladoController
    {
        [HttpPost]
        public ActionResult<Simulado> Post([FromServices] SimuladoDao dao,
                                  [FromBody] Simulado value)
        {
            try
            {
                return dao.add(value);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(400);
            }
        }
    }
}
