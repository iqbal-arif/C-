// See https://aka.ms/new-console-template for more information
Console.WriteLine("String Array!\n");

/*
 * 
 *I like pizza
 *I like roast chicken
 *I like salad
 *I like all three of the menu choices
 * 
 */

/*
 * Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

    Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

    In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

    Your solution must include an inner do-while or while loop that can be used to process the myString variable.

    In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

    In the inner loop, your solution must not display the period character.

    In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

 * 
 * 
 * 
 * 
 */

int periodLocation;
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices. " };



foreach (string mystring in myStrings)
{
    int startIndex = 0;
    string newString = mystring;
    //Trim() / Remve()
        do { 
        
            periodLocation = newString.IndexOf('.');

            if (periodLocation >= 0)
                {
                     string firstMystring = newString.Substring(startIndex, periodLocation - startIndex );
                     Console.WriteLine(firstMystring);
                     startIndex = periodLocation;
            Console.WriteLine(startIndex);
            newString = newString.Substring(startIndex).Remove(0,1).Trim();
                     startIndex = 0;
                }
            else if (!string.IsNullOrWhiteSpace(newString))
        {
            Console.WriteLine(newString);
        }


        } while (periodLocation >= 0 );



}
