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
        public uint employer_id;
        [Key] // Указывает, что это первичный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
        public uint vacancy_id;
        public uint experience;
        public string profession;
        public decimal salary;
        public string city;
        public string company_name;
        public string company_description;
    }
}
