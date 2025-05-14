using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireFire.Classes.Entities
{
    public class Resume
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        public int JobseekerId { get; set; }
        public string Profession { get; set; }
        public string Education { get; set; }
        public int Experience { get; set; }
        public string SoftSkills { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
    }
}
