using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _20211231_OOP
{
    public partial class CannonBall : Form
    {
        PictureSize pictureSize = new PictureSize();
        Sound sound = new Sound();
        Random random = new Random();
        MainForm main = new MainForm();

        int move, moveX, moveY;
        int fireCount = 0;
        int random1 = 0, random2 = 0, random3 = 0;

        public CannonBall()
        {
            InitializeComponent();
        }

        private void CannonBall_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            random1 = random.Next(1, 4);
            random2 = random.Next(5, 9);
            random3 = random.Next(10, 15);
        }

        #region PanelMove - Minimize - Exit - TimerFadeEffect - Back

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
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

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMinimize, 95);
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMinimize, 90);
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            pictureSize.Picture(pbExit, 95);
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pictureSize.Picture(pbExit, 90);
        }

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

        private void pbMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return to the main menu?", "Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                main.Show();
                this.Close();
            }       
        }

        private void pbMainMenu_MouseEnter(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMainMenu, 105);
        }

        private void pbMainMenu_MouseLeave(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMainMenu, 100);
        }

        #endregion

        private void btnFire_Click(object sender, EventArgs e)
        {
            Fire();
        }

        private void btnFire_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressAmmo.Value != progressAmmo.Minimum) { pbExplosion.Visible = true; }
        }


        private void btnFire_MouseUp(object sender, MouseEventArgs e)
        {
            pbExplosion.Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            sound.Play(@"C:\Users\Mahir\source\repos\20211231_OOP\20211231_OOP\Sounds\cannonReload.wav");

            progressAmmo.Value = progressAmmo.Maximum;
            lblAmmo.Text = (progressAmmo.Value / 10).ToString();
        }

        void Fire()
        {
            if (progressAmmo.Value == progressAmmo.Minimum)
            {
                MessageBox.Show("Press reload", "No ammo");
            }
            else
            {
                sound.Play(@"C:\Users\Mahir\source\repos\20211231_OOP\20211231_OOP\Sounds\cannonBallSound.wav");

                progressAmmo.Value -= 10;
                lblAmmo.Text = (progressAmmo.Value / 10).ToString();

                Shake(this);

                fireCount++;
                if (fireCount == random1) { pbFire1.Visible = true; }
                else if (fireCount == random2) { pbFire2.Visible = true; }
                else if (fireCount == random3) { pbFire3.Visible = true; }
            }
        }

        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(15);
            }
            form.Location = original;
        }
    }
}
