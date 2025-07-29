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
Console.WriteLine($"\nTwo Dymentional Array:");
int[,] matrix = { {1, 2, 3}, {4, 5, 6} };

for(int row = 0; row < matrix.GetLength(0); row++)
{
    for(int collumn = 0; collumn < matrix.GetLength(1); collumn++)
    {
        Console.Write($"{matrix[row, collumn]} ");
    }
    Console.WriteLine();
}




//Jagged Array
Console.WriteLine($"\nJagged Array:");
int[][] jaggedArray = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6, 7, 8, 9 },
    new int[] { 10 }
};

for (int row = 0; row < jaggedArray.Length; row++)
{
    if (jaggedArray[row] != null)
    {
        for (int column = 0; column < jaggedArray[row].Length; column++)
        {
            Console.Write($"{jaggedArray[row][column]} ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();
foreach(var row in jaggedArray)
{
    foreach(var item in row)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}




//Array Property and methods
int[] numberArray = { 8, 9, 10, 1, 2, 5, -6, 7, 3, 4 };
Console.WriteLine();
Console.WriteLine($"Lenth of the numberArray: {numberArray.Length}");
Console.WriteLine($"Rank of the numberArray: {matrix.Rank}");
Console.WriteLine($"The Maximum value of the numberArray: {numberArray.Max()}");
Console.WriteLine($"The Minimum value of the numberArray: {numberArray.Min()}");
Console.WriteLine($"The Sum of the numberArray: {numberArray.Sum()}");
Console.WriteLine($"The Average of the numberArray: {numberArray.Average()}");
Console.WriteLine($"Before sorting: {numberArray.Average()}");

Console.Write("Before Sort: ");
PrintArray( numberArray );

Console.Write("After Sort: ");
Array.Sort( numberArray );
PrintArray(numberArray);

Console.Write("After Reversing: ");
Array.Reverse(numberArray);
PrintArray(numberArray);

int indexNo = Array.IndexOf(numberArray, -6);
Console.WriteLine($"Index of '-6' is: {indexNo}");

//Console.Write("Please enter a value tha you want to search: ");
//int findItem = int.Parse(Console.ReadLine());
int findItem = -6;
bool exixt = Array.Exists(numberArray,  value => value == findItem);
Console.WriteLine($"Does this array contain {findItem}? : {exixt}, and index number is: {Array.IndexOf(numberArray, findItem)}.");

int[] copyArray = new int[numberArray.Length];
Array.Copy(numberArray, copyArray, numberArray.Length);
Console.Write($"Copied Array is: ");
PrintArray(copyArray);

Array.Clear(copyArray, 0, copyArray.Length);
Console.Write("After clearing the copy array: ");
PrintArray(copyArray);


static void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}



//Params
static int Sum(params int[] numbers)
{
    int result = 0;
    foreach (int number in numbers)
    {
        result += number;
    }
    return result;
}


Console.WriteLine(Sum(1, 2, 3));
Console.WriteLine(Sum(1, 2, 3, 4));
Console.WriteLine(Sum(1, 2, 3, 4, 5));
Console.WriteLine(Sum(1, 2, 3, 4, 5, 6));
Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7));
Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8));
Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));











