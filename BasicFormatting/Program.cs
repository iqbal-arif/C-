namespace BasicFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Combine strings using character escape sequences
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
        }
    }
}
