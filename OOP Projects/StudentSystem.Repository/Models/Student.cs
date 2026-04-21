using StudentSystem.Repository.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Repository.Models
{
    public class Student
    {
        [MyName(50)]
        public string Name { get; set; }
        [MyRollNumber]
        public int RollNumber { get; set; }
        [MyGrade]
        public char Grade { get; set; }
    }
}
