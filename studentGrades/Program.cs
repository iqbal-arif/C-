﻿namespace studentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System\n\n");
            //1.  initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            //2. Calculate the sum of each student's assignment scores
           
            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            Console.WriteLine("Student Assignment Summation\n");
            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Nicolas: " + nicolasSum);
            Console.WriteLine("Zahirah: " + zahirahSum);
            Console.WriteLine("Jeong: " + jeongSum);

            //3. Calculate the average of the student's assignment scores

            decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
            decimal jeongScore = (decimal) jeongSum / currentAssignments;

            Console.WriteLine("\nStudent Average\n");
            Console.WriteLine("Sophia: " + sophiaScore);
            Console.WriteLine("Nicolas: " + nicolasScore);
            Console.WriteLine("Zahirah: " + zahirahScore);
            Console.WriteLine("Jeong: " + jeongScore);

            //4. Grade Assignment

            Console.WriteLine("\nStudent\t\tGrades\n");
            Console.WriteLine("Sophia: \t" + sophiaScore + " \tA");
            Console.WriteLine("Nicolas: \t" + nicolasScore + " \tB");
            Console.WriteLine("Zahirah: \t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong: \t\t" + jeongScore + " \tA");
            
        }
    }
}
