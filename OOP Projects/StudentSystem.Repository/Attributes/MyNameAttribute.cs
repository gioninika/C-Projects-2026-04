using StudentSystem.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyNameAttribute : MyValidationAttribute
    {
        private int maxlength;
        public MyNameAttribute(int length)
        {
            maxlength = length;
        }
        public override void Validate(object value, object instance, string propertyName)
        {
            if (value is null)
            {
                throw new ArgumentNullException($"{propertyName} is required");
            }
            if (propertyName.Length > maxlength)
            {
                throw new ArgumentException();
            }
        }
    }
}
