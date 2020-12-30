using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Models
{[Table("Events")]
    public class EventModel
    {[Key]
        public int EventId { get; set; }
        [MaxLength(50)]
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [MaxLength(50)]
        [DisplayName("Sport")]
        public string Category { get; set; }
        [MaxLength(50)]
        [DisplayName("Miejsce")]
        public string Localization { get; set; }
        [MaxLength(50)]
        [DisplayName("Data")]
        public string Date { get; set; }
        [MaxLength(50)]
        [DisplayName("Organizator")]
        public string Organizer { get; set; }
    }
}
