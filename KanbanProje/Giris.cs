using Kanboard.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanProje
{
    public partial class Giris : Form
    {
        bool mouseDown;
        ProjeYoneticisi projeYonetici;
        public Giris()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText("veri.json");
                projeYonetici = JsonConvert.DeserializeObject<ProjeYoneticisi>(json);

            }
            catch (Exception)
            {

                projeYonetici = new ProjeYoneticisi();
            }
            projeListe = projeYonetici.Projeler;
            comboboxDuzenle();
        }
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
            cmbProjeler.Items.Clear();
            foreach (var item in projeListe)
            {
                cmbProjeler.Items.Add(item.ProjeAdi);
            }

        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(projeYonetici);
            File.WriteAllText("veri.json", json);
        }
    }
}
