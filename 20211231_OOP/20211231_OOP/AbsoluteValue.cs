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
    public partial class AbsoluteValue : Form
    {
        MainForm main = new MainForm();
        int move, moveX, moveY;
        public AbsoluteValue()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void btnAbsoluteCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num = Convert.ToInt32(tbAbsoluteValue.Text);
                decimal absoluteValue;
                absoluteValue = (num < 0) ? -1 * num : num;
                lblAbsolute.Text = absoluteValue.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please just enter number", "ERROR!");
            }
        }

        private void btnAbsolueMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAbsoluteClose_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
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

        private void AbsoluteValue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AcceptButton = btnAbsoluteCalculate;
            CancelButton = btnCloseForm;
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
    }
}