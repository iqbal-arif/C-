// See https://aka.ms/new-console-template for more information
Console.WriteLine("Complete a challenge activity using for and if statements!\n");

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);

    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - Fizz Buzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else 
        Console.WriteLine($"{i}");
}