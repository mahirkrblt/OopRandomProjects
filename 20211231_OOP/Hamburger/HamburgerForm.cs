using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class HamburgerForm : Form
    {
        int move, moveX, moveY;

        public HamburgerForm()
        {
            InitializeComponent();
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox1.Refresh();
        }

        #region Panel Move - TimerFadeEffect - Close - Minimize

        private void timerFadeEffect_Tick(object sender, EventArgs e)
        {
            timerFadeEffect.Interval = 25;

            if (this.Opacity > 0)
            {
                this.Opacity -= 0.035;
            }
            else
            {
                timerFadeEffect.Stop();
                Application.Exit();
            }
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            bool sayac = false;
            for (int i = 0; ; )
            {
                if (progressBar1.Right == pictureBox1.Right)
                {
                    sayac = true;
                }
                else if (progressBar1.Left == pictureBox1.Left)
                {
                    sayac = false;
                }

                if (progressBar1.Value!= progressBar1.Maximum)
                {
                    progressBar1.Value++;
                }
               
                if (i%1 == 0)
                {
                    if (sayac)
                    {
                        //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                        pictureBox1.Refresh();
                        pictureBox1.Left--;
                    }
                    else
                    {
                        pictureBox1.Left++;
                        pictureBox1.Refresh();
                    }
                }
            }     
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        #endregion
    }
}