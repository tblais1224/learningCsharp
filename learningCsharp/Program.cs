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
            //must use [] to tell that its array of ints
            int[] luckyNumbers = { 2, 5, 22, 56, 32, 69, 12, 5 };
            //empty array for strings
            //new string[number of values for the array to hold]
            string[] friends = new string[5];
            friends[0] = "Tom";
            friends[1] = "Evan";
            friends[2] = "Rob";
            friends[3] = "Mike";
            friends[4] = "Nate";


            Console.WriteLine(luckyNumbers[5] + friends[3]);

            Console.ReadLine();
        }
    }
}

////Convert.Method() is used to convert things such as string to num
//int num = Convert.ToInt32("12");
//Console.WriteLine(num + 6);
//Console.ReadLine();