// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rolling Dice Game - IF Statement\n");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("\nYou rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("\nYou rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("\nYou win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("\nYou win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("\nYou win a trip for two!");
}
else
{
    Console.WriteLine("\nYou win a kitten!");
}
