using Extensions.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class RaffleService : IRaffleService
    {
        private IConvertExtensions Extension { get; }

        public RaffleService(IConvertExtensions extension)
        {
            Extension = extension;
        }

        /// <summary>
        /// Verifica resultado do sorteio
        /// </summary>
        /// <param name="numbersUser">Numeros escolhidos pelo usuário</param>
        /// <param name="numbersRaffling">Numeros sorteados pelo sistema</param>
        /// <returns></returns>
        public List<int> CheckResult(List<int> numbersUser, List<int> numbersRaffling)
        {
            List<int> hits = new List<int>();

            foreach (var number in numbersUser)
            {
                if (numbersRaffling.Any(x => x.Equals(number)))
                {
                    hits.Add(number);
                }
            }

            return hits;
        }

        /// <summary>
        /// Sorteio aleatório de numeros
        /// </summary>
        /// <param name="quantityNumbers">Quantidade de numeros que serão sorteados</param>
        /// <returns>Quantidade de numeros</returns>
        public List<int> RafflingNumber(int quantityNumbers)
        {
            Random random = new Random();
            List<int> numbersRaffling = new List<int>();
            int aux;

            while (numbersRaffling.Count() != quantityNumbers)
            {
                aux = random.Next(1, 60);
                if (!numbersRaffling.Any(x => x.Equals(aux)))
                {
                    numbersRaffling.Add(aux);
                }
            }

            return numbersRaffling;
        }
    }
}
