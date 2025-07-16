char letter;

Console.Write("Please enter a leter: ");
letter = char.Parse(Console.ReadLine());

if (char.IsLetter(letter))
{
    letter = char.ToUpper(letter);
    if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
        Console.WriteLine($"'{letter}' is a vowel letter.");
    else
        Console.WriteLine($"{letter} is a consonant letter.");

}
else if (char.IsDigit(letter))
    Console.WriteLine($"'{letter}' is a number.");
else
    Console.WriteLine($"'{letter}' is a special charecter.");





