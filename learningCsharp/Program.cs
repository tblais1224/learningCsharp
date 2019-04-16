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
            int cubedNumber = CubeNum(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }

        //this method returns a int called result and inputs and int called num
        static int CubeNum(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}