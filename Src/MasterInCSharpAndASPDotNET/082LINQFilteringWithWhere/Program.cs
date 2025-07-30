using _082LINQFilteringWithWhere;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(num => num % 2 == 0);
Console.Write($"\nEven numbers count: {evenNumbers.Count()}, and numbers are: ");
if ( evenNumbers.Any())
{
    foreach (var item in evenNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
else
    Console.WriteLine("No Even Number Found!");


List<string> words = new List<string> { "Iqbal", "Hassan", "Mahmud", "Sonia", "Khatun", "Mim", "Abdur", "Rahman", "Abdullah", "Al", "Mahmud" };

var longWords = words.Where(words => words.Length > 6);
Console.Write($"\nLong words count: {longWords.Count()}, and words are: ");
foreach (var item in longWords)
{
    Console.Write($"{item} ");
}
Console.WriteLine();



//Student Class
Console.WriteLine();

List<Student> students = new List<Student>()
{
    new Student{Name = "Iqbal", Score = 75},
    new Student{Name = "Hassan", Score = 80},
    new Student{Name = "Mahmud", Score = 90},
    new Student{Name = "Sonia", Score = 95},
    new Student{Name = "Khatun", Score = 65},
    new Student{Name = "Mim", Score = 80},
    new Student{Name = "Abdur Rahman", Score = 70},
    new Student{Name = "Abdullah", Score = 75}
};

var scoreMoreThan79 = students.Where(student => student.Score > 79);
Console.WriteLine($"The total count of more than 79 score is: {scoreMoreThan79.Count()}, and they are: ");

if (scoreMoreThan79.Any())
{
    foreach (var student in scoreMoreThan79)
    {
        Console.WriteLine($"{student.Name} = {student.Score}, ");
    }
    Console.WriteLine();
}
else
    Console.WriteLine("Students more than 79 score is not available.");








