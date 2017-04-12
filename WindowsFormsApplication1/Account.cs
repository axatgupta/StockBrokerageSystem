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
    public partial class account : Form
    {
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            //String em = Account.SetValueForText2;
            String q1 = ("select  AccID,DateOpened from account natural join user;");
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(q1, MyConn3);

            MySqlDataReader MyReader1;
            MyConn3.Open();
            MyReader1 = MyCommand3.ExecuteReader();
            while (!(MyReader1.Read().Equals(User.u1)))
            {
                
                string s1,s2;
                s1 = MyReader1.GetString(0);
                s2 = MyReader1.GetString(1);
                label3.Text = s1;
                label4.Text = s2; 
                Refresh();
            }


            MyConn3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Portfolio pf = new Portfolio();
            pf.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analysis a = new Analysis();
                a.Show();
        }
    }
    }

