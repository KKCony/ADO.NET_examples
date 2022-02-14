using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec01Ex02_SQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLitePCL.Batteries.Init();
            using (var connection = new SqliteConnection("Data Source=orders.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
        SELECT userid, fname, lname
        FROM customers
        WHERE userid LIKE $id
    ";
                command.Parameters.AddWithValue("$id", "0000%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);

                        listView1.Items.Add(Name);
                    }
                }
            }
        }
    }
}
