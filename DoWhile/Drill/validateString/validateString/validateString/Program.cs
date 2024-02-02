// See https://aka.ms/new-console-template for more information

Console.WriteLine("Validate String!\n");

string readInput;

bool isValidString = true;


do
{
    Console.WriteLine("Enter one of three role names: Administrator, Manager, or User\n");

    readInput = Console.ReadLine().Trim().ToLower();
    Console.WriteLine(readInput);

    switch (readInput)
    {
        case "administrator":
        case "manager":
        case "user":
            Console.WriteLine("Thank you for your input. It has been accepted!\n");
            isValidString = false;
            break;
        default:
            Console.WriteLine("Please Choose from the given user roles");
            break;
    }



} while (isValidString);