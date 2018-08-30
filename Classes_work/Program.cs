using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_work
{
    class Program
    {
        private string name;
        static void Main(string[] args)
        {
            // тип имя_переменой=new конструктор(парамметры)
            Person person = new Person();
            Console.WriteLine(MathOperations.Sum(1,2,3,4,5));
            string numberAsString = "1234a";
            int result;
            //bool isParsed = int.TryParse(numberAsString,out result);
           bool isParsed= MathOperations.IsNumber(numberAsString, ref result);
        }
    }
}
