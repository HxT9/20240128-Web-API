using DAL.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Articolo")]
    public class EArticolo : EEntry
    {
        [Required]
        public string? Codice { get; set; }
        public string? Descrizione { get; set; }
    }
}
