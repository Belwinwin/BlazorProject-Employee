using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter name...")]
        public string Name { get; set; }
    }
}
