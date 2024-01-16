// See https://aka.ms/new-console-template for more information
Console.WriteLine("Renewal Rate of Subscription\n");

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Business Logic :- Subscription Rules


//Subscription Notice
Console.WriteLine(daysUntilExpiration);


if (daysUntilExpiration == 0)
{
    Console.WriteLine("\nYour subscription has expired.\n");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("\nYour subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("\nYour subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"\nRenew now and save {discountPercentage}%.");
}

