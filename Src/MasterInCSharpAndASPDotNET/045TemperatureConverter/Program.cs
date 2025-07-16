Console.WriteLine("Temperature Converter System");
Console.WriteLine("-----------------------------");
Console.WriteLine("Chose 1. Celcius to Fahrenheight");
Console.WriteLine("Chose 2. Celcius to Kelvin");
Console.WriteLine("Chose 3. Fahrenheight to Celcius");
Console.WriteLine("Chose 4. Fahrenheight to Kelvin");
Console.WriteLine("Chose 5. Kelvin to Celcius");
Console.WriteLine("Chose 6. Kelvin to Fahrenheight");
Console.Write("Please enter your choise: ");
int choise;
if (int.TryParse(Console.ReadLine(), out choise) && choise > 0 && choise < 7){
    double input;
    Console.Write("Please enter a temperature: ");
    if (double.TryParse(Console.ReadLine(), out input))
    {
        double result = choise switch
        {
            1 => ((input * (9.0 / 5.0)) + 32.0),
            2 => input + 273.15,
            3 => ((5.0 / 9.0) * (input - 32.0)),
            4 => (input - 32.0) * (5.0/9.0) + 273.15,
            5 => input -  273.15,
            6 => (input -  273.15) * (9.0 / 5.0) + 32.0
        };
        Console.WriteLine(result.ToString("F2"));
    }
    else
        Console.WriteLine($"{input} is invalid input. Only digit is allowed.");

}
else
    Console.WriteLine($"{choise} is invalid input. The valid input is between 1 to 6. Please try again. Thanks.");

