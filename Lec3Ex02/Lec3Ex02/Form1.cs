using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec3Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlTransaction trans = sqlConnection1.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection1;
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = "DELETE [Order Details] WHERE ProductID = 42";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE Product WHERE ProductID = 42";

                cmd.ExecuteNonQuery();

                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
