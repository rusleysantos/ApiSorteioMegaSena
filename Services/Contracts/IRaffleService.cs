using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IRaffleService
    {
        public List<int> RafflingNumber(int quantityNumbers);
        public List<int> CheckResult(List<int> numbersUser, List<int> numbersRaffling);
    }
}
