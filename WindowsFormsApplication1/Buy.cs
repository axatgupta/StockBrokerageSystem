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
    public partial class Buy : Form
    {
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";

        public Buy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transact t1 = new Transact();
            t1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Current_Val c1 = new Current_Val();
            c1.Show();
            this.Close();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            String Query = "select price_per_share,share_id from stock_info;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();

            while (MyReader2.Read())
            {
                string s1,s2;
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                
                textBox1.Text = s1;
                label6.Text = s2;
                Refresh();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String qty = textBox2.Text;
            int q = Convert.ToInt32(qty);
            String price = textBox1.Text;
            int p = Convert.ToInt32(price);
            int np = p * q;
            label4.Text = np.ToString();
            try
            {
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                String Query1 = "update stock_info set qty ='" + textBox2.Text + "' where share_id='" + label6.Text + "';";
                String Query2 = "update transaction set TotalPrice ='" + label4.Text + "' where AccID=1005;";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query1, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn2);

                MySqlDataReader MyReader2;
                MySqlDataReader MyReader3;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MyReader3 = MyCommand3.ExecuteReader();
                MyReader3.Close();
                MessageBox.Show("Quantity & Total Price Updated");
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
