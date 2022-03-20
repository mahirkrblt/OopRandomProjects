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
    public partial class Exam : Form
    {
        MainForm main = new MainForm();
        int move, moveX, moveY;

        public Exam()
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AcceptButton = btnCalculate;
            CancelButton = btnCloseForm;
            LessonCountNotVisible();
        }

        #region Close - Minimize - TimerFadeEffect - Back - PanelMove

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

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


        private void btnCalculate_Click(object sender, EventArgs e)
        {


        }

        private void tbLessonCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLessonCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LessonCountVisible(Convert.ToInt32(cbLessonCount.SelectedItem));
        }

        public void LessonCountVisible(int count)
        {
            switch (count)
            {
                case 1:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = false;
                    cbLetter2.Visible = false;
                    cbUnit2.Visible = false;
                    tbLessonName3.Visible = false;
                    cbLetter3.Visible = false;
                    cbUnit3.Visible = false;
                    tbLessonName4.Visible = false;
                    cbLetter4.Visible = false;
                    cbUnit4.Visible = false;
                    tbLessonName5.Visible = false;
                    cbLetter5.Visible = false;
                    cbUnit5.Visible = false;
                    tbLessonName6.Visible = false;
                    cbLetter6.Visible = false;
                    cbUnit6.Visible = false;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 2:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = false;
                    cbLetter3.Visible = false;
                    cbUnit3.Visible = false;
                    tbLessonName4.Visible = false;
                    cbLetter4.Visible = false;
                    cbUnit4.Visible = false;
                    tbLessonName5.Visible = false;
                    cbLetter5.Visible = false;
                    cbUnit5.Visible = false;
                    tbLessonName6.Visible = false;
                    cbLetter6.Visible = false;
                    cbUnit6.Visible = false;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 3:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = false;
                    cbLetter4.Visible = false;
                    cbUnit4.Visible = false;
                    tbLessonName5.Visible = false;
                    cbLetter5.Visible = false;
                    cbUnit5.Visible = false;
                    tbLessonName6.Visible = false;
                    cbLetter6.Visible = false;
                    cbUnit6.Visible = false;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 4:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = true;
                    cbLetter4.Visible = true;
                    cbUnit4.Visible = true;
                    tbLessonName5.Visible = false;
                    cbLetter5.Visible = false;
                    cbUnit5.Visible = false;
                    tbLessonName6.Visible = false;
                    cbLetter6.Visible = false;
                    cbUnit6.Visible = false;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 5:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = true;
                    cbLetter4.Visible = true;
                    cbUnit4.Visible = true;
                    tbLessonName5.Visible = true;
                    cbLetter5.Visible = true;
                    cbUnit5.Visible = true;
                    tbLessonName6.Visible = false;
                    cbLetter6.Visible = false;
                    cbUnit6.Visible = false;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 6:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = true;
                    cbLetter4.Visible = true;
                    cbUnit4.Visible = true;
                    tbLessonName5.Visible = true;
                    cbLetter5.Visible = true;
                    cbUnit5.Visible = true;
                    tbLessonName6.Visible = true;
                    cbLetter6.Visible = true;
                    cbUnit6.Visible = true;
                    tbLessonName7.Visible = false;
                    cbLetter7.Visible = false;
                    cbUnit7.Visible = false;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 7:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = true;
                    cbLetter4.Visible = true;
                    cbUnit4.Visible = true;
                    tbLessonName5.Visible = true;
                    cbLetter5.Visible = true;
                    cbUnit5.Visible = true;
                    tbLessonName6.Visible = true;
                    cbLetter6.Visible = true;
                    cbUnit6.Visible = true;
                    tbLessonName7.Visible = true;
                    cbLetter7.Visible = true;
                    cbUnit7.Visible = true;
                    tbLessonName8.Visible = false;
                    cbLetter8.Visible = false;
                    cbUnit8.Visible = false;
                    break;
                case 8:
                    tbLessonName1.Visible = true;
                    cbLetter1.Visible = true;
                    cbUnit1.Visible = true;
                    tbLessonName2.Visible = true;
                    cbLetter2.Visible = true;
                    cbUnit2.Visible = true;
                    tbLessonName3.Visible = true;
                    cbLetter3.Visible = true;
                    cbUnit3.Visible = true;
                    tbLessonName4.Visible = true;
                    cbLetter4.Visible = true;
                    cbUnit4.Visible = true;
                    tbLessonName5.Visible = true;
                    cbLetter5.Visible = true;
                    cbUnit5.Visible = true;
                    tbLessonName6.Visible = true;
                    cbLetter6.Visible = true;
                    cbUnit6.Visible = true;
                    tbLessonName7.Visible = true;
                    cbLetter7.Visible = true;
                    cbUnit7.Visible = true;
                    tbLessonName8.Visible = true;
                    cbLetter8.Visible = true;
                    cbUnit8.Visible = true;
                    break;
            }
        }

        public void LessonCountNotVisible()
        {
            tbLessonName1.Visible = false;
            cbLetter1.Visible = false;
            cbUnit1.Visible = false;
            tbLessonName2.Visible = false;
            cbLetter2.Visible = false;
            cbUnit2.Visible = false;
            tbLessonName3.Visible = false;
            cbLetter3.Visible = false;
            cbUnit3.Visible = false;
            tbLessonName4.Visible = false;
            cbLetter4.Visible = false;
            cbUnit4.Visible = false;
            tbLessonName5.Visible = false;
            cbLetter5.Visible = false;
            cbUnit5.Visible = false;
            tbLessonName6.Visible = false;
            cbLetter6.Visible = false;
            cbUnit6.Visible = false;
            tbLessonName7.Visible = false;
            cbLetter7.Visible = false;
            cbUnit7.Visible = false;
            tbLessonName8.Visible = false;
            cbLetter8.Visible = false;
            cbUnit8.Visible = false;
        }

        public double CalculateLetter(ComboBox comboBox)
        {
            double note = 0;

            if (comboBox.SelectedItem == "AA")
            {
                note = 4.00;
            }
            else if (comboBox.SelectedItem == "AB")
            {
                note = 3.70;
            }
            else if (comboBox.SelectedItem == "BA")
            {
                note = 3.50;
            }
            else if (comboBox.SelectedItem == "BB")
            {
                note = 3.00;
            }
            else if (comboBox.SelectedItem == "CB")
            {
                note = 2.50;
            }
            else if (comboBox.SelectedItem == "CC")
            {
                note = 2.00;
            }
            else if (comboBox.SelectedItem == "DC")
            {
                note = 1.50;
            }
            else if (comboBox.SelectedItem == "DD")
            {
                note = 1.00;
            }
            else if (comboBox.SelectedItem == "FD")
            {
                note = 0.50;
            }
            else if (comboBox.SelectedItem == "FF")
            {
                note = 0.00;
            }

            return note;
        }

        public double CalculateUnits(ComboBox comboBox)
        {
            double num;
            num = (double)comboBox.SelectedItem;
            return num;
        }
    }
}