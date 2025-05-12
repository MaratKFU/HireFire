using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireFire.Classes.Entities
{
    public class JobSeeker : User
    {
        //[Key] // Указывает, что это первичный ключ
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
        //public int jobseeker_id { get; set; }
        //public List<Resume> Resumes { get; set; } = new();
        public JobSeeker()
        {
            Gender = "M";
        }
    }
}
