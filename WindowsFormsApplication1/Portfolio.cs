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
    public partial class Portfolio : Form
    {
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";
        public Portfolio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sell_Click(object sender, EventArgs e)
        {
            StockSell ss = new StockSell();
            ss.Show();
        }

        private void ViewPrice_Click(object sender, EventArgs e)
        {
            Current_Val cv = new Current_Val();
            cv.Show();
           
    }

        private void Buy_Click(object sender, EventArgs e)
        {
            Buy b1 = new Buy();
            b1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String em = Account.SetValueForText2;
            String q1 = ("select share_id from stock_info where company_name='" + comboBox1.SelectedItem + "'");
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(q1, MyConn3);

            MySqlDataReader MyReader1;
            MyConn3.Open();
            MyReader1 = MyCommand3.ExecuteReader();
            while (MyReader1.Read())
            {
                string s1;
                s1 = MyReader1.GetString(0);
                label5.Text = s1;
                Refresh();
            }


            MyConn3.Close();
        }

        private void Portfolio_Load(object sender, EventArgs e)
        {
           // String em = account.SetValueForText2;
            string Query = "select AccID from account;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


            while (MyReader2.Read())
            {
                string s1;    
                s1 = MyReader2.GetString(0);
                label4.Text = s1;
                Refresh();
            }


            MyConn2.Close();
        }
    }
}
