using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId{ get; set; }
        [ForeignKey("ParentId")]
        public Department Parent { get; set; }
    }
}
