while (true)
{
    Console.WriteLine("Simple Calculator System");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Chose 1. for summation,");
    Console.WriteLine("Chose 2. for subtruction,");
    Console.WriteLine("Chose 3. for multiplication,");
    Console.WriteLine("Chose 4. for dividation, and");
    Console.WriteLine("Chose 5. for modulation.");
    Console.Write("Please enter your choice: ");

    int number1, number2, choise;

    if (int.TryParse(Console.ReadLine(), out choise) && choise > 0 && choise < 6)
    {
        Console.Write("Please enter two integer number by presing enter: ");
        if (int.TryParse(Console.ReadLine(), out number1) && int.TryParse(Console.ReadLine(), out number2))
        {
            string result = choise switch
            {
                1 => $"{number1} + {number2} = {number1 + number2}",
                2 => $"{number1} - {number2} = {number1 - number2}",
                3 => $"{number1} * {number2} = {number1 * number2}",
                4 => $"{number1} / {number2} = {number1 / number2}",
                _ => $"{number1} % {number2} = {number1 % number2}",
            };
            Console.WriteLine(result);
        }
        else
            Console.WriteLine("Invalid input. This system only allowed integer number.");
    }
    else
        Console.WriteLine("Invalid choice. Please enter a valid choice(1-5): ");
    Console.Write("For exit press 'Q': ");
    char exit = char.Parse(Console.ReadLine().ToUpper());
    if(exit == 'Q')
        break;

        
}