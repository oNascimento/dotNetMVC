using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models{
    public class Employee
    {
        [Key]
        public long? Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public int Age { get; set; }         
    }
}
