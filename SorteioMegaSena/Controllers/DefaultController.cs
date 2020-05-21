using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MegaSena.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        [HttpGet("[action]")]
        public string Index()
        {
            return String.Format("Bem-Vindo a Api da Mega Sena consulta feita em {0}", DateTime.Now);
        }
    }
}