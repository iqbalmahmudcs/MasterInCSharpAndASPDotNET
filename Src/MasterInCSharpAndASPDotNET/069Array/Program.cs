string[] names = { "Iqbal", "Abdullah", "Abdur Rahman"};
int[] ages = { 26, 20, 2 };


//Console.WriteLine("For Loop\n========");
//for (int i = 0; i < names.Length; i++)
//    Console.WriteLine($"Name({i}) = {names[i]}");


//Console.WriteLine("\nFor Each Loop=============");
Console.WriteLine("\nNames=====");
int index = 0;
foreach (string name in names)
{
    Console.WriteLine($"Name({index}) = {name}");
    index++;
}

Console.WriteLine("\nAges====");
index = 0;
foreach(int age in ages)
{
    Console.WriteLine($"Age({index}) = {age}");
    index++;
}


Console.WriteLine();
int[] numbers = { 1, 2, 3, 4, 5, -6, 7, 8, 9, 10};
int sum = 0;
foreach (int number in numbers)
{
    if (number > 0)
    {
        Console.WriteLine(number);
        sum += number;
    }
}
Console.WriteLine($"Sum = {sum}");





//Two Dymentional Array
Console.WriteLine($"\n");
int[,] matrix = { {1, 2, 3}, {4, 5, 6} };

for(int row = 0; row < matrix.GetLength(0); row++)
{
    for(int collumn = 0; collumn < matrix.GetLength(1); collumn++)
    {
        Console.Write($"{matrix[row, collumn]} ");
    }
    Console.WriteLine();
}








