using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Transact : Form
    {
        public static string SetValueForText3= "";
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";
        public Transact()
        {
            InitializeComponent();
        }

        private void Transact_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = DateTime.Now.ToString("dd-mm-yyyy");

            textBox3.Text = DateTime.Now.ToString("h:mm:ss tt");
            String Query = "select AccID,TotalPrice,TID from account natural join transaction;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();

            while (MyReader2.Read())
            {
                string s1,s2,s3;
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                s3 = MyReader2.GetString(2);
                textBox1.Text = s1;
                textBox4.Text = s2;
                textBox5.Text = s3;


                Refresh();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillGenerated bg = new BillGenerated();
            bg.Show();
            this.Close();

        }
    }
}

