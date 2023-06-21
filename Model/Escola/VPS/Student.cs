public class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }

    public decimal CalculateAverageGrade()
    {
        int sum = Grades.Sum();
        int currentAssignments = Grades.Count;
        decimal average = (decimal)sum / currentAssignments;
        return average;
    }
}
