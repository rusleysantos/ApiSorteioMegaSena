using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Contracts
{
    public interface IConvertExtensions
    {
        public List<int> IntToList(int number);
        public List<int> StringToList(string text);
    }
}
