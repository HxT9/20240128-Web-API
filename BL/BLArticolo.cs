using AutoMapper;
using BL.DTO.DTOArticolo;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BL
{
    public class BLArticolo
    {
        DAL.Repository.RepArticolo repArticolo;
        Mapper mapper;

        public BLArticolo()
        {
            repArticolo = new DAL.Repository.RepArticolo();
            mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.CreateMap<DAL.Entities.EArticolo, DTOArticoloGet>();
                cfg.CreateMap<DTOArticoloPost, DAL.Entities.EArticolo>();
                }));
        }

        public List<DTOArticoloGet> GetArticoli()
        {
            return mapper.Map<List<DTOArticoloGet>>(repArticolo.GetArticoli());
        }

        public DTOArticoloGet GetArticolo(int id)
        {
            return mapper.Map<DTOArticoloGet>(repArticolo.GetArticolo(id: id));
        }

        public DTOArticoloGet AddArticolo(DTOArticoloPost articolo)
        {
            if (repArticolo.GetArticolo(codice: articolo.Codice) == default)
                return mapper.Map<DTOArticoloGet>(repArticolo.AddArticolo(mapper.Map<DAL.Entities.EArticolo>(articolo)));

            throw new AlreadyExistsException("Articolo già presente");
        }

        public double GetGiacenza(int id)
        {
            return repArticolo.GetGiacenza(id);
        }
    }
}
