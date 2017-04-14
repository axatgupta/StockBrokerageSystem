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
    public partial class NewUser : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=wallstreet";
        public NewUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;
            try
            {
                string Query = "select password from user where username='" + id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                //This is command class which will handle the query and connection object. 
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    if (MyReader2.GetString(0).Equals(pass))
                    {
                        account a = new account();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!!");
                    }
                }
                MyConn2.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show("e1");
            }


            

        }
    }
}
