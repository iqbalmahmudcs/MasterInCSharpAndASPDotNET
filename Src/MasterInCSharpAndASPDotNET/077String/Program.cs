string text = "  Hello everyone! This is Iqbal Hassan Mahmud.  ";

Console.WriteLine($"String: {text}");

Console.WriteLine($"String Lenht is: {text.Length}");
Console.WriteLine($"The element of '0' index is: {text[0]}");
Console.WriteLine($"Is this string Null or Empty?: {string.IsNullOrEmpty(text)}");

text = text.Trim();
Console.WriteLine($"Trim String: {text}");

text = text.Insert(0, "Hi! ");
Console.WriteLine($"Inserted String: {text}");

Console.WriteLine($"Upper Case: {text.ToUpper()}");
Console.WriteLine($"Lower Case: {text.ToLower()}");
Console.WriteLine($"Substring: {text.Substring(6)}");
Console.WriteLine($"Substring: {text.Substring(6 , 5)}");

text = text.Remove(0, 4);
Console.WriteLine($"After removing: {text}");

text = text.Replace("Hello everyone", "Hi");
Console.WriteLine($"After Replacing: {text}");

Console.WriteLine($"Is 'Iqbal' exists?: {text.Contains("Iqbal")}");

string reverseText = new string(text.Reverse().ToArray());
Console.WriteLine($"Reversed String: {reverseText}");

var words = text.Split(" ");
Console.WriteLine("\nSplited words are: ");
foreach (var word in words)
{
    Console.WriteLine(word);
}
string newString = string.Join(" ", words);
Console.WriteLine($"New String is: {newString}");




