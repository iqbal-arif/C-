// See https://aka.ms/new-console-template for more information
Console.WriteLine("Do While Loop!\n");
/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine($"Inside Block {current}");
} while (current != 7);
    Console.WriteLine($"DoWhile Block {current}");

*/
Console.WriteLine("\nWhile Loop!\n");
Random randomDo = new Random();
// int currentDo = randomDo.Next(1, 11);
int currentDo = 0;

while (currentDo >= 3)
{
    Console.WriteLine($"Inside Block {currentDo}");
    currentDo = randomDo.Next(1, 20);
} 
    Console.WriteLine($"While Block {currentDo}\n");


Console.WriteLine("\nWhile Loop with Continue Statement!\n");

Random randomCount = new Random();
int currentCount = randomCount.Next(1, 12);

Console.WriteLine($"\nOuter Random No. : {currentCount}\n");
do
{
Console.WriteLine($"\nInner Random No. : {currentCount}\n");
    currentCount = randomCount.Next(1, 20);
Console.WriteLine($"\nNew Inner Random No. : {currentCount}\n");

    if (currentCount >= 8) continue;

    Console.WriteLine($"While Block with Continue Statement : {currentCount}");
    Console.WriteLine();
} while (currentCount != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/