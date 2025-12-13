using System;

namespace School.Domain.Models;

public class Teacher
{
    int Age;
    string FirstName;
    string LastName;

    public Teacher(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Teacher: {FirstName} {LastName}, Age: {Age}");
    }
}
