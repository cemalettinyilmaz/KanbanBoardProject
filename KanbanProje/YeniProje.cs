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
    public partial class YeniProje : Form
    {
        bool mouseDown;
        ProjeYoneticisi yonetici;

        public YeniProje(ProjeYoneticisi gelenYonetici)
        {
            InitializeComponent();
            yonetici = gelenYonetici;

        }

        #region Kontroller
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
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
            this.Hide();


        }

        #endregion

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtProjeAdi.Text))
            {

                bool projeOlustuMu = (yonetici.yeniProjeOlustur(txtProjeAdi.Text, txtKullaniciAdi.Text));

                if (projeOlustuMu)
                {
                    MessageBox.Show("Project Created");
                    this.Hide();


                }
                else
                    MessageBox.Show("This project name has been used before. Please enter a new project name.");
            }
            else
                MessageBox.Show("Fill in all fields.");
        }

        private void YeniProje_Load(object sender, EventArgs e)
        {

        }
    }
}
