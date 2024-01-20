Learning objectives
****
In this module, you will:

   1.  Understand the impact of declaring and initializing variables inside and outside of code blocks.
   2.  Improve the readability code blocks in if statements.

Recap
****
Here are a few important things to remember about code blocks:

   1. When you define a variable inside of a code block, its visibility is local to that code block and inaccessible outside of that code block.
   2. To make a variable visible inside and outside of a code block, you must define the variable outside of the code block.
   3. Don't forget to initialize any variables whose value is set in a code block, such as an if statement.

********************************
********************************
When implementing an if statement that includes a single-statement code block, Microsoft recommends that you consider these conventions:

    Never use single-line form (for example: if (flag) Console.WriteLine(flag));
    Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
    Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
********************************
********************************

Recap

Here are a few important things to remember about if statement code blocks and readability:

   1.  If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, you can remove the curly braces of the code block and white space. Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif-else statement (either present or removed consistently).
   2. Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
   3. Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.


