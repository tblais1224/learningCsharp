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

            string phrase = "Black holes are cool " + "also the General Theory or Relativity is intriguing.";
            
            Console.WriteLine(phrase.Substring(10, 5));
            Console.WriteLine("Black holes\" are cool");
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.Contains("cool"));

            Console.ReadLine();
        }
    }
}

