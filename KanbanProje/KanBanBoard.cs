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
        Notlar kopyalananNot;
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
            lbDone.Items.Clear();
            lbDoing.Items.Clear();
            lbTodo.Items.Clear();

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

            if (e.Button == MouseButtons.Right)
            {

                int index = listbox_Item_Alinan.IndexFromPoint(e.Location);

                if (index == listbox_Item_Alinan.SelectedIndex)
                {
                   contextMenuStrip1.Show(MousePosition);
                }
                int index2 =listbox_Item_Alinan.IndexFromPoint(e.Location);
                //if (index2 != listbox_Item_Alinan.NoMatches && kopyalananNot != null)
                //{

                //   contextMenuStrip2.Show(MousePosition);
                //}
                

            }

        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            Notlar transferNotu = (Notlar)listbox_Item_Alinan.Items[Listbox_Index];

            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
           

            if (lstbox_Item_Birakilan.Name == lbDoing.Name)
            {
                proje.doingList.Add(transferNotu);
            }
            else if (lstbox_Item_Birakilan.Name == lbTodo.Name)
            {
                proje.todoList.Add(transferNotu);

            }
            else if (lstbox_Item_Birakilan.Name == lbDone.Name)
            {
                proje.doneList.Add(transferNotu);
            }


            if (listbox_Item_Alinan.Name == lbDoing.Name)
            {
                proje.doingList.Remove(transferNotu);
            }
            else if (listbox_Item_Alinan.Name == lbTodo.Name)
            {
                proje.todoList.Remove(transferNotu);

            }
            else if (listbox_Item_Alinan.Name == lbDone.Name)
            {
                proje.doneList.Remove(transferNotu);
            }

            Listele();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notlar silinecekNot = new Notlar();
            silinecekNot = (Notlar)listbox_Item_Alinan.SelectedItem;
            if (listbox_Item_Alinan.Name == lbDoing.Name)
                proje.doingList.Remove(silinecekNot);
            else if (listbox_Item_Alinan.Name == lbTodo.Name)
                proje.todoList.Remove(silinecekNot);
            else if (listbox_Item_Alinan.Name == lbDone.Name)
                proje.doneList.Remove(silinecekNot);
            Listele();

        }


        private void KanBanBoard_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            kopyalananNot= (Notlar)listbox_Item_Alinan.SelectedItem; 
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kopyalananNot != null)
            {
                if (listbox_Item_Alinan.Name == lbDoing.Name)
                    proje.doingList.Add(kopyalananNot);
                else if (listbox_Item_Alinan.Name == lbTodo.Name)
                    proje.todoList.Add(kopyalananNot);
                else if (listbox_Item_Alinan.Name == lbDone.Name)
                    proje.doneList.Add(kopyalananNot);
                Listele();
            }

        }

        private void lbTodo_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
