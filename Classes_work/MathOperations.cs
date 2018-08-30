using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_work
{
    static class MathOperations
    {
        public static int Sum(params int [] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static bool IsNumber(string numberAsString,ref int number)       
        {
            try
            {
                number = int.Parse(numberAsString);
                return true;
            }
            catch 
            {
                return false;
            }            
        }
    }
}
