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
            string characterName = "Maddie";
            int characterAge;
            characterAge = 60;

            Console.WriteLine("There once was a lady name " + characterName);
            Console.WriteLine("She was "+characterAge+" years old");
            Console.WriteLine("She really like to walk her dogs");
            Console.WriteLine("But didnt like somebody who was also " + characterAge);

            Console.ReadLine();
        }
    }
}
