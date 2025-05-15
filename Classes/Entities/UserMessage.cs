using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireFire.Classes.Entities
{
    public class UserMessage
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        
        [Column("message_text")]
        public string MessageText { get; set; }
        
        [Column("dispatch_time")]
        public DateTime DispatchTime { get; set; }

        [Column("sender")]
        public string Sender { get; set; }
        public UserMessage()
        {
            MessageText = "";
            Sender = "E";
        }
    }
}
