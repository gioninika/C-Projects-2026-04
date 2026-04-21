using StudentSystem.Repository.Interfaces;
using StudentSystem.Repository.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace StudentSystem.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private const string _filePath = @"../../../../StudentSystem.Data/Students.json";
        private readonly List<Student> _students;
        public StudentRepository()
        {
            _students = LoadDataAsync(_filePath).ToListAsync().Result;
        }
        

        public async Task<int> AddStudentAsync(Student student)
        {
            student.RollNumber = _students.Any() ? _students.Max(a => a.RollNumber) + 1 : 1;
            MyValidators.Validate(student);
            student.Grade = char.ToUpper(student.Grade);
            _students.Add(student);
            await SaveDataAsync();

            return student.RollNumber;
        }

        public Student GetSingleStudent(int id) => _students.FirstOrDefault(a => a.RollNumber == id);

        public List<Student> GetStudents() => _students;

        public async Task<Student> UpdateStudentGradeAsync(int id, char grade)
        {
            var index = _students.FindIndex(a => a.RollNumber == id);

            if (index >= 0)
            {
                _students[index].Grade = char.ToUpper(grade);
                await SaveDataAsync();
            }

            return _students[index];
        }
        public static async IAsyncEnumerable<Student> LoadDataAsync(string filePath)
        {
            if (!File.Exists(filePath))
                yield break;

            List<Student>? deserialized;

            try
            {
                await using var fs = new FileStream(
                    filePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read,
                    8192,
                    useAsync: true);

                deserialized = await JsonSerializer.DeserializeAsync<List<Student>>(
                    fs,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
            catch
            {
                yield break;
            }

            if (deserialized == null)
                yield break;

            foreach (var student in deserialized)
            {
                yield return student;
            }
        }

        private async Task SaveDataAsync()
        {
            await using var fs = new FileStream(
                _filePath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                8192,
                useAsync: true);

            await JsonSerializer.SerializeAsync(
                fs,
                _students,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            await fs.FlushAsync();
        }
    }
}
