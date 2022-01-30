using KanbanProje.Properties;
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
    public partial class AnaPencereForm : Form
    {
        private bool acikMi;
        bool kanbanAcikMi = false;
        bool oyunAcikMi = false;
        private bool mouseDown;
        GirisForm giris;
        Proje proje;
        public AnaPencereForm(Proje gelenProje, GirisForm gelenGiris)
        {
            InitializeComponent();
            proje = gelenProje;
            giris = gelenGiris;
        }
        KanBanBoardForm kanban;
        private void btnKanBan_Click(object sender, EventArgs e)
        {
            if (oyunAcikMi)
                game.Close();
            kanban = new KanBanBoardForm(proje, this);
            kanban.MdiParent = this;
            kanban.Show();
            kanban.Dock = DockStyle.Fill;
            kanbanAcikMi = true;
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
            this.Hide();
            new GirisForm();
            giris.Show();
        }
        private void AnaPencere_Load(object sender, EventArgs e)
        {
            lblProjeAdi.Text = $"Project : {proje.ProjeAdi} User : {proje.Kullanici}";
        }
        TakeABreakGameForm game;
        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (kanbanAcikMi)
                kanban.Close();
            game = new TakeABreakGameForm();
            game.MdiParent = this;
            game.Location = new Point((this.Width - game.Width) / 2, (this.Height - game.Height) / 2);
            game.Show();
        }
    }
}
