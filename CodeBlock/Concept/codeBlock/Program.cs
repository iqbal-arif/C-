// See https://aka.ms/new-console-template for more information
Console.WriteLine("Code Block!\n");
// Variable inside the BLOCK CODE
bool flag0 = true;


if (flag0)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

//Excessing the BLOCK CODE Variable

// Console.WriteLine($"Outside of code block: {value}");


// Intializing value

bool flagged = true;

// Value DECLARATION
int valued;

if (flagged)
{
    //Value INSTANTIATED
    valued = 10;
    Console.WriteLine("Inside of code block: " + valued);
}
// Console.WriteLine($"Outside of code block: {valued}");

//Including Initialzationa as part of Declaration

bool flag1 = true;
int value1 = 0;

if (flag1)
{
    value1 = 10;
    Console.WriteLine("Inside of code block: " + value1);
}
Console.WriteLine("Outside of code block: " + value1);

int valueOne =5;
if (valueOne>0)
{
    int valueTwo = 6;
    valueOne = valueOne + valueTwo;
}
Console.WriteLine(valueOne);
Console.WriteLine("\n\n\n");



//Exercise - Remove code blocks from if statements
Console.WriteLine("\nRemove code blocks from if statements\n");
/*
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
*/

bool flag = true;
if (flag)    Console.WriteLine(flag);
Console.WriteLine("\n\n");

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");