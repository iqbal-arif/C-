namespace BasicFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Combine strings using character escape sequences***/
            //1. Format literal strings in C#
            //Character escape sequences

            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");

            //characters after the second double-quotation mark
            Console.WriteLine("Hello \"World\"!");

            //backslash for other purposes, like to display a file path
            Console.WriteLine("c:\\source\\repos");

            //Format output using character escape sequences
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");

            //Verbatim string literal
            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");

            //Format output using unicode escape characters
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            //***Combine strings using string concatenation***/
            //1. Concatenate a literal string and a variable
            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);

            //2. Concatenate multiple variables and literal strings
            string firstName2 = "Bob";
            string greeting = "Hello";
            string message2 = greeting + " " + firstName2 + "!";
            Console.WriteLine(message2);

            //3. Avoiding intermediate variables
            string firstName3 = "Bob";
            string greeting3 = "Hello";
            Console.WriteLine(greeting3 + " " + firstName3 + "!");


            //*** Combine strings using string interpolation***/
            //1. Use string interpolation to combine a literal string and a variable value
            string firstName4 = "Bob";
            string message4 = $"Hello {firstName4}!";
            Console.WriteLine(message4);
            //2. Use string interpolation with multiple variables and literal strings
            int version = 11;
            string updateText = "Update to Windows";
            string message5 = $"{updateText} {version}";
            Console.WriteLine(message5);
            //3. Avoid intermediate variables 
            int version2 = 11;
            string updateText3 = "Update to Windows";
            Console.WriteLine($"{updateText3} {version2}!");

            //4. Combine verbatim literals and string interpolation
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            //
            string projectName2 = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName2}\\data.txt");

            Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName2}\\data.txt");

            Console.WriteLine(@"\");

        }
    }
}
