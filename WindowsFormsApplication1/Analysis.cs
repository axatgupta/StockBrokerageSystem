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
    public partial class Analysis : Form
    {
        //public static string SetValueForText2 = "";
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";
        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            //String em = User.SetValueForText1;
            String Query = "select AccID from account natural join user;";
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
                label5.Text = s1;
                Refresh();
            }


            MyConn2.Close();
        }
    }
}
