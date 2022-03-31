using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data;
[Table("MyFirstSchema")]
public class MyFirstSchema
{
    [Key] public int Id { get; set; }
    public string TestString { get; set; } = "asd";
    public int TestInt { get; set; } = 1;
    public bool TestBool { get; set; } = true;
}
