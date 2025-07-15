//Conditional Statements

////IF Condition
//int number = 30;

//if(number > 0)
//    Console.WriteLine($"{number} is a positive Number");
//else if (number < 0)
//    Console.WriteLine($"{number} is a negative Number");
//else
//    Console.WriteLine($"{number} is nutral Number");



////Assignment
//Console.Write("Please enter a number 0-9: ");
//int number = int.Parse(Console.ReadLine());

//while(number >= 0 && number <= 9)
//{
//    if (number == 0)
//        Console.WriteLine("Zero");
//    else if (number == 1)
//        Console.WriteLine("One");
//    else if (number == 2)
//        Console.WriteLine("Two");
//    else if (number == 3)
//        Console.WriteLine("Three");
//    else if (number == 4)
//        Console.WriteLine("Four");
//    else if (number == 5)
//        Console.WriteLine("Five");
//    else if (number == 6)
//        Console.WriteLine("Six");
//    else if (number == 7)
//        Console.WriteLine("Seven");
//    else if (number == 8)
//        Console.WriteLine("Eight");
//    else if (number == 9)
//        Console.WriteLine("Nine");
//    else
//        Console.WriteLine("Invalid digit.");
//    Console.Write("Please enter a number 0-9: ");
//    number = int.Parse(Console.ReadLine());
//}


////Assignment 7
//Console.Write("Please enter a number: ");
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//    Console.WriteLine($"The {number} is even.");
//else
//    Console.WriteLine($"The {number} is odd.");



////Assignment 8
//Console.Write("Please enter number 1: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.Write("Please enter number 2: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.Write("Please enter number 3: ");
//int number3 = int.Parse(Console.ReadLine());

//if (number1 > number2 && number1 > number3)
//    Console.WriteLine($"{number1} is getter than {number2} & {number3}");
//else if (number2 > number1 && number2 > number3)
//    Console.WriteLine($"{number2} is getter than {number1} & {number3}");
//else
//    Console.WriteLine($"{number3} is getter than {number1} & {number2}");



////Assignment
//Console.Write("Please enter number 1: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.Write("Please enter number 2: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.Write("Please enter number 3: ");
//int number3 = int.Parse(Console.ReadLine());

//if (number1 < number2 && number1 < number3)
//    Console.WriteLine($"{number1} is smaller than {number2} & {number3}");
//else if (number2 < number1 && number2 < number3)
//    Console.WriteLine($"{number2} is smaller than {number1} & {number3}");
//else
//    Console.WriteLine($"{number3} is smaller than {number1} & {number2}");



//Assignment: Grade Calculation
int number;
string grade;

Console.Write("Please enter your number: ");
number = int.Parse(Console.ReadLine());

if(number >= 0 && number <= 100)
{
    if (number >= 90)
        grade = "A";
    else if (number >= 80)
        grade = "B";
    else if (number >= 70)
        grade = "C";
    else if (number >= 60)
        grade = "D";
    else
        grade = "F";

    Console.WriteLine($"Number is: {number} and Grade is: {grade}");
}
else
    Console.WriteLine("Invalid input.");






//Switch Case Condition

