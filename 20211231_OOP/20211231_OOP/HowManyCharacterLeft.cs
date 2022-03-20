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
    public partial class HowManyCharacterLeft : Form
    {
        MainForm main = new MainForm();
        int move, moveX, moveY;
        public HowManyCharacterLeft()
        {
            InitializeComponent();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            int characterCount;
            int howManyChar;

            characterCount = tbInput.Text.Length;
            howManyChar = 1000 - characterCount;
            lblCharCount.Text = howManyChar.ToString();

            if (howManyChar <= 0)
            {
                tbInput.ReadOnly = true;
            }
            else
            {
                tbInput.ReadOnly = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            main.Show();
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tbInput.Undo();
        }

        private void HowManyCharacterLeft_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CancelButton = btnCloseForm;
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
