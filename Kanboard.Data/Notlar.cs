using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Kanboard.Data
{
    public class Notlar
    {
        public string NotAdi { get; set; }
        public string BirakilanNot { get; set; }
        public string Kategori { get; set; }
        public Color KategoriRengi { get; set; }

        public override string ToString()
        {
            return NotAdi;
        }
    }


}
