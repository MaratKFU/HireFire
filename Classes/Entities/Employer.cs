using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HireFire.Classes.Entities
{
    public class Employer : User
    {
        //[Key] // Указывает, что это первичный ключ
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
        //public List<Vacancy> Vacancies { get; set; } = new();
        public Employer()
        {
            Gender = "M";
        }
    }
}
