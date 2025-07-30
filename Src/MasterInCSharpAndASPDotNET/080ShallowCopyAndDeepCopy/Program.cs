//Shallow Copy
Console.WriteLine($"\nShallow Copy\n============");

int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.Write($"\nOriginal Array-1 Before modification: ");
PrintArray( array1 );


int[] shallowCopyArray = array1;
Console.Write($"\nShalow Copy Array Before modification: ");
PrintArray( shallowCopyArray );

shallowCopyArray[0] = 10;

Console.Write($"\nOriginal Array-1 After modification: ");
PrintArray(array1);

Console.Write($"\nShalow Copy Array After modification: ");
PrintArray(shallowCopyArray);


//Deep Copy
Console.WriteLine($"\nDeep Copy\n=========");

int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


Console.Write($"\nOriginal Array-2 Before modification: ");
PrintArray(array2);


int[] deepCopyArray = new int[array2.Length];
Array.Copy(array2, deepCopyArray, array2.Length);

Console.Write($"\nDeep Copy Array Before modification: ");
PrintArray(deepCopyArray);

deepCopyArray[0] = 10;

Console.Write($"\nOriginal Array-2 After modification: ");
PrintArray(array2);

Console.Write($"\nDeep Copy Array After modification: ");
PrintArray(deepCopyArray);

static void PrintArray(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}





