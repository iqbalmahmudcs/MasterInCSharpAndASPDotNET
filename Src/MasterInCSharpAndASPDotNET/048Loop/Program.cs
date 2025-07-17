////For, while, do-while

//Console.Write("Please enter the starting number: ");
//int startingNumber = int.Parse(Console.ReadLine());

//Console.Write("Please enter the ending number: ");
//int endingNumber = int.Parse(Console.ReadLine());

//Console.Write("Please enter the difference number: ");
//int differenceNumber = int.Parse(Console.ReadLine());

//for (int count = startingNumber; count <= endingNumber; count += differenceNumber)
//{
//    if(count % 2 ==0)
//        Console.WriteLine($"{count}");
//}


////sum of 1-10 number
//int sumOfNumber = 0;
//for (int count = 1; count <= 10; count++)
//{
//    sumOfNumber += count;
//    Console.WriteLine($"Sum of numbers between 1 to 10: {sumOfNumber}");
//}
//Console.WriteLine(sumOfNumber);



////sum of even nuber of 1-10
//int sumOfEvenNumber = 0;

//for (int i = 1; i <= 10; i++)
//{
//    if(i % 2 == 0)
//        sumOfEvenNumber += i;
//}
//Console.WriteLine($"Sum of even numbers between 1 to 10 is: {sumOfEvenNumber}");



////sum of odd number between 1-10
//int sumOfOddNumber = 0;
//for (int i = 1; i <= 10; i++)
//{
//    if(i % 2 != 0)
//    sumOfOddNumber += i;
//}
//Console.WriteLine($"Sum of odd numbers between 1 to 10 is: {sumOfOddNumber}");



//Factorial number calculation
int number, factorialNumber = 1;
Console.Write("Please enter a number which you want to get factorial: ");
number = int.Parse(Console.ReadLine());

for (int i = number; i >= 1; i--)
{
    factorialNumber *= i;
}
Console.WriteLine($"The factorial of {number} is: {factorialNumber}");







