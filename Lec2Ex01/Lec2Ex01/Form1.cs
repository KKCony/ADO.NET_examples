using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2Ex01
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
            String res = (String)sqlCommand1.ExecuteScalar();
            txtProduct.Text = res;
            sqlConnection1.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlCommand1.Parameters["@price"].Value = Convert.ToDecimal(txtPrice.Text);
            txtResult.Text = (String)sqlCommand1.ExecuteScalar();
            sqlConnection1.Close();
        }
    }
}
