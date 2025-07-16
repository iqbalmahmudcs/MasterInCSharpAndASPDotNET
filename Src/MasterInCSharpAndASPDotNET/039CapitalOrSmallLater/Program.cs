char letter;

Console.Write("Please enter a leter: ");
letter = char.Parse(Console.ReadLine());

if (char.IsLetter(letter))
{
    if (letter >= 'A' && letter <= 'Z')
        Console.WriteLine($"'{letter}' is a capital letter.");
    else
        Console.WriteLine($"'{letter}' is a small letter.");
}
else if (char.IsDigit(letter))
    Console.WriteLine($"'{letter}' is a number.");
else
    Console.WriteLine($"'{letter}' is a special charecter.");




