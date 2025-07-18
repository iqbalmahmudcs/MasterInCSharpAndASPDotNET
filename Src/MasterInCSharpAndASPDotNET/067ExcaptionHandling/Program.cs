using System.Runtime.CompilerServices;

try
{

    Console.Write("Enter a number: ");
    string input = Console.ReadLine() ?? "";
    if (string.IsNullOrEmpty(input))
    {
        throw new ArgumentNullException("Number 1 can't be null or empty: ");
    }
    int number1 = int.Parse(input);


    Console.Write("Enter another number: ");
    input = Console.ReadLine() ?? "";
    if (string.IsNullOrEmpty(input))
    {
        throw new ArgumentNullException("Number 2 can't be null or empty: ");
    }
    int number2 = int.Parse(input);

    if(number2 < 0 || number2 > 1000)
    {
        throw new ArgumentException("Number 2 can't be greater than 1000");
    }

    int results = number1 / number2;
    Console.WriteLine($"{number1} / {number2} = {results}");
}
catch(OverflowException ){
    Console.WriteLine($"The number was too big or small. Please enter a valid number.");
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch (FormatException)
{
    Console.WriteLine($"Invalid input. Please enter a valid number.");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"Error. Can't divide by zero.");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"An error occured. {e}");
}
finally
{
    Console.WriteLine("Good bye!");
}