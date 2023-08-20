using System.ComponentModel.DataAnnotations;

namespace HRService.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
