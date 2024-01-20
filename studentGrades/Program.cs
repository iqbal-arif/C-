namespace studentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System\n\n");
            //1.  initialize variables - graded assignments 
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

            //2.  Student Names Array
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

            //3. Intializing Student Array

            int[] studentScores = new int[10];

            //4. Initializing Stdent Grade string
            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");

            
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
                    else if (currentStudent == "Becky")
                        studentScores = beckyScores;
                    else if (currentStudent == "Chris")
                        studentScores = chrisScores;
                    else if (currentStudent == "Eric")
                        studentScores = ericScores;
                    else if (currentStudent == "Gregor")
                        studentScores = gregorScores;
                    else
                        continue;
                        
                    //5. Initializing Sum
                    double sumAssignmentScores = 0;
                    int examScore = 0;

                    //6. Initializing Average of exam and extra credit score
                    double currentStudentGrade = 0;
                    int totalExamScore = 0;
                    int totalExtraPoints = 0;

                    //7. initializing counter for the number of assignments
                    int gradedAssignments = 0;
                    int extraCreditAssignments = 0;
                    int extraCreditPointTotal = 0;

                    //8. Calculating the sum of each student's exam assignment scores and adding 10% of extra graded assignment score
                    
                    // int extraCredit = 0;
                    int extraCreditPoint = 0;
                    foreach (int score in studentScores)
                        {
                             //9. incrementing the assignment counter
                            gradedAssignments += 1;

                            if (gradedAssignments <= examAssignments)
                                {
                                //10. adding the exam score to the sum
                                sumAssignmentScores += score;
                                examScore += score;
                                }
                            else
                            {
                                extraCreditAssignments +=1;
                                //11. adding the extra 10% bonus points to exam score
                                sumAssignmentScores += (double) score / 10;
                                extraCreditPoint += score;
                            }
                        }

                    //12. Calculating the average of the student's assignment scores and Assigning the Grade
                    // Console.WriteLine($"{currentStudent}\t\t\t{totalExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{totalExtraPoints} ({extraCreditPointTotal} pts)");
                    // Console.WriteLine(sumAssignmentScores);
                    //  totalExamScore = examScore / examAssignments;
                    //  totalExtraPoints = extraCreditPoint / extraCreditAssignments;
                     currentStudentGrade = Math.Round(  sumAssignmentScores / (double) examAssignments,2);
                    //  extraCreditPointTotal = currentStudentGrade - totalExamScore;

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

                    //13. Title for the Grade Report   
                    Console.WriteLine($"{currentStudent}\t\t\t{totalExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{totalExtraPoints} ({extraCreditPointTotal} pts)");
                }
                
            
            //14. To keep the Console Window Active
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
          

        }
    }
}








