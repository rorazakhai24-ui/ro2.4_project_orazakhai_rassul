using System.Collections.ObjectModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel
{
    public ObservableCollection<Student> Students { get; } = new();

    public string NewName { get; set; } = "";

    public StudentsViewModel()
    {
        Students.Add(new Student { Name = "Dexter Morgan", Gpa = 3.85 });
        Students.Add(new Student { Name = "David MCcal", Gpa = 3.20 });
        Students.Add(new Student { Name = "Joe Goldberg", Gpa = 3.95 });
        Students.Add(new Student { Name = "Billi Butcher", Gpa = 2.75 });
        Students.Add(new Student { Name = "Antony Starr", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;
        Students.Add(new Student { Name = NewName, Gpa = 3.0 });
        NewName = "";
    }
}