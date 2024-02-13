using BL;
using BL.DTO.DTOArticolo;
using Microsoft.AspNetCore.Mvc;

namespace _20240128_Web_API.Controllers
{
    [ApiController]
    //[ServiceFilter(typeof(WAExceptionFilter))]
    [Route("[controller]")]
    public class ArticoloController : ControllerBase
    {
        private BLArticolo _BLArticolo;

        public ArticoloController()
        {
            _BLArticolo = new BLArticolo();
        }

        [HttpGet]
        public ObjectResult Get(){
            List<_WAArticoloGiacenza> articoli = _BLArticolo.GetArticoli().Select(a => new _WAArticoloGiacenza ( a, _BLArticolo.GetGiacenza(a.Id) )).ToList();

            return Ok(articoli);
        }

        [HttpGet("{id}")]
        public ObjectResult Get(int id)
        {
            return Ok(_BLArticolo.GetArticolo(id));
        }

        [HttpPost]
        public ObjectResult Post([FromBody] DTOArticoloPost articolo)
        {
            return Ok(_BLArticolo.AddArticolo(articolo));
        }
    }

    internal class _WAArticoloGiacenza
    {
        public DTOArticoloGet Articolo { get; set; }
        public double Giacenza {get;set;}

        public _WAArticoloGiacenza(DTOArticoloGet articolo, double giacenza)
        {
            this.Articolo = articolo;
            this.Giacenza = giacenza;
        }
    }
}
