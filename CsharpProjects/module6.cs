// initialize variables - graded assignments 
int currentAssignments = 5;

// student exam scores
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names array (outer loop will use this)
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// This array will temporarily hold the current student's scores
int[] studentScores = new int[10];

// Print report header once (not inside loop)
Console.WriteLine("Student\t\tGrade\n");

// OUTER LOOP  tahg goes through each student name oone by oneee
foreach (string name in studentNames)
{
    // store current student name (makes code easier to read)
    string currentStudent = name;

    // assign correct scores array based on student name
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // reset sum for each student
    int sumAssignmentScores = 0;

    // reset average grade variable
    decimal currentStudentGrade = 0;

    // INNER LOOP → goes through each score of the current student
    foreach (int score in studentScores)
    {
        // add score to running total
        sumAssignmentScores += score;
    }

    // calculate average
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    // print student name + calculated grade
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

// pause program
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();