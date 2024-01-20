.NET Class Library Using C#

1. What is an object?
1. An instance of a class.

IF Statements


1. What is a code block?

   a.  A .NET Class Library.

   b.  Lines of code that should be treated as a single unit.

       Correct! A code block is defined by curly braces { }. It collects lines of code that should be treated as a single unit.

    c. A block of code that is blocked from being accessed.

2. What is a Boolean statement or expression?

   a.  A modulus expression.

   b.  An ordinal term.

   c.  Code that returns either true or false.

    Correct! A Boolean expression is any code that returns a Boolean value, either true or false.


3. Given that int x = 5, which of the following Boolean expressions is valid and evaluates to true?

    a. x < 5.

    b. x > 5.

    c. x == 5.

    Correct! Since x is equal to 5, using the C# equality operator == in the expression evaluates to true.

4. Which of the choices below is not a valid operator in C#?

    a. %%.

    Correct! The double percentage-sign symbol %% isn't a valid C# operator.

    b. &&.

    c. ||.

3. The following answer choices describe if statement syntax. Which of the descriptions is correct?

    a. The Boolean expression evaluated by an if statement is optional.

    b. An else statement can't be placed before an else if statement.

      Correct! An else can't be placed before an else if statement.

    c. The else statement is required when an if statement includes an else if.

ARRAYS


1. What is an array?

    1. A string variable.

    2. A sequence of individual data elements accessible through a single variable name.

       Correct. An array data structure with a single name and multiple data locations.

    3. A .NET Class Library.

2. Which of these is a correct example of creating an array and initializing it?

    1. string[] myarray = new string[3]; myarray = "test1"; myarray = "test2"; myarray = "test3";.

    2. string[] myarray = string[3]; myarray[0] = test1; myarray[1] = test2; myarray[2] = test3;.

    3. int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;.

       Correct! The array myarray is declared correctly and the code statements used to assign values to the array elements specify the array index locations.

FOREACH


1. Which of the following can be used to access the third element in an array?

    1. myArray[3].

    2. myArray[2].

    Correct! Indexes are zero-based, so an index of two returns the third element in an array.

    3. myArray{3}.

2. Which of the following choices describes the correct way to create a new integer array with three elements?

    1. int[] myArray = new int[3];.

    Correct! This is the correct way to create an array with three elements.

    2. int[] myArray = new int[2];.

    3. int myArray = new int[3];.

3. Which of the following foreach statements is syntactically correct?

    1. foreach (int value in values).

    Correct! This foreach statement is defined using valid syntax.

    2. foreach (int value of values).

    3. foreach (int value with values).

4. A developer writes an application that uses a foreach loop to iterate through an array containing 20 elements. After the application is complete, the developer learns that the array must be updated to include 40 elements. The application needs to examine all 40 array elements. Which of the following items describes the required code update?

    1. Create a second foreach loop that iterates through the additional items.

    2. No changes are required to the foreach loop.

        Correct! A foreach loop will iterate through all of the elements in an array.

    3. Place the original foreach loop inside the code block of a second foreach loop that iterates twice.

5. A developer is working on a nested foreach structure that iterates through all of an application's data arrays. The first array contains the names of locations where water samples were collected. The remaining arrays contain the test results for the samples collected from each named location. Which of the following statements about how the arrays should be processed is correct?

    1. Each of the arrays containing samples can be processed by the outer loop, the inner loop will be used to verify the location.

    2. The order in which the arrays are processed doesn't matter since the application has to process all of the data.

    3. The outer loop must process the array containing locations, the inner loop must process the arrays containing samples.

    Correct! The outer loop will iterate through the locations. The code block of the outer loop will be used to select the samples array for each location, and then process the sample in the inner foreach loop.

VARIABLE NAMES


1. Which of the following is an example of correct camel case formatting of a variable name?

1. UserOption.

2. user Option.

3. userOption.

Correct! This is the correct way to use camel case for a variable.

WHITESPACES / COMMENTS


1. Which of the following demonstrates recommended guidelines for naming a variable?

    1. my-string.

    2. initialMessage$.

    3. initialMessage.

    Correct! This is the appropriate camel case for a variable name and the name is descriptive.

