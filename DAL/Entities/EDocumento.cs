using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Documento")]
    public class EDocumento : EEntry
    {
        public DateTime DataDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public required List<ERigaDocumento> Righe { get; set; }
    }
}
