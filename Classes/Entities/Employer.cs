using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HireFire.Classes.Entities
{
    public class Employer : User
    {
        public virtual ICollection<Vacancy> Vacancies { get; set; }
        public Employer()
        {
            DialogsIds = [];
            Vacancies = [];
            Gender = "M";
        }
    }
}
