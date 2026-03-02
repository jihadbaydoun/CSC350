// number of regular (exam) assignments
int currentAssignments = 5;

// exam scores for each student
int[] sophiaScores = { 90, 86, 87, 98, 100 };
int[] andrewScores = { 92, 89, 81, 96, 90 };
int[] emmaScores = { 90, 85, 87, 98, 68 };
int[] loganScores = { 90, 95, 87, 88, 96 };

// list of student names (outer loop will go through this)
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

// this will temporarily store whichever student's scores we are working with
int[] studentScores = new int[10];

// print the report header once before looping
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tLetter Grade\tExtra Credit\n");

// go through each student one at a time
foreach (string name in studentNames)
{
    string currentStudent = name;

    // match student name to correct score array
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // reset total for this student
    int sumAssignmentScores = 0;

    // will store calculated overall grade
    decimal currentStudentGrade = 0;

    // placeholders for the new report columns (calculation comes next exercise)
    decimal examScore = 0;
    int extraCreditScore = 0;
    decimal extraCreditPoints = 0;

    // add up all assignment scores
    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    // calculate average grade
    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    // determine letter grade based on average
    string letterGrade = "";

    if (currentStudentGrade >= 97)
        letterGrade = "A+";
    else if (currentStudentGrade >= 93)
        letterGrade = "A";
    else if (currentStudentGrade >= 90)
        letterGrade = "A-";
    else if (currentStudentGrade >= 87)
        letterGrade = "B+";
    else if (currentStudentGrade >= 83)
        letterGrade = "B";
    else if (currentStudentGrade >= 80)
        letterGrade = "B-";
    else if (currentStudentGrade >= 77)
        letterGrade = "C+";
    else if (currentStudentGrade >= 73)
        letterGrade = "C";
    else if (currentStudentGrade >= 70)
        letterGrade = "C-";
    else if (currentStudentGrade >= 67)
        letterGrade = "D+";
    else if (currentStudentGrade >= 63)
        letterGrade = "D";
    else if (currentStudentGrade >= 60)
        letterGrade = "D-";
    else
        letterGrade = "F";

    // display student results
    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{currentStudentGrade}\t{letterGrade}\t{extraCreditScore} ({extraCreditPoints} pts)");
}

// pause so the console window doesn’t close immediately
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();