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
            //writes the string to the console and stays on the same line
            Console.Write("Enter your name: ");
            //pauses program to allow user to input text
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age + "years old.");
            //pauses so we can view result
            Console.ReadLine();
        }
    }
}

