using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056Method
{
    public class Test
    {
        public static int Summation(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Subtruction(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public static double Division(double number1, double number2)
        {
             return number1 / number2;
        }
        public static int Modulus(int number1, int number2)
        {
            return number1 % number2;
        }

        public static void Message(string text)
        {
            Console.WriteLine(text);
        }
    }
}
