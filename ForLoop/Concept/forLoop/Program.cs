// See https://aka.ms/new-console-template for more information
Console.WriteLine("FOR iteration loops!\n");

// Listing nubmer 10 to 0

Console.WriteLine("Listing Number 10 to 0\n");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Iterator's Pattern\n");

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine("Break in Iteration\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


Console.WriteLine("Loop Through An Array\n");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


Console.WriteLine("\nLimition fo FOREACH Statement\n");

string[] names2 = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names2)
{
    // Can't do this:
    // if (name == "David") name = "Sammy";
}

Console.WriteLine("\nOvercoming the Limition fo FOREACH Statement\n");


string[] names3 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names3.Length; i++)
    if (names3[i] == "David") names3[i] = "Sammy";

foreach (var name in names3) Console.WriteLine(name);