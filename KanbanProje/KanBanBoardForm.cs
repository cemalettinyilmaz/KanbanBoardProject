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
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;
using Color = System.Drawing.Color;

namespace KanbanProje
{
    public partial class KanBanBoardForm : Form
    {
        Proje proje;
        Notlar kopyalananNot;
        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;
        AnaPencereForm anaForm;
        public KanBanBoardForm(Proje gelenProje, AnaPencereForm gelenForm)
        {
            InitializeComponent();
            proje = gelenProje;
            anaForm = gelenForm;
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
            lbKategoriler.Items.Clear();
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
            foreach (var item in proje.Kategoriler)
            {
                lbKategoriler.Items.Add(item.Kategori);
            }

        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            NotEkleForm notEkleForm = new NotEkleForm(proje);
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
            }
            int secilenIndex = listbox_Item_Alinan.IndexFromPoint(e.X, e.Y);
            listbox_Item_Alinan.SelectedIndex = secilenIndex;
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
            if (silinecekNot != null)
            {
                if (listbox_Item_Alinan.Name == lbDoing.Name)
                    proje.doingList.Remove(silinecekNot);
                else if (listbox_Item_Alinan.Name == lbTodo.Name)
                    proje.todoList.Remove(silinecekNot);
                else if (listbox_Item_Alinan.Name == lbDone.Name)
                    proje.doneList.Remove(silinecekNot);
            }
            Listele();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listbox_Item_Alinan.SelectedIndex > -1)
                kopyalananNot = (Notlar)listbox_Item_Alinan.SelectedItem;
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
        bool acikMi;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acikMi)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    acikMi = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    acikMi = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Color alinanRenk;
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            alinanRenk = colorDialog1.Color;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (proje.KategoriEkle(txtKategoriAdi.Text, alinanRenk))
                MessageBox.Show("Category added.");
            Listele();
        }

        private void showNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notlar goruntulenecekNot = new Notlar();
            goruntulenecekNot = (Notlar)listbox_Item_Alinan.SelectedItem;
            if (goruntulenecekNot != null)
            {
                NotGoruntuleForm gorutulenecekForm = new NotGoruntuleForm(goruntulenecekNot);
                gorutulenecekForm.MdiParent = anaForm;
                gorutulenecekForm.Show();
            }

        }

        private void lbTodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTodo_MouseClick(object sender, MouseEventArgs e)
        {

            //if (e.Button == MouseButtons.Right)
            //{
            //    Point kor_nokta = new Point(e.X, e.Y);
            //    Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            //    if (Listbox_Index > 0)
            //        listbox_Item_Alinan.SelectedItem = listbox_Item_Alinan.Items[Listbox_Index];

            //   // listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
            //}
        }
    }
}

