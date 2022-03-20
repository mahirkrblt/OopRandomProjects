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
using Hamburger;

namespace _20211231_OOP
{
    public partial class MainForm : Form
    {
        PictureSize pictureSize = new PictureSize();
        SqlDatabase sql = new SqlDatabase();

        int move, moveX, moveY;
        static bool panelActive = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            panelButtons.Enabled = panelActive;
            this.CenterToScreen();
            AcceptButton = btnLogin;
            CancelButton = btnCloseForm;
        }

        #region Contact Pictureboxes

        #region LinkedIn

        private void pbLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mahir-karabulut/");
        }

        private void pbLinkedIn_MouseEnter(object sender, EventArgs e)
        {
            pictureSize.Picture(pbLinkedIn, 52);
        }

        private void pbLinkedIn_MouseLeave(object sender, EventArgs e)
        {
            pictureSize.Picture(pbLinkedIn, 48);
        }

        #endregion

        #region Mail

        private void pbMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Mailto:mahir.krbltt@gmail.com");
        }
        private void pbMail_MouseEnter(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMail, 52);
        }
        private void pbMail_MouseLeave(object sender, EventArgs e)
        {
            pictureSize.Picture(pbMail, 48);
        }

        #endregion

        #endregion

        #region Form Move


        #endregion

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //sql.Login(tbUsername, tbPassword);
            //if (sql.Dtbl.Rows.Count == 1)
            //{

            if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                panelActive = true;
                panelButtons.Enabled = true;
                lblHelloWorld.Location = new Point(65, 12);
                lblHelloWorld.Text = "WELCOME\n" + tbUsername.Text;
                btnAdminPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Check your username or password");
                panelButtons.Enabled = false;
                btnAdminPanel.Visible = false;
                lblHelloWorld.Location = new Point(65, 50);
                lblHelloWorld.Text = "HELLO WORLD";
            }
            //}

        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnHowOldIAm_Click(object sender, EventArgs e)
        {
            AgeCalculator ageCalculator = new AgeCalculator();
            ageCalculator.Show();
            this.Hide();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
            this.Hide();
        }

        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            AbsoluteValue absolute = new AbsoluteValue();
            absolute.Show();
            this.Hide();
        }

        private void btnCharacterLeft_Click(object sender, EventArgs e)
        {
            HowManyCharacterLeft characterLeft = new HowManyCharacterLeft();
            characterLeft.Show();
            this.Hide();
        }
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
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

        private void btnPasswordChar_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = default;
        }

        private void btnPasswordChar_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void btnCannon_Click(object sender, EventArgs e)
        {
            CannonBall cannon = new CannonBall();
            cannon.Show();
            this.Hide();
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            //Hamburger hamburger = new Hamburger();
            //hamburger.Show();
            HamburgerForm hamburgerForm = new HamburgerForm();
            hamburgerForm.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.Show();
            this.Hide();
        }
    }
}
