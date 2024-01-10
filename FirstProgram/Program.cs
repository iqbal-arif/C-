namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Console.ReadLine();
            //string helloWorld = "Hello, World defind as variable";
            /*
             * Data Types
             * String : any type of string ""
             * Integer : number
             * float : only 7 digit are allowed
             * double : 16 digits (used as default)
             * decimal : 28 digits
             * boolean: true or false
             * char : any character ' '
             * 
             */
            string firstName = "Arif";
            string lastName = "Iqbal";
            int age = 47;
            int weight = 180;
            //float height1 = 5.5f;
            double height = 5.6;
            //decimal height2 = 5.7m;
            bool isFirstEdition = true;
            char grade = 'A';


            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(height);
            Console.WriteLine(isFirstEdition);
            Console.WriteLine(grade);
        }                 
    }
}
