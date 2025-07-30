int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2 };
int sum = numbers.Sum();
int max = numbers.Max();
int min = numbers.Min();
int count = numbers.Count();
double average = numbers.Average();


Console.Write("\nOriginal numbers: ");
PrintArray(numbers);
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Maximum: {max}");
Console.WriteLine($"Minimum: {min}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Count: {count}");



static void PrintArray(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}