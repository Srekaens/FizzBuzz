string fizz = "Fizz";
string buzz = "Buzz";

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write($"{i} :");
        Console.Write(fizz);
        Console.WriteLine(buzz);
    }
    else if (i % 3 == 0)
    {
        Console.Write($"{i} :");
        Console.WriteLine(fizz);
    }
    else if (i % 5 == 0)
    {
        Console.Write($"{i} :");
        Console.WriteLine(buzz);
    }
    else
    {
        Console.WriteLine($"{i} : Ce nombre n'est pas divisible ni par 3 ni par 5");
    }

}
