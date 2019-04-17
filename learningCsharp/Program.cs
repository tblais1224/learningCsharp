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

            bool isMale = true;
            bool isTall = false;
            //check if male and if tall
            if (isMale && isTall)
            {
                Console.WriteLine("You are a bro!");
                //!isTall using ! negates the boolean
            }else if (isMale && !isTall) {
                Console.WriteLine("you are a short bro");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall sis!");
            }
            else
            {
                Console.WriteLine("You are a short sis!");
            }

            Console.ReadLine();
        }

        

    }
}