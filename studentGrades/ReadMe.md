Student Grading System

You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

   1.  The code declares variables used to define student names and individual exam scores for each student.
   2.  The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
   3.  The code includes a hard coded letter grade that the developer must apply manually.
   4.  The code includes Console.WriteLine() statements to display the student grading report.

Your goal is to update the existing code to include the following features:

   1.  Use arrays to store student names and assignment scores.

   2.  Use a foreach statement to iterate through the student names as an outer program loop.

   3.  Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.

   4.  Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

   5.  Use an updated algorithm within the outer loop to calculate the average exam score for each student.

   6.  Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

   7.  Integrate extra credit scores when calculating the student's final score and letter grade as follows:
     a.   Your code must detect extra credit assignments based on the number of elements in the student's scores array.
     b.    Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.


Grading Score with Letters Assigned.

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

Sample Report of Student Grading System

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-