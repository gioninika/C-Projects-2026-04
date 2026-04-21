using StudentSystem.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyGradeAttribute : MyValidationAttribute
    {
        public override void Validate(object value, object instance, string propertyName)
        {
            if (value is null)
            {
                throw new ArgumentNullException($"{propertyName} is required");
            }
            if (!"abcdf".Contains(value.ToString().ToLower()))
            {
                throw new Exception("შეფასება უნდა იყოს A, B, C, D ან F!");
            }
        }
    }
}
