Console.Write("Please enter a starting number: ");
int startNumber = int.Parse(Console.ReadLine());
Console.Write("Please enter a ending number: ");
int endNumber = int.Parse(Console.ReadLine());

for (int i = startNumber; i <= endNumber; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}



