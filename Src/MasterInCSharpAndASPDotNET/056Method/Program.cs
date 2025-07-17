using _056Method;
using System;

int number1, number2;

Test.Message("Welcome To Calculator System.");

Console.WriteLine("Please enter two number for summation by presing enter: ");
int sum = Test.Summation(int.Parse(Console.ReadLine()) , int.Parse(Console.ReadLine()));
Console.WriteLine($"Sum = {sum}");

Console.WriteLine("Please enter two number for subtraction by presing enter: ");
int sub = Test.Subtruction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine($"Sub = {sub}");

Console.WriteLine("Please enter two number for multiplication by presing enter:");
int mult = Test.Multiplication(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine($"Mult = {mult}");

Console.WriteLine("Please enter two number for division by presing enter:");
double div = Test.Division(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
Console.WriteLine($"Div = {div.ToString("F2")}");

Console.WriteLine("Please enter two number for modulas by presing enter:");
int mod = Test.Modulus(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine($"Mod = {mod}");

Test.Message("Good bye!");


