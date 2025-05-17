using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireFire.Classes.Entities
{
    public class Resume
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("jobseeker_id")]
        public int JobSeekerId { get; set; }

        [Column("profession")]
        public string Profession { get; set; }

        [Column("education")]
        public string Education { get; set; }

        [Column("experience")]
        public int Experience { get; set; }

        [Column("soft_skills")]
        public string SoftSkills { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("salary")]
        public decimal Salary { get; set; }
    }
}