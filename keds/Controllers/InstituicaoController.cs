using keds.DAO;
using keds.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController
    {
        [HttpPost]
        public ActionResult<Instituicao> Post([FromServices] InstituicaoDao dao,
                                          [FromBody] Instituicao value)
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

        [HttpGet]
        public ActionResult<IEnumerable<Instituicao>> Get([FromServices] InstituicaoDao dao)
        {
            try
            {
                return dao.findAll().ToList();
            }
            catch (Exception e)
            {
                return new StatusCodeResult(400);
            }

        }
    }
}
