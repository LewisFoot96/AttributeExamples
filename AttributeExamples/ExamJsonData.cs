using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AttributeExamples;

//Attributes provide metadata about your code
//Used for defining the behavior of the code
public class ExamJsonData
{
    //Will be ignored when serializing to JSON
    //Specific values allowed for string
    [JsonIgnore]
    [AllowedValues("Math", "Science", "History")]
    public required string ExamName { get; set; }
    
    public int ExamId { get; set; }
    
    [CustomAttribute("With parameter")]
    internal void SetExamName(string examName)
    {
        ExamName = examName;
    }
}