using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanboard.Data
{
    public class ProjeYoneticisi
    {
        public ProjeYoneticisi()
        {
            Projeler = new List<Proje>();
        }
        public List<Proje> Projeler { get; set; }

        public bool ProjeAdiVarMi(string projeAdi)
        {
            return Projeler.Any(x => x.ProjeAdi == projeAdi);
        }

        public bool yeniProjeOlustur(string projeAdi,string kullaniciAdi)
        {
            if(ProjeAdiVarMi(projeAdi))
            {
                return false;
            }
            else
            {
                Projeler.Add(new Proje()
                {
                    ProjeAdi = projeAdi,
                    Kullanici=kullaniciAdi,

                });
                return true;
            }
        }
        public Proje projeAc(string projeAdi)
        {
            return Projeler.FirstOrDefault(x => x.ProjeAdi == projeAdi);
        }


    }
   
}
