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
        public virtual ICollection<Resume> Resumes { get; set; }
        public JobSeeker()
        {
            Resumes = [];
            Gender = "M";
        }
    }
}
