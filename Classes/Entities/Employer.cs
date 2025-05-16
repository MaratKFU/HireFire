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
