using System.Collections.Generic;
using System;
namespace ModuleTwo;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; }

    public Student()
    {
        Name = "Bob";
        ID = 6352731;
        Grades = new List<double>();
        
    }

    public void AddGrade(double grades)
    {
       Grades.Add(grades);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        double sum = 0;
            for (int i = 0; i < Grades.Count; i++)
            {
                sum += Grades[i];

            }
        return sum / Grades.Count;
    }

}
