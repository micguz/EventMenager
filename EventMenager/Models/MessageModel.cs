using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Models
{
    [Table("Messages")]
    public class MessageModel
    {[Key]
        public int MessageId { get; set; }
        [MaxLength(50)]
        [DisplayName("Imię")]
        public string Name { get; set; }
        [MaxLength(50)]
        [DisplayName("Adres e-mail")]
        [Required(ErrorMessage = "Pole e-mail jest wymagane")]
        [EmailAddress(ErrorMessage = "Adres e-mail jest niepoprawny")]
        public string Email { get; set; }
        [MaxLength(3000)]
        [DisplayName("Wiadomość")]
        public string Message { get; set; }
        public bool Reply { get; set; }
    }
}
