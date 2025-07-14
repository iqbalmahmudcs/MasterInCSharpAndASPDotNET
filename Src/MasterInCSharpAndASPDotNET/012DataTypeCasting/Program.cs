char a = 'A';
int number = 10;
long longNumber = 101;
float floatNumber = 101.4F;
double doubleNumber = 102.5;
string stringValue = "10";

//implicit Type casting
number = a;
Console.WriteLine(number);

//Explicit Type Casting
number = 66;
a = (char)number;
Console.WriteLine(a);
a = Convert.ToChar(number);
Console.WriteLine(a);

number = Convert.ToInt32(doubleNumber);
Console.WriteLine(number);

bool isSuccess = int.TryParse(stringValue, out int output);
Console.WriteLine(output);




