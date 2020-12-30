using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Models
{
    [Table("Players")]
    public class PlayerModel
    {[Key]
        public int PlayerId { get; set; }
        [MaxLength(50)]
        [DisplayName("Imię")]
        public string Name { get; set; }
        [MaxLength(50)]
        [DisplayName("Nazwisko")]
        public string Surname { get; set; }
        [MaxLength(50)]
        [DisplayName("Data urodzenia")]
        public string DateOfBirdth { get; set; }
        [MaxLength(50)]
        [DisplayName("Płeć")]
        public string Gender { get; set; }
    }
}
