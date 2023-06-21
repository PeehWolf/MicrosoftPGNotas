class Program
{
    public void Run()
    {
        // Create instances of students and their grades
        Student sophia = new Student("Sophia", new List<int> { 93, 87, 98, 95, 100 });
        Student nicolas = new Student("Nicolas", new List<int> { 80, 83, 82, 88, 85 });
        Student zahirah = new Student("Zahirah", new List<int> { 84, 96, 73, 85, 79 });
        Student jeong = new Student("Jeong", new List<int> { 90, 92, 98, 100, 97 });

        // Display the grades
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{sophia.Name}:\t\t{sophia.CalculateAverageGrade()}\tA");
        Console.WriteLine($"{nicolas.Name}:\t{nicolas.CalculateAverageGrade()}\tB");
        Console.WriteLine($"{zahirah.Name}:\t{zahirah.CalculateAverageGrade()}\tB");
        Console.WriteLine($"{jeong.Name}:\t\t{jeong.CalculateAverageGrade()}\tA");
    }
}
