using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("RigaDocumento")]
    public class ERigaDocumento : EEntry
    {
        public EArticolo? Articolo { get; set; }
        public double Quantita { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public double Prezzo { get; set; }
    }

    public enum TipoMovimento
    {
        Carico,
        Scarico
    }
}
