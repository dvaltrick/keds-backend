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
    public class ProvaController
    {
        [HttpPost]
        public ActionResult<Prova> Post([FromServices] ProvaDao dao,
                                        [FromServices] InstituicaoDao insDao,
                                          [FromBody] Prova value)
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
        public ActionResult<IEnumerable<Prova>> Get([FromServices] ProvaDao dao)
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

        [HttpGet("byinstituicao/{id}")]
        public ActionResult<IEnumerable<Prova>> GetByInstituicao([FromServices] ProvaDao dao,
                                                                  Guid id  )
        {
            try
            {
                return dao.findByInstituicao(id);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(400);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Prova> Get([FromServices] ProvaDao dao, Guid id)
        {
            try
            {
                return dao.find(id);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(400);
            }
        }
    }
}
