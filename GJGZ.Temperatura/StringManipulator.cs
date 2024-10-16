using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GJGZ.Temperatura
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            // Implementa la inversión de la cadena
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            // Implementa la eliminación de espacios en blanco
            return input.Replace(" ", string.Empty);
        }
    }
}
