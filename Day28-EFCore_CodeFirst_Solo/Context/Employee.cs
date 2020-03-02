using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day28_EFCore_CodeFirst_Solo.Context
{
    public class Employee
    {
        [Key] //USING STATEMENT
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //USING STATEMENT
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }

        [Display(Name = "Name")]
        public int? DepartmentId { get; set; }

        //ForeignKey dataannotation links the DepartmentId property of Employee
        //with the primary key of the Employee's department property.
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
