using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kanboard.Data
{
    public class Proje
    {
        public Proje()
        {
            todoList = new List<Notlar>();
            doingList = new List<Notlar>();
            doneList = new List<Notlar>();
            Kategoriler= new List<Notlar>();

        }
        public string ProjeAdi { get; set; }
        public string Kullanici { get; set; }

        public List<Notlar> todoList { get; set; }
        public List<Notlar> doingList { get; set; }
        public List<Notlar> doneList { get; set; }

        public List<Notlar> Kategoriler { get; set; }

        public bool NotEkle(string notAdi, string kategori, string not)
        {
            todoList.Add(new Notlar()
            {
                NotAdi = notAdi,
                Kategori = kategori,
                BirakilanNot = not

            }); ;
            return true;
        }

        public bool KategoriEkle(string kategoriAdi,Color color)
        {
            Kategoriler.Add(new Notlar()
            {
                Kategori = kategoriAdi,
                KategoriRengi = color


            } );

            return true;
        }

    }
}
