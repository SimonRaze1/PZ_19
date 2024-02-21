using System;

public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public double AverageGrade { get; set; }
    public string Specialization { get; set; }
    public DateTime AdmissionDate { get; set; }

    public Student(string name, double averageGrade, string specialization, DateTime admissionDate)
    {
        Name = name;
        AverageGrade = averageGrade;
        Specialization = specialization;
        AdmissionDate = admissionDate;
    }

    public void DismissGraduate()
    {
        Console.WriteLine($"Студент {Name} успешно завершил обучение по специальности {Specialization} со средним баллом {AverageGrade}.");
    }

    public void DismissFailure()
    {
        Console.WriteLine($"Студент {Name} отчислен по неуспеваемости из-за низкого среднего балла {AverageGrade}.");
    }

    public void DismissAcademicLeave(TimeSpan leavePeriod)
    {
        Console.WriteLine($"Студент {Name} находится в академическом отпуске до {DateTime.Now.Add(leavePeriod)}.");
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return student1.AdmissionDate == student2.AdmissionDate;
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(student1 == student2);
    }

    public static bool operator >(Student student1, Student student2)
    {
        return student1.AdmissionDate > student2.AdmissionDate;
    }

    public static bool operator <(Student student1, Student student2)
    {
        return student1.AdmissionDate < student2.AdmissionDate;
    }

    public static bool operator >=(Student student1, Student student2)
    {
        return student1.AdmissionDate >= student2.AdmissionDate;
    }

    public static bool operator <=(Student student1, Student student2)
    {
        return student1.AdmissionDate <= student2.AdmissionDate;
    }

    public int CompareTo(Student other)
    {
        return AdmissionDate.CompareTo(other.AdmissionDate);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Иванов", 4.0, "Математика", new DateTime(2023, 1, 15));
        Student student2 = new Student("Петров", 2.5, "Физика", new DateTime(2023, 2, 10));

        student1.DismissGraduate();
        student2.DismissFailure();

        Console.WriteLine(student1 >= student2);
    }
}
