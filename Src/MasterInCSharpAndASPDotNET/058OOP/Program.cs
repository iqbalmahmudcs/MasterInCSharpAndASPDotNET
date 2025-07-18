using _058OOP;

Person p1 = new Person("Iqbal", 26);
p1.DisplayInfo();

Console.WriteLine();
Person p2 = new Person("Mim", 25);
p2.DisplayInfo();

//Reference Type
Console.WriteLine();
Person p3 = p1;
p3.DisplayInfo();

p3._name = "zzz";
p3._age = 15;
p3.DisplayInfo();
p1.DisplayInfo();    // value changed


Console.WriteLine();
Fruits f1 = new Fruits("Mango", "Green");
f1.DisplayInfo();


Console.WriteLine();
Fruits f2 = new Fruits();
f2.DisplayInfo();

//value type
int x = 30;
int y = x;
y = 20;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(x);     //value is not changed



//Student
Console.WriteLine();
Student s1 = new Student(30);
Console.WriteLine(s1._age);












