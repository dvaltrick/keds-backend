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
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<Usuario> Login([FromServices] UsuarioDao dao,
                                        [FromBody] Usuario toLogin)
        {
            return dao.Auth(toLogin);
        }
    }
}
