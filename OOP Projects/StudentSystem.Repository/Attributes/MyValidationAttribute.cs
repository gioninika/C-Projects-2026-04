namespace StudentSystem.Attributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract void Validate(object value, object instance, string propertyName);
    }
}
