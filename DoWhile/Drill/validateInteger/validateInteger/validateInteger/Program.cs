// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Validate Integer!***\n");



int? readInput;

bool isValidNumber = true;


do
{

    Console.WriteLine("Enter an Integer value between 5 and 10 ?\n");

        readInput = Convert.ToInt32(Console.ReadLine());

        //What if someone place an integer??????

      //  Convert.ToInt32(readInput);

    if (((readInput) >= 5) && ((readInput) <= 10))
    {
        Console.WriteLine("Your Input has been accepted!");
        isValidNumber = false;
    }
    else if ((readInput) < 5 || (readInput) < 10)
    {
        Console.WriteLine("Nope, Your Integer Value is not between 5 and 10. Try it a try");
    }

    //break;
    

} while (isValidNumber);