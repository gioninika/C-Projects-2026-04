using StudentSystem.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace StudentSystem.Repository
{
    public class MyValidators
    {
        public static void Validate(object name)
        {
            Type type = name.GetType();
            var allProps = type.GetProperties();
            foreach (var prop in allProps)
            {
                var value = prop.GetValue(name);
                var validationAttributes = prop.GetCustomAttributes<MyValidationAttribute>();
                foreach (var a in validationAttributes) a.Validate(value, name, prop.Name);
            }
        }
    }
}
