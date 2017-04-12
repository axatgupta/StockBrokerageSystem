using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Current_Val : Form
    {
       
        String MyConnection2 = "datasource=localhost;port=3306;username=root;passowrd=;database=wallstreet";

        

        public Current_Val()
        {
            InitializeComponent();
        }

        private void Current_Val_Load(object sender, EventArgs e)
        {

        }
        private string GetWebResponse(string url)
        {
            // Make a WebClient.
            WebClient web_client = new WebClient();

            // Get the indicated URL.
            Stream response = web_client.OpenRead(url);

            // Read the result.
            using (StreamReader stream_reader = new StreamReader(response))
            {
                // Get the results.
                string result = stream_reader.ReadToEnd();

                // Close the stream reader and its underlying stream.
                stream_reader.Close();

                // Return the result.
                return result;
            }
        }

        private void GetPrice_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            string selected1 = comboBox1.Text;
            txtSymbol1.Text = selected1;
            string selected2 = comboBox2.Text;
            txtSymbol2.Text = selected2;
            string selected3 = comboBox3.Text;
            txtSymbol3.Text = selected3;
            string selected4 = comboBox4.Text;
            txtSymbol4.Text = selected4;
            // Build the URL.
            string url = "";
            if (txtSymbol1.Text != "") url += txtSymbol1.Text + "+";
            if (txtSymbol2.Text != "") url += txtSymbol2.Text + "+";
            if (txtSymbol3.Text != "") url += txtSymbol3.Text + "+";
            if (txtSymbol4.Text != "") url += txtSymbol4.Text + "+";
            if (url != "")
            {
                // Remove the trailing plus sign.
                url = url.Substring(0, url.Length - 1);

                // Prepend the base URL.
                const string base_url =
                    "http://download.finance.yahoo.com/d/quotes.csv?s=@&f=sl1d1t1c1";
                url = base_url.Replace("@", url);

                // Get the response.
                try
                {
                    // Get the web response.
                    string result = GetWebResponse(url);
                    Console.WriteLine(result.Replace("\\r\\n", "\r\n"));

                    // Pull out the current prices.
                    string[] lines = result.Split(
                        new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                    //price per share
                    //txtPrice1.Text = decimal.Parse(lines[0].Split(',')[1]).ToString("C3");
                    textBox1.Text = decimal.Parse(lines[0].Split(',')[1]).ToString();
                    txtPrice2.Text = decimal.Parse(lines[1].Split(',')[1]).ToString();
                    txtPrice3.Text = decimal.Parse(lines[2].Split(',')[1]).ToString();
                    txtPrice4.Text = decimal.Parse(lines[3].Split(',')[1]).ToString();

                    //profit/loss

                    txtTime1.Text = decimal.Parse(lines[0].Split(',')[4]).ToString();
                    txtTime2.Text = decimal.Parse(lines[1].Split(',')[4]).ToString();
                    txtTime3.Text = decimal.Parse(lines[2].Split(',')[4]).ToString();
                    txtTime4.Text = decimal.Parse(lines[3].Split(',')[4]).ToString();

                    //time 
                    
                    txtATime1.Text = lines[0].Split(',')[3];
                    txtATime2.Text = lines[1].Split(',')[3];
                    txtATime3.Text = lines[2].Split(',')[3];
                    txtATime4.Text = lines[3].Split(',')[3];


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Read Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            this.Cursor = Cursors.Default;
            //trigger
            

            try
            {
               //This is my update query in which i am taking input from the user through windows forms and update the record.  
                String Query1 = "update stock_info set price_per_share ='" + textBox1.Text + "' where share_id='"+ txtSymbol1.Text + "';";
                String Query2 = "update stock_info set price_per_share = '" + txtPrice2.Text + "' where share_id='" + txtSymbol2.Text + "';";
                String Query3= "update stock_info set price_per_share = '" + txtPrice3.Text + "' where share_id='" + txtSymbol3.Text + "';";
                
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query1, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn2);
                MySqlCommand MyCommand4 = new MySqlCommand(Query3, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MySqlDataReader MyReader3;
                MyReader3 = MyCommand3.ExecuteReader();
                MyReader3.Close();

                MySqlDataReader MyReader4 = MyCommand4.ExecuteReader();
                MyReader4.Close();
                MessageBox.Show("Data Updated");
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Transact_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                
            }
        }

        private void txtSymbol1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockSell s1 = new StockSell();
            s1.Show();
            this.Close();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy b1 = new Buy();
            b1.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
