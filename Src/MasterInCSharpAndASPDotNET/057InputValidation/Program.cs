using System.Threading.Channels;

while (true)
{
    Console.Write("Please enter a number between 1 to 10 or write 'exit' to exit the app: ");
    string input = Console.ReadLine().ToLower() ?? "";

    if (input == "exit")
    {
        Console.WriteLine("Thanks for using this app. Good bye!");
        break;
    }
    
    input = input.Trim();
    
    if(!int.TryParse(input, out int number))
    {
        Console.WriteLine("Enter a valid input");
        continue;
    }
    else if (int.TryParse(input, out number))
    {
        if (number > 0 && number < 11)
        {
            int square = number * number;
            Console.WriteLine($"The square of {number} = {square}");
        }
        else
        {
            Console.WriteLine("Not a valid Range, valid range is 1-10.");
            continue;
        }
    }
}