using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _20211231_OOP
{
    class SqlDatabase
    {
        private string ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDb;Initial Catalog=LoginDatabase;Integrated Security=True";

        private SqlConnection con;
        private SqlDataAdapter da;

        private DataTable _dtbl;
        public DataTable Dtbl { get { return _dtbl; } set { _dtbl = value; } } 

        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public object DataReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object DataAdapter(string query)
        {
            da = new SqlDataAdapter(query, con);
            return da;
        }

        public object DataGridView(string query)
        {
            SqlDataAdapter dr = new SqlDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public object DataTable(string query)
        {
            da = new SqlDataAdapter(query, con);
            Dtbl = new DataTable();
            da.Fill(Dtbl);
            return da;
        }

        public void UserAdd(TextBox userName, TextBox password, TextBox mail, TextBox birthDate)
        {
            SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Username", userName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Password", password.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Email", mail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@BirthDate", birthDate.Text.Trim());
            sqlCmd.ExecuteNonQuery();
        }

        public void UserDelete(TextBox id)
        {
            SqlCommand sqlCmd = new SqlCommand("UserDelete", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id", id.Text.Trim());
            sqlCmd.ExecuteNonQuery();
        }

        public void UserDelete(TextBox id, TextBox userName)
        {
            SqlCommand sqlCmd = new SqlCommand("UserDelete", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id", id.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Username", userName.Text.Trim());
            sqlCmd.ExecuteNonQuery();
        }

        public void UserUpdate(TextBox id,TextBox userName, TextBox password,TextBox mail,TextBox birthDate)
        {
            SqlCommand sqlCmd = new SqlCommand("UserUpdate", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ID", id.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Username", userName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Password", password.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Email", mail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@BirthDate", birthDate.Text.Trim());
            sqlCmd.ExecuteNonQuery();
        }

        public void Login(TextBox userName, TextBox password)
        {
            OpenConnection();
            DataTable("SELECT * FROM LoginTable WHERE Username = '" + userName.Text.Trim() + "' and Password = '" + password.Text.Trim() + "'");
        }
    }
}