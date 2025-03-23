namespace AttributeExamples;

[AttributeUsage(AttributeTargets.Method)]
internal class CustomAttribute : Attribute
{
    public readonly string Name;

    public CustomAttribute()
    {
        
    }
    
    public CustomAttribute(string name)
    {
        Name = name;
    }
}