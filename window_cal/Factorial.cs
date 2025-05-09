﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace window_cal
{
    internal class Factorial
    {
        public long factorialCal(string word)
        {
            Console.WriteLine(word);
            int startIndex = word.IndexOf("(") + 1;  
            int endIndex = word.IndexOf(")"); 
            long result = 1;

            if (int.Parse(word) < 0)
            {
                for (int i = 1; i <=  ((-1) * int.Parse(word)); i++)
                {
                    result *= i;
                }
                result *= (-1);
            }
            else
            {
                for (int i = 1; i <= int.Parse(word); i++)
                {
                    result *= i;
                }
            }
               

            return result;

        }
    }
}
