using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extensions.Contracts;
using MegaSena.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace SorteioMegaSena.Controllers
{
    [Route("api")]
    public class MegaSenaController : Controller
    {
        private IRaffleService Service { get; }
        private IConvertExtensions Extension { get; }

        public MegaSenaController(IRaffleService service, IConvertExtensions extension)
        {
            Service = service;
            Extension = extension;
        }

        /// <summary>
        /// Rota responsável por verificar o resultado do sorteio
        /// </summary>
        /// <param name="data">Parametros do sorteio</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult CheckResult([FromBody] RaffleDataUser data)
        {

            List<int> numbersRaffling = Service.RafflingNumber(data.QuantityNumbers);

            try
            {
                Raffle raffle = new Raffle(Service.CheckResult(Extension.StringToList(data.Numbers),
                                            numbersRaffling),
                                            numbersRaffling,
                                            Extension.StringToList(data.Numbers),
                                            Extension);

                return Ok(raffle);
            }
            catch (Exception e)
            {
                return BadRequest(new ReturnMessage
                {
                    Status = "Error",
                    MessageDev = String.Format("{0} - {1}", e.Message, e.StackTrace)
                });
            }

        }

        /// <summary>
        /// Rota responsável por gerar números aleatórios
        /// </summary>
        /// <param name="QuantityNumbers">Quantos números deseja gerar</param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult RandomNumber([FromQuery] int QuantityNumbers)
        {
            if (QuantityNumbers <= 60)
            {

                try
                {
                    return Ok(Service.RafflingNumber(QuantityNumbers));
                }
                catch (Exception e)
                {
                    return BadRequest(new ReturnMessage
                    {
                        Status = "Error",
                        MessageDev = String.Format("{0} - {1}", e.Message, e.StackTrace)
                    });
                }
            }
            else
            {
                return BadRequest(new ReturnMessage
                {
                    Status = "Error",
                    MessageDev = "Não sorteamos mais que 60 números!"
                });
            }
        }
    }
}