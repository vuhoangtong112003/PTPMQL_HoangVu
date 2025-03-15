using System.ComponentModel.DataAnnotations;

namespace NewMVCApp.Models;

public class Person
{
    [Key]
    public int? Id { get; set; }

    public string Fullname {get; set;}

    public string Address {get; set;}
    
    public string Gender {get; set;}
    
}
