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
        public uint jobseeker_id;
        [Key] // Указывает, что это первичный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
        public uint resume_id;
        public string profession;
        public string education;
        public uint experience;
        public string soft_skills;
        public decimal salary;
        public string city;
        public string description;
    }
}
