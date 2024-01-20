// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boolean Expressions!\n");
//Equality Operator
Console.WriteLine("Equality Operator Excersise\n");
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
//Turns False because of space character
Console.WriteLine("a" == "a ");

string value1 = " a";
string value2 = "A ";
Console.WriteLine("\n",value1.Trim().ToLower() == value2.Trim().ToLower());


//InEquality Operator
Console.WriteLine("Equality Operator Excersise\n");

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");


//Comparison Operator

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// Method that Retursn Boolean Sting Data Type
// Contains, StartWith, EndsWith

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow\n"));


//Logical Negation

// These two lines of code will create the same output
Console.WriteLine("\n");
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

//Conditional Operator

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

