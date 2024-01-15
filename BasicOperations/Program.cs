using System.Diagnostics.Metrics;

namespace BasicOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Perform basic operations on numbers in C#
            //1. Perform addition with implicit data conversion
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            //2. Mix data types to force implicit type conversions

            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

            //3. Attempt a more advanced case of adding numbers and concatenating strings

            string firstName2 = "Bob";
            int widgetsSold2 = 7;
            Console.WriteLine(firstName2 + " sold " + widgetsSold2 + 7 + " widgets.");
            //Bob sold 77 widgets.

            //4. Add parentheses to clarify your intention to the compiler
            string firstName3 = "Bob";
            int widgetsSold3 = 7;
            Console.WriteLine(firstName3 + " sold " + (widgetsSold3 + 7) + " widgets.");


            /*Here's what you've learned so far about mathematical operations in C#:

                1. You can perform mathematical-like addition operations on numbers.
                2. Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
                3. When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
                4. Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.
             * */

            //Exercise - Perform math operations
            //1. Add code to perform division using literal decimal data
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            //2. Add code to perform division using literal decimal data
            //You use the name of the data type surrounded by parentheses in front of the value to cast it
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            //3. Write code to determine the remainder after integer division
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            // Order of operations PEMDAS
            /*
                1. Parentheses (whatever is inside the parenthesis is performed first)
                2. Exponents
                3. Multiplication and Division (from left to right)
                4. Addition and Subtraction (from left to right)

            */
            //1. Write code to exercise C#'s order of operations
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            /*Recap

            Here's what you've learned so far about mathematical operations in C#:

            1. Use operators like +, -, *, and / to perform basic mathematical operations.
            2. The division of two int values will result in the truncation of any values after the decimal point. To retain values after the decimal point, you need to cast the divisor or dividend (or both) from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
            3. Perform a cast operation to temporarily treat a value as if it were a different data type.
            4. Use the % operator to capture the remainder after division.
            5. The order of operations will follow the rules of the acronym PEMDAS.

             * 
             * 
             * 
             * */
            //Exercise - Increment and decrement values
            //1. Increment and decrement
            int value = 0;     // value is now 0.
            value = value + 1; // value is now 1.
            value++;           // value is now 2.

            //2. Write code to increment and decrement a value
            int value3 = 1;

            value3 = value3 + 1;
            Console.WriteLine("First increment: " + value3);

            value3 += 1;
            Console.WriteLine("Second increment: " + value3);

            value3++;
            Console.WriteLine("Third increment: " + value3);

            value3 = value3 - 1;
            Console.WriteLine("First decrement: " + value3);

            value3 -= 1;
            Console.WriteLine("Second decrement: " + value3);

            value3--;
            Console.WriteLine("Third decrement: " + value3);

            //Position the increment and decrement operators
            //1. Use the increment operator before and after the value
            int value4 = 1;
            value4++;
            Console.WriteLine("First: " + value4);
            Console.WriteLine($"Second: {value4++}");
            Console.WriteLine("Third: " + value4);
            Console.WriteLine("Fourth: " + (++value4));

            /*  Recap

           Here's what you've learned so far about mathematical operations in C#:

           1. Use compound assignment operators like +=, -=, *=, ++, and-- to perform a mathematical operation like increment or decrement, then assign the result into the original variable.
           2.  ncrement and decrement operators perform differently depending on whether the operator is before or after the operand. 
             */
            int fahrenheit = 94;

            decimal celsius = (fahrenheit - 2) * ((decimal)5 / (decimal)9);
            Console.WriteLine($"The temperature is {celsius} Celsius.");

            Console.WriteLine("Windows" + 7 + 4);
            Console.WriteLine( 5 / 10);
            // Need more comments
        }
    }
}
