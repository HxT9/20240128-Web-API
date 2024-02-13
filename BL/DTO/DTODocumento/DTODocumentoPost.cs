using BL.DTO.DTORigaDocumento;
using BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO.DTODocumento
{
    public class DTODocumentoPost
    {
        public DateTime DataDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public required List<DTORigaDocumentoPost> Righe { get; set; }
    }
}
