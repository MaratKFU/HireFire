using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HireFire.Classes.Entities
{
    public class MyDialog
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        
        [Column("jobseeker_id")]
        public int JobSeekerId { get; set; }
        
        [Column("employer_id")]
        public int EmployerId { get; set; }
        
        [Column("messages_ids")]
        public List<int> MessagesIds { get; set; }
        
        [Column("jobseeker_init")]
        public string JobSeekerInit { get; set; }
        
        [Column("employer_init")]
        public string EmployerInit { get; set; }

        public MyDialog()
        {
            MessagesIds = [];
        }
    }
}
