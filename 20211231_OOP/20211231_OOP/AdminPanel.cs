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
    public partial class AdminPanel : Form
    {
        int move, moveX, moveY;

        MainForm main = new MainForm();
        SqlDatabase sql = new SqlDatabase();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AcceptButton = btnAdd;
            CancelButton = btnCloseForm;
            this.loginTableTableAdapter.Fill(this.loginDatabaseDataSet.LoginTable);
            DataGridViewSettings(dataGridAdmin);
        }

        #region PanelMove - Minimize - Close - TimerFadeEffect - Back

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql.OpenConnection();
            try
            {
                sql.UserAdd(tbUsername, tbPassword, tbEmail, tbBirthDate);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Value", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.OpenConnection();
            try
            {
                sql.UserDelete(tbID, tbUsername);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Value", "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sql.OpenConnection();
            try
            {
                sql.UserUpdate(tbID,tbUsername, tbPassword, tbEmail, tbBirthDate);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Value", "Error");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            this.Hide();
            admin.ShowDialog();
        }

        private void dataGridAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridAdmin.CurrentRow.Cells[0].Value.ToString();
            tbUsername.Text = dataGridAdmin.CurrentRow.Cells[1].Value.ToString();
            tbPassword.Text = dataGridAdmin.CurrentRow.Cells[2].Value.ToString();
            tbEmail.Text = dataGridAdmin.CurrentRow.Cells[3].Value.ToString();
            tbBirthDate.Text = dataGridAdmin.CurrentRow.Cells[4].Value.ToString();
        }

        void DataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 44, 53);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(150, 146, 190);
            dataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 64, 67);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 44, 53);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowUserToResizeRows = false;
        }
    }
}