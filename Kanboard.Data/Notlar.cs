using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanboard.Data
{
    public class Notlar
    {
        public string NotAdi { get; set; }
        public string BirakilanNot { get; set; }
        public string Kategori { get; set; }

        public override string ToString()
        {
            return NotAdi;
        }

    }
    
    
}
