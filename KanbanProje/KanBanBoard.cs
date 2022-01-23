using Kanboard.Data;
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
        Proje proje;
        public KanBanBoard(Proje gelenProje)
        {
            InitializeComponent();
            proje = gelenProje;
        }
        
        private void KanBanBoard_Load(object sender, EventArgs e)
        {
            Listele();
           
        }

        void Listele()
        {

            foreach (var item in proje.todoList)
            {
                lbTodo.Items.Add(item);
            }
            foreach (var item in proje.doingList)
            {
                lbDoing.Items.Add(item);
            }
            foreach (var item in proje.doneList)
            {
                lbDone.Items.Add(item);
            }


        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            NotEkle notEkleForm = new NotEkle(proje);
            notEkleForm.ShowDialog();
            Listele();
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }
        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }
        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Alinan = sender as ListBox;

            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
          
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
            //TODO BİRAKİLAN ALINAN İSİMLERE GÖRE KONTROL ET VE LİSTELERDEN YAZDIR VE SİLDİR.

            //Notlar transferNotu = (Notlar)listbox_Item_Alinan.Items[Listbox_Index];
            if (lstbox_Item_Birakilan.Name==lbDoing.Name)
            {
            }

        }

      
    }
}
