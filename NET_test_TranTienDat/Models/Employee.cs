using System.ComponentModel.DataAnnotations;

namespace NET_test_TranTienDat.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        
    }
}
