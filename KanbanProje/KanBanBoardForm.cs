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
using Brush = System.Windows.Media.Brush;
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
            rbBlack.Checked = true;
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

        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
                alinanRenk = Color.Black;
            else if (rbBlue.Checked)
                alinanRenk = Color.Blue;
            else if (rbRed.Checked)
                alinanRenk = Color.Red;
            else if (rbYellow.Checked)
                alinanRenk = Color.Purple;
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
        private void lbTodo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                foreach (var item in lbTodo.Items)
                {
                    string selectedItem = lbTodo.Items[e.Index].ToString();
                    Font font = new Font("Txt_IV25", 14);
                    Color gelenRenk = Color.Black;
                    Graphics g = e.Graphics;
                    foreach (var item1 in proje.todoList)
                    {
                        if (selectedItem == item1.NotAdi)
                        {
                            gelenRenk = item1.KategoriRengi;
                        }
                    }
                    SolidBrush solidBrush = new SolidBrush(Color.White);
                    int left = e.Bounds.Left;
                    int top = e.Bounds.Top;
                    e.DrawBackground();
                    g.FillRectangle(new SolidBrush(gelenRenk), e.Bounds);
                    e.Graphics.DrawString(selectedItem, font, solidBrush, left, top);

                }
            }
        }
        private void lbDoing_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                foreach (var item in lbDoing.Items)
                {
                    string selectedItem = lbDoing.Items[e.Index].ToString();
                    Font font = new Font("Txt_IV25", 14);
                    Color gelenRenk = Color.Black;
                    Graphics g = e.Graphics;
                    foreach (var item1 in proje.doingList)
                    {
                        if (selectedItem == item1.NotAdi)
                        {
                            gelenRenk = item1.KategoriRengi;
                        }
                    }
                    SolidBrush solidBrush = new SolidBrush(Color.White);
                    int left = e.Bounds.Left;
                    int top = e.Bounds.Top;
                    e.DrawBackground();
                    g.FillRectangle(new SolidBrush(gelenRenk), e.Bounds);
                    e.Graphics.DrawString(selectedItem, font, solidBrush, left, top);
                }
            }
        }
        private void lbDone_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                foreach (var item in lbDone.Items)
                {
                    string selectedItem = lbDone.Items[e.Index].ToString();
                    Font font = new Font("Txt_IV25", 14);
                    Color gelenRenk = Color.Black;
                    Graphics g = e.Graphics;
                    foreach (var item1 in proje.doneList)
                    {
                        if (selectedItem == item1.NotAdi)
                        {
                            gelenRenk = item1.KategoriRengi;
                        }
                    }
                    SolidBrush solidBrush = new SolidBrush(Color.White);
                    int left = e.Bounds.Left;
                    int top = e.Bounds.Top;
                    e.DrawBackground();
                    g.FillRectangle(new SolidBrush(gelenRenk), e.Bounds);
                    e.Graphics.DrawString(selectedItem, font, solidBrush, left, top);
                }
            }
        }
        private void lbKategoriler_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                foreach (var item in lbKategoriler.Items)
                {
                    string selectedItem = lbKategoriler.Items[e.Index].ToString();
                    Font font = new Font("Txt_IV25", 8);
                    Color gelenRenk = Color.Black;
                    foreach (var item1 in proje.Kategoriler)
                    {
                        if (selectedItem == item1.Kategori)
                        {
                            gelenRenk = item1.KategoriRengi;
                        }
                    }
                    SolidBrush solidBrush = new SolidBrush(gelenRenk);
                    int left = e.Bounds.Left;
                    int top = e.Bounds.Top;
                    e.DrawBackground();
                    e.Graphics.DrawString(selectedItem, font, solidBrush, left, top);
                }
            }
        }
    }
}

