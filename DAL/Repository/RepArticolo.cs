using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepArticolo
    {
        public List<EArticolo> GetArticoli()
        {
            using (var context = new ApplicationContext())
            {
                return context.Articolo.ToList();
            }
        }

        public EArticolo AddArticolo(EArticolo articolo)
        {
            using (var context = new ApplicationContext())
            {
                context.Articolo.Add(articolo);
                context.SaveChanges();
                return articolo;
            }
        }

        public double GetGiacenza(int id)
        {
            using (var context = new ApplicationContext())
            {
                return context.Documento.Include(d => d.Righe).ThenInclude(r => r.Articolo)
                    .SelectMany(d => d.Righe)
                    .Where(r => r.Articolo.Id == id)
                    .Sum(r => r.TipoMovimento == TipoMovimento.Carico ? r.Quantita : r.Quantita * -1);
            }
        }

        public EArticolo? GetArticolo(int id = 0, string codice = "")
        {
            using (var context = new ApplicationContext())
            {
                return context.Articolo.Where(a => a.Id == id || a.Codice == codice).OrderBy(a => Math.Abs((int)(a.Id - id))).ThenBy(a => a.Codice).FirstOrDefault();
            }
        }
    }
}
