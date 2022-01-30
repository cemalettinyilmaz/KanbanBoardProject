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
    public partial class NotGoruntuleForm : Form
    {
        bool mouseDown;
        Notlar not;
        public NotGoruntuleForm(Notlar gelenNot)
        {
            InitializeComponent();
            not = gelenNot;
        }

        private void NotGoruntule_Load(object sender, EventArgs e)
        {
            txtNotName.Text = not.NotAdi;
            txtCategory.Text = not.Kategori;
            txtNote.Text = not.BirakilanNot;
            
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mouseX = MousePosition.X-600;
                int mouseY = MousePosition.Y-300;
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
    }
}