2. Which of the following is a bad reason to use a code comment?

    1. To describe the high-level intent of the code.

    2. To explain how a new C# keyword works.

C   orrect! Comments should not be used for this reason.

    3. To temporarily comment out a line of code while evaluating a feature in a different way.

3. Which of the following statements about using whitespace in code is true?

    1. Reducing the amount of whitespace will improve code performance (execution speed).

    2. Whitespace should be used every two or three lines to separate code lines.

    3. Whitespace should be used judiciously to improve the readability of your code.

        Correct! Whitespace should be used to improve core readability.

4. A developer is working on a nested foreach structure that iterates through the application's array data. The first array contains the names of 10 geographic regions. The remaining arrays are based on the 10 regions. Each regional array contains the population of cities that have a population over one million. The population values in the regional arrays go from largest to smallest. The application sums the 25 most populated cities in each region. How should the developer ensure that only the 25 largest populations are added to the sum?

1. The developer should insert a "marker value" into the population arrays. The "marker value" should be added at index position 25. When the marker value is detected, the application should stop adding values to the sum.

2. The developer should check the index number of the current array element inside the foreach code block. The application should stop adding values to the sum when the index number reaches 25.

3. The developer should increment a counter inside the foreach code block. The application should stop adding values to the sum when the counter reaches 25.

Correct! The developer should use a counter that increments inside the foreach loop.

5. A developer is working with two other developers to update a collection of applications. The developers will use code comments during the update process. Which of the following describes an appropriate use of code comments?

1. When updates are made, the developers use line and block comments to identify each individual code update.

Incorrect. Code comments should not be used to describe individual code lines. In this case, it would be better to summarize changes in a single block comment at the top of the files that contain updates.

2. When updates are made, the developers leave all existing code comments intact. New comments are added to indicate when old comments no longer apply.

3. When updates are made, the developers summarize changes using block comments.

Correct! Using a block comment to summarize the changes implemented during an update is a good use of code comments. A single block comment at the top of the files that contain updates is often sufficient

BOOLEAN EXPRESSIONS
****

1. Which of the following is a list of valid comparison operators?

    1. ==, ~=, >, <, >=, and <=.

    2. ==, <>, >, <, >=, and <=.

    3. ==, !=, >, <, >=, and <=.

    That's correct. ==, !=, >, <, >=, and <= are all valid comparison operators.

2. Which of the following code lines uses logical negation?

    1. Console.WriteLine(myValue!= true);.

    2. Console.WriteLine(!myValue);.

        Correct! Adding the ! operator before a conditional expression is the correct way to implement logical negation.

    3. Console.WriteLine(myValue == false);.

3. An application contains two string variables named myValue1 and myValue2. The user enters the following two values for these variables: "Y " and " y". Which of the following expressions return false?

    1. (myValue1!= myValue2).

    2. (myValue1.Trim().ToLower() != myValue2.Trim().ToLower()).

    Correct! This expression returns false since the two values are equal and the inequality operator is being used.

    3. (myValue1.Trim().ToLower() == myValue2.Trim().ToLower()).

    Incorrect. This expression returns true because the two values are equal, and the equality operator is being used.

CONDITIONAL OPERATOR RECAP
****
 1. Which of the following lines of code is a valid use of the conditional operator?

    1. int bonus = amount >= 100? 10: 5;.

    Correct! This code line shows the correct syntax for a conditional operator ?:.

    2. int bonus = amount >= 100: 10? 5;.

    3. int bonus = amount >= 100? 10, 5;.


2. Which line of code uses logical negation?

    1. Console.WriteLine(!value);.

    Correct! Adding the ! operator (the "not-operator") before a conditional expression forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true , if the operand evaluates to false , and false , if the operand evaluates to true.

    2. Console.WriteLine(value != false);.

    3. Console.WriteLine(a != b);.

3. Which of the following lines of code is a valid use of the conditional operator?

    1. int value = amount >= 10? 10: 20;.

    Correct! The syntax for a conditional operator is "? (value 1) : (value 2)".

    2. int value = amount >= 10: 10? 20;.

    3. int value = amount >= 10? 10| 20;.

CODE BLOCK

1.  A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed?

    1. No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.

    Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.

    2. No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.

    3. An error is generated because the first variable isn't in-scope after the code block.
