using BL.DTO.DTOArticolo;
using BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO.DTORigaDocumento
{
    public class DTORigaDocumentoGet : EntryDTO
    {
        public DTOArticoloGet? Articolo { get; set; }
        public double Quantita { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
    }

    public enum TipoMovimento
    {
        Carico,
        Scarico
    }
}
