internal class Program
{
    private static void Main(string[] args)
    {
        // Student GPA Calculator
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Computer Science I";
        string course4Name = "Psychology 101";
        string course5Name = "Biology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHourse = 0;
        totalCreditHourse += course1Credit;
        totalCreditHourse += course2Credit;
        totalCreditHourse += course3Credit;
        totalCreditHourse += course4Credit;
        totalCreditHourse += course5Credit;


        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHourse;
        int leadingDigit = (int)gradePointAverage;
        int trailingDigits = (int)(gradePointAverage * 100) - (leadingDigit * 100);


        //Console.WriteLine($"{totalGradePoints} {totalCreditHourse}");
        Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        Console.WriteLine($"Final GPA: {leadingDigit}.{trailingDigits}" );




    }
}