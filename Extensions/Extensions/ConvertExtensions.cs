using Extensions.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Extensions
{
    public class ConvertExtensions : IConvertExtensions
    {
        public List<int> IntToList(int number)
        {
            var digits = new List<int>();
            var integer = number;

            while (integer > 0)
            {
                digits.Add(integer % 10);
                integer /= 10;
            }

            return digits;
        }
    }
}
