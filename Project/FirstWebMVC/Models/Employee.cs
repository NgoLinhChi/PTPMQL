using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models;
[Table("Employee")]
public class Employee : Person
{
    public string Age { get; set; }
    public string EmployeeID { get; set; }
}