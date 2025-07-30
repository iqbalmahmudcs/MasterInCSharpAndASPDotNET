//Sorting OrderBy

using _084LINQOrderByAndThenBy;

int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

Console.Write("\nOriginal numbers: ");
PrintArray(numbers);

var asendingNumbers = numbers.OrderBy(number => number).ToArray();
Console.Write($"\nAscending numbers: ");
PrintArray(asendingNumbers);

var descendingNumbers = numbers.OrderDescending().ToArray();
Console.Write($"\nDescending numbers: ");
PrintArray(descendingNumbers);


static void PrintArray(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

//Sorting: OrderBy for object property
Console.WriteLine();

List<Person> people = new List<Person>
{
    new Person {Name= "Iqbal", Age = 26},
    new Person {Name= "Mim", Age = 25},
    new Person {Name= "Abdur Rahman", Age = 2},
    new Person {Name= "Abdullah", Age = 17},
    new Person {Name= "Abdullah", Age = 25},
};

var sortedPeopleByAge = people.OrderBy(people => people.Age);

Console.WriteLine("\nPersons are: ");
foreach (var person in sortedPeopleByAge)
{
    Console.WriteLine($"{person.Name}: {person.Age}");
}
Console.WriteLine();


//Sorting with ThenBy(Secondery Sorting)

var sortedPeopleByAgeThenByName = people.OrderBy(people => people.Age).ThenBy(people => people.Name);

Console.WriteLine("\nPersons are: ");
foreach (var person in sortedPeopleByAgeThenByName)
{
    Console.WriteLine($"{person.Name}: {person.Age}");
}
Console.WriteLine();



//Quantifiers: All, Any, Contains

bool areAllAdults = people.All(people => people.Age >= 18);
Console.WriteLine($"Are all people adults? {areAllAdults}");

bool isThereAnyTeenager = people.Any(people => people.Age < 18);
Console.WriteLine($"Is there any teneger? {isThereAnyTeenager}");

bool isContainsMim = people.Select(people => people.Name).Contains("Mim");
Console.WriteLine($"Is there contains 'Mim'? {isContainsMim}");














