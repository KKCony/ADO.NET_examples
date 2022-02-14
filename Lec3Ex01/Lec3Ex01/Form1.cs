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

namespace Lec3Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "dbo.CountProductsInCategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            SqlParameter param = cmd.Parameters.Add(
                    new SqlParameter("@CatID", SqlDbType.Int, 4));
            param = cmd.Parameters.Add(
                    new SqlParameter("@CatName", SqlDbType.NChar, 15));
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4));
            cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters["@CatID"].Value = Convert.ToInt32(textBox1.Text);
            sqlConnection1.Open();
            cmd.ExecuteScalar(); // could use any ExecuteX method
            sqlConnection1.Close();

            MessageBox.Show("Category name: " +
                            cmd.Parameters["@CatName"].Value +
                            "Number of products in category: " +
                            cmd.Parameters["@RETURN_VALUE"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmdProducts = new SqlCommand(
            "SELECT ProductName, UnitsInStock " +
             "FROM Products", sqlConnection1);

            sqlConnection1.Open();

            SqlDataReader rdrProducts;

            rdrProducts = cmdProducts.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdrProducts.Read())
            {
                listBox1.Items.Add(rdrProducts.GetString(0) +
                      "\t" + rdrProducts.GetInt16(1));
            }
            rdrProducts.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "dbo.AdjustProductAvailability";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            SqlDataReader rdrProducts;

            sqlConnection1.Open();

            rdrProducts = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdrProducts.Read())
            {
                lstProducts.Items.Add(rdrProducts.GetString(0));
            }

            rdrProducts.NextResult();

            while (rdrProducts.Read())
            {
                lstDiscontinued.Items.Add(rdrProducts.GetString(0));
            }

            MessageBox.Show("Products affected: " +
                rdrProducts.RecordsAffected);

            rdrProducts.Close();
        }
    }
}
