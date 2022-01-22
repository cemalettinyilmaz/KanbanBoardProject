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
    public partial class NotEkle : Form
    {
        bool mouseDown;
        Proje proje;
        public NotEkle(Proje gelenProje)
        {
            InitializeComponent();
            proje = gelenProje;
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

        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            int u = 140-txtNot.TextLength;
            lblKalan.Text = u.ToString();

        }

        private void NotEkle_Load(object sender, EventArgs e)
        {
            txtNot.MaxLength = 140;
            lblKalan.Text = 140.ToString();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNotAdi.Text) || string.IsNullOrEmpty(txtNot.Text) || string.IsNullOrEmpty(txtKategori.Text))
            {
                MessageBox.Show("Fill in all fields.");
            }
            else
            {
                proje.NotEkle(txtNotAdi.Text,txtKategori.Text,txtNot.Text);
                MessageBox.Show("Note added.");
                txtKategori.Clear();
                txtNot.Clear();
                txtNotAdi.Clear();
            }
        }
    }
}
