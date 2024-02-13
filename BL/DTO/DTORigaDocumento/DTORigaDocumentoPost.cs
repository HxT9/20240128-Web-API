using BL.DTO.DTOArticolo;
using BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO.DTORigaDocumento
{
    public class DTORigaDocumentoPost
    {
        public int ArticoloId { get; set; }
        public double Quantita { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
    }
}
