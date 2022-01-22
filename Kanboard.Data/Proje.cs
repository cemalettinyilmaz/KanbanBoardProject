using System;
using System.Collections.Generic;
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
            
        }
        public string ProjeAdi { get; set; }
        public string Kullanici { get; set; }

        public List<Notlar> todoList { get; set; }
        public List<Notlar> doingList { get; set; }
        public List<Notlar> doneList { get; set; }
        
        public bool NotEkle(string notAdi,string kategori,string not)
        {
            todoList.Add(new Notlar()
            {
                NotAdi = notAdi,
                Kategori = kategori,
                BirakilanNot = not

            }); ;
            return true;
        }

    }
}
