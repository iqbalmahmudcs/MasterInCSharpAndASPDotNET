int year;

Console.Write("Please enter a year: ");
year = int.Parse(Console.ReadLine());

if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
    Console.WriteLine($"{year} is a leap year.");
else
    Console.WriteLine($"{year} is not a leap year.");


