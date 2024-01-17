namespace studentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System\n\n");
            //1.  initialize variables - graded assignments 
            int currentAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] {92, 89, 81, 96, 90};
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            //2.  Student Names Array
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tScore\t\tGrade\n");

            foreach (string name in studentNames)
                {
                   string currentStudent = name;

                   if(currentStudent == "Sophia")
                        studentScores = sophiaScores;

                    else if (currentStudent == "Andrew")
                        studentScores = andrewScores;

                    else if (currentStudent == "Emma")
                        studentScores = emmaScores;

                    else if (currentStudent == "Logan")
                        studentScores = loganScores;    
                    
                    int sumAssignmentScores = 0;

                    decimal currentStudentGrade = 0;
                    
                    foreach (int score in studentScores)
                        {
                            sumAssignmentScores += score;
                        }

                    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

                    if (currentStudentGrade >= 97)
                        currentStudentLetterGrade = "A+";

                    else if (currentStudentGrade >= 93)
                        currentStudentLetterGrade = "A";

                    else if (currentStudentGrade >= 90)
                        currentStudentLetterGrade = "A-";

                    else if (currentStudentGrade >= 87)
                        currentStudentLetterGrade = "B+";

                    else if (currentStudentGrade >= 83)
                        currentStudentLetterGrade = "B";

                    else if (currentStudentGrade >= 80)
                        currentStudentLetterGrade = "B-";

                    else if (currentStudentGrade >= 77)
                        currentStudentLetterGrade = "C+";

                    else if (currentStudentGrade >= 73)
                        currentStudentLetterGrade = "C";

                    else if (currentStudentGrade >= 70)
                        currentStudentLetterGrade = "C-";

                    else if (currentStudentGrade >= 67)
                        currentStudentLetterGrade = "D+";

                    else if (currentStudentGrade >= 63)
                        currentStudentLetterGrade = "D";

                    else if (currentStudentGrade >= 60)
                        currentStudentLetterGrade = "D-";

                    else
                        currentStudentLetterGrade = "F";
                       
                    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}");
                }
                
            
            /*
            int sophiaSum = 0;
            int andrewSum = 0;
            int emmaSum = 0;
            int loganSum = 0;

            decimal sophiaScore;
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;

            //2. Calculate the sum of each student's assignment scores
           
            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            Console.WriteLine("Student Assignment Summation\n");
            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Andrew: " + andrewSum);
            Console.WriteLine("Emma: " + emmaSum);
            Console.WriteLine("Logan: " + loganSum);

            //3. Calculate the average of the student's assignment scores

            sophiaScore = (decimal)sophiaSum / currentAssignments;
            andrewScore = (decimal)andrewSum / currentAssignments;
            emmaScore = (decimal)emmaSum / currentAssignments;
            loganScore = (decimal)loganSum / currentAssignments;

            Console.WriteLine("\nStudent Average\n");
            Console.WriteLine("Sophia: " + sophiaScore);
            Console.WriteLine("Andrew: " + andrewScore);
            Console.WriteLine("Emma: " + emmaScore);
            Console.WriteLine("Logan: " + loganScore);

            //4. Grade Assignment

            Console.WriteLine("\nStudent\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            */
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();


        }
    }
}








