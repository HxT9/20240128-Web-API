using BL.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO.DTOArticolo
{
    public class DTOArticoloPost
    {
        [Required]
        public required string Codice { get; set; }
        public string? Descrizione { get; set; }
    }
}
