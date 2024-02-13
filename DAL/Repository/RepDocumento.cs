using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepDocumento
    {
        public List<EDocumento> GetDocumenti()
        {
            using (var context = new ApplicationContext())
            {
                return context.Documento.Include(d => d.Righe).ThenInclude(r => r.Articolo).ToList();
            }
        }

        public EDocumento AddDocumento(EDocumento documento)
        {
            using (var context = new ApplicationContext())
            {
                foreach(ERigaDocumento riga in documento.Righe)
                {
                    riga.Articolo = context.Articolo.Find(riga.Articolo.Id);
                }
                context.Documento.Add(documento);
                context.SaveChanges();
                return documento;
            }
        }
    }
}
