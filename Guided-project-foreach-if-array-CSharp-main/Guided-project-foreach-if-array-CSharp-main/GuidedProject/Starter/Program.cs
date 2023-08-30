// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    int courseCount = 0;

    foreach (int score in studentScores)
    {
        courseCount++;
        if(courseCount > 5) 
        {
            sumAssignmentScores += score / 10;
        }
        else 
        {
            // add the exam score to the sum
            sumAssignmentScores += score;
        }
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    string currentStudentLetterGrade = "";

    if (currentStudentGrade >= 97 && currentStudentGrade <= 100)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93 && currentStudentGrade <= 96) 
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90 && currentStudentGrade < 93) 
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87 && currentStudentGrade < 90) 
    {
        currentStudentLetterGrade = "B+";
    }          
    else if (currentStudentGrade >= 83 && currentStudentGrade < 87) 
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80 && currentStudentGrade < 83) 
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77 && currentStudentGrade < 80) 
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73 && currentStudentGrade < 77) 
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70 && currentStudentGrade < 73) 
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67 && currentStudentGrade < 70) 
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63 && currentStudentGrade < 67) 
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60 && currentStudentGrade < 63) 
    {
        currentStudentLetterGrade = "D-";
    }
    else if (currentStudentGrade >= 0 && currentStudentGrade < 60)
    {
        currentStudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
