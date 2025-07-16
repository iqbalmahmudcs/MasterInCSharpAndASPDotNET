//Switch, Case, Break, default.


//int digit;

//Console.Write("Please enter a number(0-9): ");
//digit = int.Parse(Console.ReadLine());

//switch (digit)
//{
//    case 0: Console.WriteLine("Zero"); break;
//    case 1: Console.WriteLine("One"); break;
//    case 2: Console.WriteLine("Two"); break;
//    case 3: Console.WriteLine("Three"); break;
//    case 4: Console.WriteLine("Four"); break;
//    case 5: Console.WriteLine("Five"); break;
//    case 6: Console.WriteLine("Six"); break;
//    case 7: Console.WriteLine("Seven"); break;
//    case 8: Console.WriteLine("Eight"); break;
//    case 9: Console.WriteLine("Nine"); break;
//    default: Console.WriteLine("Invalid Input!"); break;
//}


////MULTIPLE CASE
//char charecter;
//Console.Write("Please enter a charecter: ");
//charecter = char.Parse(Console.ReadLine().ToUpper());

//switch (charecter)
//{
//    case 'A':
//    case 'E':
//    case 'I':
//    case 'O':
//    case 'U':
//        Console.WriteLine($"{charecter} is a vowel.");
//        break;
//    default:
//        if (char.IsLetter(charecter))
//            Console.WriteLine($"{charecter} is consonant.");
//        else
//            Console.WriteLine($"{charecter} is not a letter.");
//        break;
//}



////Assignmet: 10
//string day;

//Console.Write("Please enter a day: ");
//day = Console.ReadLine().ToLower();

//switch (day)
//{
//    case "sunday":
//    case "monday":
//    case "twesday":
//    case "wednesday":
//    case "thursday":
//        Console.WriteLine($"{day.ToUpper()} is weekday.");
//        break;
//    case "friday":
//    case "saturday":
//        Console.WriteLine($"{day.ToUpper()} is weekend.");
//        break;
//    default:
//        Console.WriteLine("Invalid Input. Valid inputs are: saturday, sunday, monday, twesday, wednesday, thursday, and friday");
//        break;
//}




////Assignmet: 10
//string day;

//while (true)
//{
//    Console.Write("Please enter a day: ");
//    day = Console.ReadLine().ToLower();

//    string output = day switch
//    {
//        "friday" => $"{day.ToUpper()} is weekend.",
//        "saturday" => $"{day.ToUpper()} is weekend.",
//        "sunday" => $"{day.ToUpper()} is weekday.",
//        "monday" => $"{day.ToUpper()} is weekday.",
//        "twesday" => $"{day.ToUpper()} is weekday.",
//        "wednesday" => $"{day.ToUpper()} is weekday.",
//        "thursday" => $"{day.ToUpper()} is weekday.",
//        _ => $"{day.ToUpper()} is not a valid day."
//    };
//    Console.WriteLine(output);
//}



//object input = "10";

//string result = input switch
//{
//    int => $"{input} is integer",
//    long => $"{input} is long",
//    float => $"{input} is float",
//    double => $"{input} is double",
//    string => $"{input} is string",
//    _ => $"{input} is unknown"
//};
//Console.WriteLine(result);




using System.Threading.Channels;

Console.Write("Please enter a number between 1 to 10: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    string result = number switch
    {
        int num when num > 0 && num < 11 => num % 2 == 0 ? $"{number} is even" : $"{number} is Odd",
        _ => $"Out of range"
    };
    Console.WriteLine(result);
}
else
    Console.WriteLine("Invalid inpur, please enter a valid number.");





