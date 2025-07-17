int i = 1;
while (i <= 100)
{
    if (i == 10)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
    if (i == 50)
        break;
}
