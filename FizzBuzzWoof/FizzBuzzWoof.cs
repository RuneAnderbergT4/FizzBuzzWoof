using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWoof
{
    public class FizzBuzzWoof
    {
        public string Convert(int input)
        {
            char[] chars = input.ToString().ToCharArray();

            string fizz = String.Empty;
            string buzz = String.Empty;
            string woof = String.Empty;
            
            // Checks if divisible by 3
            if ((input % 3) == 0)
                fizz += "Fizz ";

            // Checks if divisible by 5
            if ((input % 5) == 0)
                buzz += "Buzz ";
            
            // Check if divisible by 7
            if ((input % 7) == 0)
                woof += "Woof ";

            // Checks if contains 3, 5 or 7
            foreach (char c in chars)
            {
                if (c == '3')
                    fizz += "Fizz ";
                if (c == '5')
                    buzz += "Buzz ";
                if (c == '7')
                    woof += "Woof ";
            }

            if (fizz == "" && buzz == "" && woof == "")
                return input.ToString();

            return (fizz + buzz + woof).Trim();
        }
    }
}