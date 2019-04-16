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
            //writes to console
            Console.Write("Enter a number: ");
            //readline pauses script until user inputs, 
            //result is converted from string to int32
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}

////Convert.Method() is used to convert things such as string to num
//int num = Convert.ToInt32("12");
//Console.WriteLine(num + 6);
//Console.ReadLine();