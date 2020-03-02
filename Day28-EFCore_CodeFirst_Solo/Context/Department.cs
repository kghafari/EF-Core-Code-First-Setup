using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day28_EFCore_CodeFirst_Solo.Context
{
    public class Department
    {
        [Key] //USING STATEMENT
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //USING STATEMENT
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public double Budget { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
