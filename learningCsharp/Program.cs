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
            //call methods here in main method to get output
            //call the method
            SayHi("Maddie", 69);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

    }
}