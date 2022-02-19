using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec4Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataSet1.ReadXml("data.xml", XmlReadMode.IgnoreSchema);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSet1.WriteXml("datawithschema.xml", XmlWriteMode.WriteSchema);
            dataSet1.WriteXmlSchema(@"data.xsd");
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            cmCustomers.Position = 0;
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if (cmCustomers.Position != 0)
            {
                cmCustomers.Position -= 1;
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (cmCustomers.Position != cmCustomers.Count - 1)
            {
                cmCustomers.Position += 1;
            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            cmCustomers.Position = cmCustomers.Count - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtProducts = dataSet1.Tables[0];
            txtCompanyName.DataBindings.Add("Text", dtProducts, "ProductName");
            cmCustomers = (CurrencyManager)(this.BindingContext[dtProducts]);
            cmCustomers.Position = 0;
        }

        private CurrencyManager cmCustomers;

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            //Delete a row
            //dataSet1.Tables[0].Rows[0].Delete();
            dataSet1.Tables[0].Rows.Remove(dataSet1.Tables[0].Rows[0]);

            //Save the data portion of the DataSet as a Diffgram 
            dataSet1.WriteXml(@"data_changed.xml",
                XmlWriteMode.DiffGram);
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            dataSet1.AcceptChanges();
        }
    }
}
