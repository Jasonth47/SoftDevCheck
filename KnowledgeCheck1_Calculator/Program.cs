using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            string Number1, Number2;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                   
                    Number(out Number1, out Number2);


                    if (int.TryParse(Number1, out int addNumOne) && int.TryParse(Number2, out int addNumTwo))
                    {
                        Console.Write($"{Number1} + {Number2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                   
                    Number(out Number1, out Number2);

                    if (int.TryParse(Number1, out int subNumOne) && int.TryParse(Number2, out int subNumTwo))
                    {
                        Console.Write($"{Number1} - {Number2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    // Add code here
                    Console.WriteLine("Enter 2 integers to multiply");
                    
                    Number(out Number1, out Number2);

                    if (int.TryParse(Number1, out int multiNumOne) && int.TryParse(Number2, out int multiNumTwo))
                    {
                        Console.Write($"{Number1} X {Number2} = ");
                        Console.Write(calculator.Multiply(multiNumOne, multiNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                   
                    Number(out Number1, out Number2);

                    if (double.TryParse(Number1, out double divNumOne) && double.TryParse(Number2, out double divNumTwo))
                    {
                        Console.Write($"{Number1} / {Number2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                   

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        private static void Number(out string Number1, out string Number2)
        {
            Number1 = Console.ReadLine();
            Number2 = Console.ReadLine();
        }
    }
}