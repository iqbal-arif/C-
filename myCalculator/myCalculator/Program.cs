namespace myCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My Calculator");
            Console.WriteLine("Enter the first number");
            double firstNubmer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double secondNubmer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pick the operator from the following: + - * /");
            string calOperator = (Console.ReadLine());

            double calResult = 0;

            if (calOperator == "+")
            {
                calResult = firstNubmer = secondNubmer;
            } else if (calOperator == "-")
            {
                calResult = firstNubmer - secondNubmer;
            }else if (calOperator == "*")
            {
                calResult = firstNubmer * secondNubmer;
            }else if (calOperator == "/")
            {
                calResult = firstNubmer / secondNubmer;
            }

            Console.WriteLine($"Result is {calResult}");

            Console.WriteLine(34.40M);

            Console.ReadLine();
        }
    }
}
