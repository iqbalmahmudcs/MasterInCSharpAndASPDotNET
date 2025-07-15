int number = 79;

string result = number >= 80 ? "A+" : "A-";
Console.WriteLine(result);

int number1 = 10;
int number2 = 20;

string largeNumber = number1 > number2 ? number1.ToString() : number2.ToString();
Console.WriteLine(largeNumber);

int smallNumber = number1 < number2 ? number1 : number2;
Console.WriteLine(smallNumber);