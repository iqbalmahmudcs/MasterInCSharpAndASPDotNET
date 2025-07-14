string? studentName;
int? age;
double? gpa;
bool? isRegisterd;

Console.Write("Please Enter Student Name: ");
studentName = Console.ReadLine();

Console.Write("Please Enter Student Age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Please Enter Student GPA: ");
gpa = double.Parse(Console.ReadLine());

Console.Write("Are you complete your registation?: ");
isRegisterd = bool.Parse(Console.ReadLine());

Console.WriteLine($"\nWelcome, {studentName}.");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"GPA: {gpa}");
Console.WriteLine($"Registration Status: {isRegisterd}");



