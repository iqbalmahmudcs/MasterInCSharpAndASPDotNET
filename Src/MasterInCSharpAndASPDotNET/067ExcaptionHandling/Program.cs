using System.Runtime.CompilerServices;

try
{
    int number1 = IntegerInput("number1");
    int number2 = IntegerInput("number2");

    if(number2 < 0 || number2 > 1000)
    {
        throw new ArgumentException("Number 2 can't be greater than 1000");
    }

    int results = number1 / number2;
    Console.WriteLine($"{number1} / {number2} = {results}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e);
}
catch (Exception e)
{
    Console.WriteLine($"An error occured. {e}");
}
finally
{
    Console.WriteLine("Good bye!");
}


static int IntegerInput(string prompt)
{
    while (true)
    { 
        Console.Write($"Enter {prompt}: ");
        string input = Console.ReadLine() ?? "";
        if (!int.TryParse(input, out int result) || string.IsNullOrEmpty(input))
        {
            Console.WriteLine($"Invalid Input! Please enter a valid integer.");
            continue;
        }

        return result;

    }
}