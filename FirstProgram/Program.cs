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

            //Subtring Extraction
            string name = "The C# and Dot.net Tutorial";
            // Substring(11, 3) initial value is states the start of the string
            // Second value is the number of character
            string Dot = name.Substring(11, 3);
            Console.WriteLine(Dot);

            // String Replace /and Length of String /and  String IndexOf
            string spongeName = "Spongebob Squarepants Spongebob Spongebob Spongebob";
            string pat = spongeName.Replace("Spongebob", "Patrick");
            //String Length
            Console.WriteLine(spongeName.Length);
            Console.WriteLine(pat);
            //IndexOf
            string pat2 = "This is IndexOf Patrick";
            int patIndex = pat2.IndexOf("trick");
            Console.WriteLine(patIndex);
            //Arthematic
            int result = 0;
            // Order of Calculation (Power of Operation)
            // BIDMAS-BODMAS (Pranthesis, Power of , Division, Multiplication, Addition, Subtraction
            result = 5 * 4 - 2 / 7 + (5 + 1);
            Console.WriteLine(result);
            //Power of 
            double result2 = 0;
            result2 = Math.Pow(2, 7);
            Console.WriteLine(result2);

            //Interactive 
            Console.WriteLine("What is your name?");

            string inputString = Console.ReadLine();
            Console.WriteLine($"Hello {inputString} !");

            //Calculator / Convert the input into integer
            Console.WriteLine("Welcome to our number multipler");
            Console.WriteLine("What is your first number?");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your second number?");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int numberMultiply = firstNumber * secondNumber;
            Console.WriteLine($"The result is {numberMultiply}");

            // Running Multiple Method
            HelloInteractive();

            // User Info Method
            Console.WriteLine("What is USER name?");

            string userName = Console.ReadLine();

            Console.WriteLine("What is USER age?");

            int userAge = Convert.ToInt32(Console.ReadLine());

            UserInfo(userName, userAge);

            // Applicant info Retrival Method & Displaying in Main Method

            string appName = AskAppName();
            Console.WriteLine($"Hello {appName}!!");

            // Method DOUBLING
            // Adding Integers

            int num1 = 6;
            int num2 = 7;

            int numResult = Add(num1, num2);
            Console.WriteLine($"The Add result is  {numResult}!!");


            //Boolean Operations
            Console.WriteLine("What is your name Sir?");
            string sirName = Console.ReadLine();

            bool isBob = (sirName == "bob");
            //ELSE IF 
            //Are you bob?
            if (isBob)
                Console.WriteLine("Hey Bob! You are amazing!");
            else if (name == "henry")
                Console.WriteLine("Hey Henry!");
            else if (name == "Jason")
                Console.WriteLine("Hey Jason!");
            else if (name == "Charlie")
                Console.WriteLine("Hey Charlie!");

            // == , !=, < , >, >=, <=, ||, &&
            Console.WriteLine("Type a number between 1 and 10");
            int numComp = Convert.ToInt32(Console.ReadLine());

            if (numComp == 3 || numComp == 7 || numComp == 4 || numComp == 9)
            {
                Console.WriteLine("You have won!!");

            }
            else if (numComp != 2 && numComp != 1)
            {
                Console.WriteLine("You won!");
            }



            // Keep the Console Window Open
            Console.ReadLine();


        }



        // Running Multiple Method

        /// <summary>
        /// XML Summary Type
        /// This is section show Multiple Method Application
        /// </sumary>
        /// <returns>Run Multiple Methods on Run</returns>
        static void HelloInteractive()
        { Console.WriteLine("Hello Interactive"); }

        // UserInfo Method
        static void UserInfo(string username, int userage)
        {
            Console.WriteLine($"Hello {username} ! And I believe you are {userage} years old");
        }

        // Storing and Returing Paramter to Main Method
        static string AskAppName()
        {
            Console.WriteLine("What is Applicant Name?");
            string nameOfApp = Console.ReadLine();
            return nameOfApp;
        }

        // Method Overloading - Adding INT

        static int Add(int number1, int number2)
        {
            return number1 + number2;




            // Method Overloading - Adding DOUBLE
        }
        static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

    }
}
