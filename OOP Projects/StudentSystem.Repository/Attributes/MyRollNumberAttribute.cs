using StudentSystem.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyRollNumberAttribute : MyValidationAttribute
    {

        public override void Validate(object value, object instance, string propertyName)
        {
            if (value is null)
            {
                throw new ArgumentNullException($"{propertyName} is required");
            }
            if (propertyName.Length <= 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
