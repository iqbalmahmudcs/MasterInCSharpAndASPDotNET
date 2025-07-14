int number1 = 10;
int number2 = 3;
int result;
double div;

//Arithmetic Operation
result = number1 + number2;
Console.WriteLine($"{number1} + {number2} = {result}");
result = number1 - number2;
Console.WriteLine($"{number1} - {number2} = {result}");
result = number1 * number2;
Console.WriteLine($"{number1} * {number2} = {result}");
div = (double)number1 / number2;
Console.WriteLine($"{number1} / {number2} = {div.ToString("F2")}");
result = number1 % number2;
Console.WriteLine($"{number1} % {number2} = {result}");


//Assignment: 4
Console.WriteLine("\n\nAssignment 4\n\n");

Console.WriteLine("Sum and average calculation");
int num1, num2, num3, sum;
double avg;

Console.WriteLine("Please enter three numbers by preaching enter: ");
Console.Write("Number-1: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Number-2: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Number-3: ");
num3 = int.Parse(Console.ReadLine());

sum = num1 + num2 + num3;
avg = (double)sum / 3;

Console.WriteLine($"{num1} + {num2} + {num2} = {sum}");
Console.WriteLine($"({num1} + {num2} + {num2}) / 3 = {avg.ToString("F2")}");



Console.WriteLine("\n\nArea calculation of Triangle\n\n");
double basee;
double height;
double areaOfTriangle;

Console.Write("Please enter the Base of the Triangle: ");
basee = double.Parse(Console.ReadLine());
Console.Write("Please enter the Height of the Triangle: ");
height = double.Parse(Console.ReadLine());

areaOfTriangle = 0.5 * basee * height;

Console.WriteLine($"The area of the Triangle is: {areaOfTriangle.ToString("F3")}");



Console.WriteLine("\n\nArea calculation of Circle\n\n");
const double pi = 3.1416;
double radius, areaOfCircle;

Console.Write("Please enter the Radius of the Circle: ");
radius = double.Parse(Console.ReadLine());

areaOfCircle = pi * radius * radius;
Console.WriteLine($"The area of the Circle is: {areaOfCircle.ToString("F3")}");




Console.WriteLine("\n\nArea calculation of Rectangle\n\n");
double lenth, width, areaOfRectangle;

Console.Write("Please enter the Lenth of the Rectangle: ");
lenth = double.Parse(Console.ReadLine());
Console.Write("Please enter the Width of the Rectangle: ");
width = double.Parse(Console.ReadLine());

areaOfRectangle = lenth * width;
Console.WriteLine($"The area of Rectangle is: {areaOfRectangle.ToString("F3")}");



Console.WriteLine("\n\nTemperature Converter\n\n");
double celsius, fahrenheit;
int choise;

Console.Write("1 for Celsius to Fahrenheight \n 2 for Fahrenheight to Celsius, Please enter your choise: ");
choise = int.Parse(Console.ReadLine());
if (choise != 1 && choise != 2)
{
    Console.Write("\nWrong Input!\n1 for Celsius to Fahrenheight \n 2 for Fahrenheight to Celsius, Please enter your choise: ");
    choise = int.Parse(Console.ReadLine());
}

switch (choise)
{
    case 1:
        Console.Write("Please enter celceus ");
        fahrenheit = celsius * (9 / 5) + 32; 
        break;

}






Console.WriteLine("\n\nCurrency Converter\n\n");

