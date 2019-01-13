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
    public class QuestaoController
    {
        [HttpPost]
        public ActionResult<Questao> Post([FromServices] QuestaoDao dao,
                                          [FromBody] Questao value)
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
        public ActionResult<IEnumerable<Questao>> Get([FromServices] QuestaoDao dao)
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

        [HttpGet("{id}")]
        public ActionResult<Questao> Get([FromServices] QuestaoDao dao, Guid id)
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
