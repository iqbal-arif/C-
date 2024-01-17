// See https://aka.ms/new-console-template for more information
Console.WriteLine("Code Readability Styling!\n");

/*
    To reverse a string and count the number of times a particular character appears
*/
/*
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
    { 
        if (i == 'o') { x++; } 
    }

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

/* Refactored Version */

string originalString = "The quick brown fox jumps over the lazy dog.";

char[] messageToArray = originalString.ToCharArray();

Array.Reverse(messageToArray);
int characterCount = 0;

foreach (char letter in messageToArray)
    { 
        if (letter == 'o')
        {   
            characterCount++;
        } 
    }

string newMessage = new String(messageToArray);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {characterCount} times.");

