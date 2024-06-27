using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproachDemo.Models
{
    [Table ("Emp")]
    public class Employee
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage ="Name is compulsory" ,AllowEmptyStrings=false)]
        [StringLength(50)]
        [MinLength(2,ErrorMessage ="Enter atleast 2 chars name")]
        [MaxLength(50,ErrorMessage ="Max allowed name is 50 chars")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Need a valid Email id")]
        public string Email { get; set; }
        [Range(10000,90000,ErrorMessage ="Salary Not in range")]

        public int salary { get; set; }

    }
}
