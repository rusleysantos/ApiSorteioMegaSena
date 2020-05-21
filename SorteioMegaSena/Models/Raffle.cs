using Extensions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaSena.Models
{
    public class Raffle
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public List<int> NumbersHit { get; set; }
        public List<int> NumbersResult { get; set; }
        public List<int> NumbersUser { get; set; }
        public DateTime Date { get; set; }

        public Raffle(List<int> numbersHit, List<int> raffleNumbers, List<int> numbersUser, IConvertExtensions extension)
        {
            Random random = new Random();

            Id = random.Next(1, 100);
            switch (numbersHit.Count())
            {
                case 6:
                    Result = "Sena";
                    break;
                case 5:
                    Result = "Quina";
                    break;
                case 4:
                    Result = "Quadra";
                    break;
                default:
                    Result = "Você não ganhou nada!";
                    break;
            }
            NumbersResult = raffleNumbers;

            NumbersHit = numbersHit;

            NumbersUser = numbersUser;

            Date = DateTime.Now;
        }
    }
}
