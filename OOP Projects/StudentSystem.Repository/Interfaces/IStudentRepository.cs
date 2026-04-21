using StudentSystem.Repository.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace StudentSystem.Repository.Interfaces
{
    internal interface IStudentRepository
    {
        Task<int> AddStudentAsync(Student student);
        List<Student> GetStudents();
        Student GetSingleStudent(int id);
        Task<Student> UpdateStudentGradeAsync(int id, char grade);
    }
}
