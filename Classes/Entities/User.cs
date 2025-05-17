using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireFire.Classes.Entities
{
    public abstract class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("photo_data")]
        public byte[] PhotoData { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [Column("dialogs_ids")]
        public List<int> DialogsIds { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{Surname?.Trim()} {Name?[0]}.{Lastname?[0]}.";
        }
    }
}