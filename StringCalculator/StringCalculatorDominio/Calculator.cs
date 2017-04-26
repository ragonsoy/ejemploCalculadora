using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorDominio
{
    public class Calculator
    {
        int DEFAULT_VALUE = 0;

        public int Add(string numbers)
        {
            try
            {
                if (HasNumbers(numbers))
                    return AddMultipleNumbers(Particionar(numbers));
                return DEFAULT_VALUE;
            }
            catch (Exception)
            {
                throw new NotANumberException();
            }
            
        }

        private int AddMultipleNumbers(string[] numbers)
        {
            int retorno = 0;
            foreach (string number in numbers)            
                retorno = retorno + ConvertStringToInt(number);
            return retorno;
        }

        private string[] Particionar(string numbers)
        {
            return numbers.Split(',');
        }

        private bool HasNumbers(string numbers)
        {
            return numbers.Length > 0;
        }

        private int ConvertStringToInt(string numbers)
        {
            return Int32.Parse(numbers);
        }
    }
}
