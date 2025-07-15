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
double fahrenheightToCelsius, kelvinToCelcius, fahrenheit, kelvin;

Console.Write("Please enter the temperatude as Fahrenheit: ");
fahrenheit = double.Parse(Console.ReadLine());

Console.Write("Please enter the temperatude as Kelvin: ");
kelvin = double.Parse(Console.ReadLine());

fahrenheightToCelsius = ((fahrenheit - 32) * 5 / 9);
kelvinToCelcius = kelvin - 273.15;

Console.WriteLine($"{fahrenheit} degree fahrenheight = {fahrenheightToCelsius.ToString("F2")} degree celcius.");
Console.WriteLine($"{kelvin} degree Kelvin = {kelvinToCelcius.ToString("F2")} degree celcius.");


Console.WriteLine("\n\nCurrency Converter\n\n");
const double usdRate = 121.22;
double bdt, usd, convertedResult;
int choice;

Console.Write("\n1 for BDT to USD\n2 for USD to BDT\nPlease enter your choise: ");
choice = int.Parse(Console.ReadLine());
if(choice == 1 || choice == 2)
{
    if(choice == 1)
    {
        Console.Write("please enter BDT amount: ");
        bdt = double.Parse(Console.ReadLine());
        convertedResult = bdt / usdRate;
        Console.WriteLine($"{bdt} BDT = {convertedResult.ToString("F2")} USD");
    }
    else
    {
        Console.Write("please enter USD amount: ");
        usd = double.Parse(Console.ReadLine());
        convertedResult = usd * usdRate;
        Console.WriteLine($"{usd} USD = {convertedResult.ToString("F2")} BDT");
    }
}
else
    Console.WriteLine("Invalid Input!");



