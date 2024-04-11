using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

using System;
using System.Collections.Generic;

// Abstraction
interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary(decimal baseSalary);
    List<string> GetAddresses();
}

interface IStudentService : IPersonService
{
    decimal CalculateGPA(Dictionary<string, char> courseGrades);
}

interface IInstructorService : IPersonService
{
    decimal CalculateBonusSalary(DateTime joinDate);
}

interface IDepartmentService
{
    void AssignHeadInstructor(Instructor instructor);
}

class Person : IPersonService
{
    public DateTime BirthDate { get; set; }
    private List<string> addresses = new List<string>();

    public int CalculateAge(DateTime birthDate)
    {
        return DateTime.Now.Year - birthDate.Year;
    }

    public decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0)
            throw new ArgumentException("Salary cannot be negative.");

        return baseSalary;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }
}

class Student : Person, IStudentService
{
    public decimal CalculateGPA(Dictionary<string, char> courseGrades)
    {
        int totalGradePoints = 0;
        foreach (var grade in courseGrades.Values)
        {
            totalGradePoints += GetGradePoints(grade);
        }

        return (decimal)totalGradePoints / courseGrades.Count;
    }

    private int GetGradePoints(char grade)
    {
        switch (grade)
        {
            case 'A': return 4;
            case 'B': return 3;
            case 'C': return 2;
            case 'D': return 1;
            default: return 0;
        }
    }
}

class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }

    public decimal CalculateBonusSalary(DateTime joinDate)
    {
        int yearsOfExperience = DateTime.Now.Year - joinDate.Year;
        // Assuming $1000 bonus for each year of experience
        return yearsOfExperience * 1000;
    }
}

class Course
{
    public List<Student> EnrolledStudents { get; set; }
}

class Department : IDepartmentService
{
    public Instructor HeadInstructor { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public void AssignHeadInstructor(Instructor instructor)
    {
        HeadInstructor = instructor;
    }

    public List<Course> OfferedCourses { get; set; }
}

