using BL;
using BL.DTO.DTODocumento;
using Microsoft.AspNetCore.Mvc;

namespace _20240128_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentoController : ControllerBase
    {
        private BLDocumento _BLDocumento;

        public DocumentoController()
        {
            _BLDocumento = new BLDocumento();
        }

        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_BLDocumento.GetDocumenti());
        }

        [HttpPost]
        public ObjectResult Post([FromBody] DTODocumentoPost documento)
        {
            return Ok(_BLDocumento.AddDocumento(documento));
        }
    }
}
