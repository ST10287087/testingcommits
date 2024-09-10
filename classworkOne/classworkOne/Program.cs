using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworkOne
{
    public class Program
    {
          delegate int CalculationDelagate(int a, int b);
        static void Main(string[] args)
        {
            CalculationDelagate calculateMethod;
            Console.WriteLine("chose a calculation operation");
            Console.WriteLine(" 1 . Addition");
            Console.WriteLine(" 2 . Subtraction");
            Console.WriteLine(" 3 . Addition");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    calculateMethod = Add;
                    break;
                case 2:
                    calculateMethod = Subtract;
                    break;
                    case 3:
                    calculateMethod = Multiply;
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Exitingg...");
                    return;
            }
            Console.WriteLine("enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            int result = calculateMethod(num1, num2);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
          static int Add( int a , int b)
        {
            return a + b;
        }
         static int Subtract(int a, int b)
        {
            return a - b;
        }
         static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
