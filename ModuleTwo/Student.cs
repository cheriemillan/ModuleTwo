namespace ModuleTwo;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Grades { get; set; }

    public Student()
    {
        Name = "Bob";
        ID = 6352731;
        Grades = 98;
    }

    public void AddGrade(double grades)
    {
        
    }

    public void AddGrade(params double[] grades)
    {
        List<double> Grades = new List<double>();
        Grades.AddRange(grades);
    }

}
