using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("Enter the first number: ");
                int digit1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int digit2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Select the action to be performed: \n");
                Console.Write("Press 1 for Addition \n");
                Console.Write("Press 2 for Subtraction \n");
                Console.Write("Press 3 for Multiplication \n");
                Console.Write("Press 4 for Division\n");
                int action = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (action)
                {
                    case 1:
                        {
                            result = Addition(digit1, digit2);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(digit1, digit2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(digit1, digit2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(digit1, digit2);
                            break;
                        }
                }
                Console.WriteLine("The Result is {0}", result);

                Console.WriteLine("\n\n Do you want to end this session? (Y/y)");
                status = Console.ReadKey();
                if(status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
        }

        private static int Addition(int digit1, int digit2)
        {
            int result = digit1 + digit2;
            return result;
        }

        private static int Subtraction(int digit1, int digit2)
        {
            int result = digit1 - digit2;
            return result;
        }

        private static int Multiplication(int digit1, int digit2)
        {
            int result = digit1 * digit2;
            return result;
        }

        private static int Division(int digit1, int digit2)
        {
            int result = digit1 / digit2;
            return result;
        }
    }
}
