using System.Data.SqlClient;

namespace Lec1Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Northwind;"
        + "Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}