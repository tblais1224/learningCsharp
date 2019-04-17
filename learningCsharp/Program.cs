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

            Console.Write("Enter a number: ");
            //must convert string to double
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string oper = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (oper == "+"){
                Console.WriteLine(num1 + num2);
            }   else if(oper == "-"){
                Console.WriteLine(num1 - num2);
             }  else if(oper == "/"){
                Console.WriteLine(num1 / num2);
             }  else if(oper == "*"){
                Console.WriteLine(num1 * num2);
             }  else {
                Console.WriteLine("Invalid Operator you stupid human!!!");
             }

            Console.ReadLine();

        }
    }
}