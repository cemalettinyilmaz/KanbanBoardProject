using KanbanProje.Properties;
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
    public partial class AnaPencere : Form
    {
        private bool acikMi;
        private bool mouseDown;
        public AnaPencere()
        {
            InitializeComponent();
            kanban.MdiParent = this;
        }
        KanBanBoard kanban = new KanBanBoard();
        private void btnKanBan_Click(object sender, EventArgs e)
        {
            kanban.Show();
            timer1.Start();
        }

        #region Kontroller

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acikMi)
            {
                button1.Image = Resources.arrow2;
                pnlDropDown.Height += 10;
                if (pnlDropDown.Size == pnlDropDown.MaximumSize)
                {
                    timer1.Stop();
                    acikMi = false;

                }
            }
            else
            {
                button1.Image = Resources.arrow;
                pnlDropDown.Height -= 10;
                if (pnlDropDown.Size == pnlDropDown.MinimumSize)
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mouseX = MousePosition.X - 500;
                int mouseY = MousePosition.Y - 20;
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This program was designed by Cemalettin Yılmaz. BilgeAdamBoost is a project given in the software developer training program. ");
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
