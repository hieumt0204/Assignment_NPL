using Example14;

public class Program
{
    /*
     *  Write a program in C# Sharp to find the n-th maximum grade point achieved by the students from the list of students.
    Test Data :
    Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : 3
    :
    Id : 7, Name : David, achieved Grade Point : 750
    Id : 10, Name : Jenny, achieved Grade Point : 750

    
     */
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", GradePoint = 100 },
            new Student { Id = 2, Name = "Bob", GradePoint = 700 },
            new Student { Id = 3, Name = "Charlie", GradePoint = 850 },
            new Student { Id = 4, Name = "David", GradePoint = 750 },
            new Student { Id = 5, Name = "Eva", GradePoint = 900 },
            new Student { Id = 6, Name = "Frank", GradePoint = 500 },
            new Student { Id = 7, Name = "Grace", GradePoint = 700 },
            new Student { Id = 8, Name = "Hank", GradePoint = 700 },
            new Student { Id = 9, Name = "Ivy", GradePoint = 720 },
            new Student { Id = 10, Name = "Jenny", GradePoint = 750 }
        };

        Console.Write("Which maximum grade point (1st, 2nd, 3rd, ...) you want to find: ");
        int n = Convert.ToInt32(Console.ReadLine());

        var distinctGrade = students.Select(student => student.GradePoint).Distinct().OrderByDescending(s => s).ToList();
        if(n >= 1 && n <= distinctGrade.Count())
        {
            int maxGrade = distinctGrade[n - 1];
            var maxGradeStudent = students.Where(student => student.GradePoint == maxGrade).ToList();
            foreach (var student in maxGradeStudent)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, achieved Grade Point: {student.GradePoint}");
            }


        }
        else
        {
            Console.WriteLine("Invalid input for n. Please enter a valid value within the range.");
        }


    }
}