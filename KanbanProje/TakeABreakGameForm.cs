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
    public partial class TakeABreakGameForm : Form
    {
        public TakeABreakGameForm()
        {
            InitializeComponent();
        }
        int puan = 0;
        bool basladiMi = false;
        int level = 1;
        int kalanDakika = 15;
        Random rnd = new Random();
        int hiz = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPuan.Text = "Score : 0\r\n Level : 1";
            timer2.Start();
            timer3.Start();
            lblKalanSure.Text = $"After {kalanDakika} minutes, the break is over.";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 25;
            if (pictureBox1.Top > 0)
            {
                pictureBox1.Top = -169;
            }
            pictureBox3.Top += hiz;
            if (pictureBox3.Top > this.Bottom)
            {
                pictureBox3.Top = -10;
                pictureBox3.Left = rnd.Next(label2.Right, label1.Left - pictureBox3.Width);

                int rastgele = rnd.Next(0, 3);
                switch (rastgele)
                {
                    case 0:
                        pictureBox3.Image = Properties.Resources._1;
                        break;
                    case 1:
                        pictureBox3.Image = Properties.Resources._2;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources._3;
                        break;
                    default:
                        break;
                }
                if (pictureBox2.Top > pictureBox3.Top)
                {
                    puan++;
                    lblPuan.Text = "Score : " + puan.ToString() + "\r\nLevel : " + level.ToString();
                }
                if (puan % 10 == 0)
                {
                    hiz += 8;
                    level++;
                }
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox2.Image = Properties.Resources.boom;
                pictureBox3.Image = Properties.Resources.boom;
                timer1.Stop();
                MessageBox.Show("Score: " + puan.ToString());
                Reset();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && label2.Right < pictureBox2.Left)
            {
                pictureBox2.Left -= 15;
            }
            else if (e.KeyCode == Keys.D && label1.Left > pictureBox2.Right)
            {
                pictureBox2.Left += 15;
            }
            if (e.KeyCode == Keys.Space && basladiMi == false)
            {
                timer1.Start();
                basladiMi = true;
                lblSpace.Text = "";
                lblA.Text = "";
                lblD.Text = "";
            }
        }
        void Reset()
        {
            puan = 0;
            level = 1;
            hiz = 20;
            timer1.Stop();
            basladiMi = false;
            pictureBox2.Image = Properties.Resources._3;
            pictureBox3.Image = Properties.Resources._1;
            pictureBox3.Location = new Point(70, -76);
            pictureBox2.Location = new Point(84, 302);
            lblSpace.Text = "Press Space";
            lblA.Text = "<=A";
            lblD.Text = "D=>";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            kalanDakika -= 1;
            lblKalanSure.Text = $"After {kalanDakika} minutes, the break is over.";
        }
    }
}

