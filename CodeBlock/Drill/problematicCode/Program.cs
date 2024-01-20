// See https://aka.ms/new-console-template for more information
Console.WriteLine("Complete a challenge activity using variable scope!\n");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
    bool found = true;

if (found) 
    Console.WriteLine("Set contains 42");

foreach (int number in numbers)
{
    int total = 0;
    total += number;

    if (number == 42)
        Console.WriteLine($"Total: {total}");

}

