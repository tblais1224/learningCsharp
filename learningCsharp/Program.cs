using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 1;
            while (index <= 5)
	        {
                Console.WriteLine(index);
                index++;
	        }

            int indexDoWhile = 3;
            do {
            Console.WriteLine(indexDoWhile);
            indexDoWhile++;
            } while (indexDoWhile <= 5);

            Console.ReadLine();

        }
    }
}