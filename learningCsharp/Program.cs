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
            string adjective, pluralNoun, noun;
            Console.Write("Enter an adjective: ");
            adjective = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.WriteLine("Coding is "+adjective);
            Console.WriteLine("I hate "+ pluralNoun);
            Console.WriteLine("but I love "+noun+"!");

            Console.ReadLine();
        }
    }
}

////Convert.Method() is used to convert things such as string to num
//int num = Convert.ToInt32("12");
//Console.WriteLine(num + 6);
//Console.ReadLine();