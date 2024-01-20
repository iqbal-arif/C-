// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditional Operator!\n");

Random randomNumber = new Random();
int percentDice = randomNumber.Next(1,50);

string diceResult = percentDice > 25 ? "heads" : "tails";
Console.WriteLine($"The Dice Result is {percentDice} :  {diceResult}\n");


// int daysUntilExpiration = random.Next(12);

string permission = "Admin|Manager";
int adminLevel = 55;
int managerLevel = 20;
// int userLevel;

Random random = new Random();
int userLevel = random.Next(100);


// Business Rules

/* 1. If the user is an Admin with a level greater than 55, output the message:
Output

Welcome, Super Admin user.

*/

Console.WriteLine($"User Admin : {userLevel}");
Console.WriteLine(permission.Contains("Admin") && userLevel > adminLevel ?  "Welcome, Super Admin user" : "Welcome, Admin user.");


Console.WriteLine($"\nUser Manager : {userLevel}");
Console.WriteLine(permission.Contains("Manager") && userLevel > managerLevel ?  "Contact an Admin for access." : "You do not have sufficient privileges.");


Console.WriteLine($"\nUser : {userLevel}");
if ((permission != "Admin") || (permission != "Manager")) Console.WriteLine("You do not have sufficient privileges.");