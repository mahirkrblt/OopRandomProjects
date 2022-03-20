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
    public partial class Calculator : Form
    {
        MainForm main = new MainForm();
        int move, moveX, moveY;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal plus = Convert.ToInt32(tbNum1.Text) + Convert.ToInt32(tbNum2.Text);
                MessageBox.Show(plus.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal minus = Convert.ToInt32(tbNum1.Text) - Convert.ToInt32(tbNum2.Text);
                MessageBox.Show(minus.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                decimal multiply = Convert.ToInt32(tbNum1.Text) * Convert.ToInt32(tbNum2.Text);
                MessageBox.Show(multiply.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                decimal divide = Convert.ToInt32(tbNum1.Text) / Convert.ToInt32(tbNum2.Text);
                MessageBox.Show(divide.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
            }
        }

        private void btnMinimizeCalculator_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
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

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AcceptButton = btnPlus;
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
