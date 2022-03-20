using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20211231_OOP
{
    public partial class SignUp : Form
    {

        SqlDatabase sql = new SqlDatabase();
        int move, moveX, moveY;
        MainForm main = new MainForm();

        public SignUp()
        {
            InitializeComponent();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                MessageBox.Show("Please fill mandatory field");
            else if (tbPassword.Text != tbPasswordRetry.Text)
                MessageBox.Show("Password do not match");
            else
            {
                sql.OpenConnection();
                sql.UserAdd(tbUsername, tbPassword, tbMail, tbBirthDate);
                MessageBox.Show("Registration is successfull");
                this.Close();
                main.Show();
            }
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

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AcceptButton = btnSignUp;
            CancelButton = btnCloseForm;
        }

        private void btnPasswordChar_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = default;
            tbPasswordRetry.PasswordChar = default;
        }

        private void btnPasswordChar_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
            tbPasswordRetry.PasswordChar = '*';
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            timerFadeEffect.Start();
        }

        private void btnSignUpBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}
