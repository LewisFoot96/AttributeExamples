// See https://aka.ms/new-console-template for more information

using System.Reflection;
using AttributeExamples;

Console.WriteLine("Hello, World!");

CheckMyAttribute();

static void CheckMyAttribute()
{
    CustomAttribute? customAttribute = (CustomAttribute)Attribute.GetCustomAttribute(
        typeof(ExamJsonData).GetMethods(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.DeclaredOnly).First(),
        typeof(CustomAttribute));
    
    Console.WriteLine(customAttribute is not null ? customAttribute.Name : "No custom attribute found");
}