using _068Project4StudentManagementSystem;

try
{
    Student s1 = new Student("Iqbal Hassan Mahmud", new DateTime(1998, 04, 26), "SWE101");
    Student s2 = new Student("Abdullah Al Mahmud", new DateTime(2004, 04, 20), "SWE102");

    s1.DisplayInformation();
    s2.DisplayInformation();
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally{
    Console.WriteLine("");
}