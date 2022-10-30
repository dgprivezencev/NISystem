using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
