using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211231_OOP
{
    public partial class AgeCalculator : Form
    {
        MainForm main = new MainForm();
        int move, moveX, moveY;
        public AgeCalculator()
        {
            InitializeComponent();
        }
        private void AgeCalculator_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            this.CenterToScreen();
            AcceptButton = btnAgeCalculate;
            CancelButton = btnCloseForm;
        }

        private void btnAgeCalculate_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - dtpAgeCalculate.Value.Year;

            if (dtpAgeCalculate.Value > today.AddYears(-age)) age--;

            MessageBox.Show("Your age: " + age.ToString());
        }

        private void btnAgeCalculatorBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }


        #region Close Minimize TimerFade

        private void btnAbsolueMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
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

        #endregion

        #region PanelMove

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
        #endregion

    }
}