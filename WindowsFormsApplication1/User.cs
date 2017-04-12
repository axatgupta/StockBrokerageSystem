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
    public partial class User : Form
    {
       public static string u1;
        string lid;
        public static string SetValueForText1 = "";
       
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";

        public User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        private void login_Click(object sender, EventArgs e)
        {
            u1 = UserID.Text;
            lid = UserID.Text;
            string pass = Password.Text;
            string Query = "select Password from user where UserID = " + "'" + lid + "';";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;

            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();




            while (MyReader2.Read())
            {
                if (MyReader2.GetString(0).Equals(pass))
                {
                    this.Hide();
                    account  ac = new account();
                    ac.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect UserID or Password");
                }


            }
        }
        String id;
        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
