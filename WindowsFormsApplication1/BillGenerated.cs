using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class BillGenerated : Form
    {
       
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";
        public BillGenerated()
        {
            InitializeComponent();
        }

        private void BillGenerated_Load(object sender, EventArgs e)
        {
            
            String Query = ("select * from transaction;");
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();

            while (MyReader2.Read())
            {
                string s1, s2,s3,s4,s5;


                s1 = MyReader2.GetString(0);

                s2 = MyReader2.GetString(1);

                s3 = MyReader2.GetString(2);
                s4 = MyReader2.GetString(3);
                s5 = MyReader2.GetString(4);

                label17.Text = s1;
                label18.Text = s2;
                label19.Text = s3;
                label20.Text = s4;
                label21.Text = s5;
                Refresh();
            }


            MyConn2.Close();
        }

        private void BillGenerated_Load_1(object sender, EventArgs e)
        {

        }
    }

      
    }

