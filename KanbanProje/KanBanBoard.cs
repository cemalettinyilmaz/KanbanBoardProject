using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanProje
{
    public partial class KanBanBoard : Form
    {
        public KanBanBoard()
        {
            InitializeComponent();
        }
        List<string> liste=new List<string>();
        private void KanBanBoard_Load(object sender, EventArgs e)
        {
            liste.Add("Cemalettin YIlmaz");
            lbTodo.DataSource = liste;
           
        }
    }
}
