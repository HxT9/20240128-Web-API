using AutoMapper;
using BL.DTO.DTOArticolo;
using BL.DTO.DTODocumento;
using BL.DTO.DTORigaDocumento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BL
{
    public class BLDocumento
    {
        DAL.Repository.RepDocumento repDocumento;
        Mapper mapper;

        public BLDocumento()
        {
            repDocumento = new DAL.Repository.RepDocumento();
            mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.CreateMap<DAL.Entities.EDocumento, DTODocumentoGet>();
                cfg.CreateMap<DTODocumentoPost, DAL.Entities.EDocumento>();

                cfg.CreateMap<DAL.Entities.ERigaDocumento, DTORigaDocumentoGet>();
                cfg.CreateMap<DTORigaDocumentoPost, DAL.Entities.ERigaDocumento>()
                    .ForMember(e => e.Articolo, act => act.MapFrom(r => new DAL.Entities.EArticolo { Id = r.ArticoloId }));

                cfg.CreateMap<DAL.Entities.EArticolo, DTOArticoloGet>();
            }));
        }

        public List<DTODocumentoGet> GetDocumenti()
        {
            return mapper.Map<List<DTODocumentoGet>>(repDocumento.GetDocumenti());
        }

        public DTODocumentoGet AddDocumento(DTODocumentoPost documento)
        {
            return mapper.Map<DTODocumentoGet>(repDocumento.AddDocumento(mapper.Map<DAL.Entities.EDocumento>(documento)));
        }
    }
}
