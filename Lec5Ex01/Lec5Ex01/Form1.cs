using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec5Ex01
{
    public partial class Form1 : Form
    {
        private const string PurchaseSchema =
                                @"C:\ADO .NET\202202\Workspace\Lec5Ex01\Lec5Ex01\PersonPet.xsd";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet1.Products);

        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1 = new DataSet();
                Console.WriteLine("Reading the Schema file");
                dataSet1.ReadXmlSchema(PurchaseSchema);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        private void btnPrintModel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Table structure");

            //Print the number of tables 
            Console.WriteLine("Tables count=" + dataSet1.Tables.Count.ToString());

            //Print the table and column names

            for (int i = 0; i < dataSet1.Tables.Count; i++)
            {
                //Print the table names
                Console.WriteLine("TableName='" + dataSet1.Tables[i].TableName + "'.");
                Console.WriteLine("Columns count=" + dataSet1.Tables[i].Columns.Count.ToString());

                for (int j = 0; j < dataSet1.Tables[i].Columns.Count; j++)
                {
                    //Print the column names and data types    
                    Console.WriteLine("\t" +
                            " ColumnName='" + dataSet1.Tables[i].Columns[j].ColumnName +
                            " DataType='" + dataSet1.Tables[i].Columns[j].DataType.ToString());
                }
                Console.WriteLine();
             }
        }
    }
}
