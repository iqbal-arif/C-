namespace studentGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Student: Sophia Johnson

            Course          Grade   Credit Hours	
            English 101         4       3
            Algebra 101         3       3
            Biology 101         3       4
            Computer Science I  3       4
            Psychology 101      4       3

            Final GPA:          3.35
             * */

            //1. Initializing Grade and Credit Hours

            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            //2. Course Grade
            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            //3. Course names along with Numeric grade & Credit Hours.

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

            //4. Total Credit Hour Calculations

            int totalCreditHours = 0;

            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            //5. Total Grade Proint Average

            int totalGradePoints = 0;

            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;


            //6. GPA

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
            Console.WriteLine($"Final GPA: {gradePointAverage}");
            Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

            //7. Leading & Trailing Digits

            //Leading Digit
            int leadingDigit = (int)gradePointAverage;
            Console.WriteLine("Leading Digit : " +leadingDigit);

            //Trailing First Point
            int firstDigit = (int)(gradePointAverage * 10) % 10;

            //Trailing Second Point
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            //Combined Leading & Trailing CPA
            Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

            //8. Format the output using escaped character sequences

            Console.WriteLine($"\nStudent: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

        }
    }
}
