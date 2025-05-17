using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireFire.Classes.Entities
{
    public class Vacancy
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("employer_id")]
        public int EmployerId { get; set; }
        [Column("experience")]
        public int Experience { get; set; }
        [Column("profession")]
        public string Profession { get; set; }
        [Column("salary")]
        public decimal Salary { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("company_name")]
        public string CompanyName { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}
