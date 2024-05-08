using System.Windows.Forms;
using System.Data.SqlClient;

namespace sqlconnectioncode 
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=34.105.253.161;Initial Catalog=Cardearlership;Persist Security Info=True;User ID=sqlserver;Password=Faris200510;");

            try
            {
                conn.Open();
                MessageBox.Show("Connection established");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
            conn.Close();
        }
    }
}
