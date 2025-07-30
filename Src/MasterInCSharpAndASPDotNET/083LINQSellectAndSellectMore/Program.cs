//Projection with select and sellect many operator

using _083LINQSellectAndSellectMore;

int[] numbers = {1, 2, 3, 4, 5, 6, 7};

var squareNumber = numbers.Select(number => number * number);
Console.Write("\nThe square numbers are: ");
foreach (var number in squareNumber)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


//Selecting properties from objects.
List<Person> people = new List<Person>
{
    new Person{Name = "Iqbal", Age = 26, BloodGroup = "B +ve"},
    new Person{Name = "Mim", Age = 25, BloodGroup = "B +ve"},
    new Person{Name = "Abdur Rahman", Age = 2, BloodGroup = "AB +ve"},
    new Person{Name = "Abdullah", Age = 20, BloodGroup = "A +ve"}
};

var person = people.Select(person => (person.Name , person.BloodGroup));
Console.Write($"\nPerson Name: ");
foreach(var item in person)
{
    Console.Write($"{item.Name}: {item.BloodGroup}, ");
}
Console.WriteLine();



Console.WriteLine();
//Nested List
List<List<int>> nestedList = new List<List<int>>
{
    new List<int> {1, 2, 3}, 
    new List<int> {4, 5}, 
    new List<int> {6, 7, 8}, 
    new List<int> {9} 
};

var flattenList = nestedList.SelectMany(nestedList => nestedList);
Console.Write($"List items are: ");
foreach(var item in flattenList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();










