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
    public partial class Giris : Form
    {
        bool mouseDown; 
        public Giris()
        {
            InitializeComponent();
            projeListe = projeYonetici.Projeler;
        }
        ProjeYoneticisi projeYonetici=new ProjeYoneticisi();
        List<Proje> projeListe;
        Proje proje;

        #region Kontroller
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                int mouseX = MousePosition.X - 200;
                int mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnYeniProje_Click(object sender, EventArgs e)
        {
            YeniProje yeniProje = new YeniProje(projeYonetici);
            yeniProje.ShowDialog();
            comboboxDuzenle();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbProjeler.Text))
                MessageBox.Show("Select a project.");
            else
            {
                proje = projeYonetici.projeAc(cmbProjeler.Text);
                AnaPencere anaPencere = new AnaPencere(proje,this);
                anaPencere.Show();
                this.Hide();
            }
        }
        
        private void Giris_Load(object sender, EventArgs e)
        {
           
           
            
        }

        public void comboboxDuzenle()
        {
            foreach (var item in projeListe)
            {
                cmbProjeler.Items.Add(item.ProjeAdi);
            }

        }
    }
}
