using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace Inventory_management_System
{
    public partial class Sale_order : Form
    {

        Connection mc = new Connection();
        //myconnection mc = new myconnection();

        public Sale_order()
        {
            InitializeComponent();
            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\Inventory_Management_System.accdb";
         
        }
        string[] prds = new string[50];
        int[] qty = new int[50];
        int[] tot = new int[50];
        int counter = 0;

        private void Sale_order_Load(object sender, EventArgs e)
        {
            try
            {

                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT CID From Customer  where CStatus='Approved'", mc.conn);

                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["CID"]);
                }


                OleDbCommand cmd1 = new OleDbCommand("Select PModel from Products", mc.conn);
                OleDbDataReader Dr1 = cmd1.ExecuteReader();
                while (Dr1.Read())
                {
                    comboBox2.Items.Add(Dr1["PModel"]);
                }

                int c = 0;
                OleDbCommand cmd2 = new OleDbCommand("select count (SOID) from SO", mc.conn);
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    c = Convert.ToInt32(dr2[0]); c++;

                }

                textBox6.Text = "SO-" + c.ToString() + "-" + System.DateTime.Today.Year;


                mc.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mc.conn.Close();
            }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT *  From Customer  where CID='" + comboBox1.SelectedItem + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {


                    cname.Text = Dr["CName"].ToString();
                    cpph.Text = Dr["CPPH"].ToString();
                    textBox1.Text = Dr["ContectPerson"].ToString();
                    textBox3.Text = Dr["CGroup"].ToString();


                }
                mc.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                mc.conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * from Products where PModel = '" + comboBox2.SelectedItem + "'", mc.conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pname.Text = dr["PName"].ToString();
                    amount.Text = dr["BasePrice"].ToString();


                }
                mc.conn.Close();
            }

            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
            finally
            {
                mc.conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                textBox2.Text = "0";

            }

            else
            {


                int total = Convert.ToInt32(amount.Text) * Convert.ToInt32(textBox2.Text);


                textBox4.Text = total.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += comboBox2.SelectedItem + Environment.NewLine;
            richTextBox2.Text += textBox2.Text + Environment.NewLine;
            richTextBox3.Text += textBox4.Text + Environment.NewLine;

            prds[counter] = comboBox2.SelectedItem.ToString();
            qty[counter] = Convert.ToInt32(textBox2.Text);
            tot[counter] = Convert.ToInt32(textBox4.Text);
            counter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                mc.conn.Open();
                {

                    OleDbCommand cmd = new OleDbCommand("insert into SO(SOID,DDate,Status,Approve,CDept,CName,CID,CContectPerson,CPPH,GoodRecieved,DCDate,TotalAmount)" +
                    "values(@SOID,@DDate,@Status,@Approve,@CDept,@CName,@CID,@CContectPerson,@CPPH,@GoodRecieved,@DCDate,@TotalAmount);", mc.conn);
                    cmd.Parameters.AddWithValue("@SOID", textBox6.Text);
                    cmd.Parameters.AddWithValue("@DDate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", "Open");
                    cmd.Parameters.AddWithValue("@Approve", "UnApproved");
                    cmd.Parameters.AddWithValue("@CDept", textBox3.Text);
                    cmd.Parameters.AddWithValue("@CName", cname.Text);
                    cmd.Parameters.AddWithValue("@CId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@CContectPerson", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CPPH", cpph.Text);
                    cmd.Parameters.AddWithValue("@GoodRecieved", "No");
                    DateTime thisDay = DateTime.Today;
                    cmd.Parameters.AddWithValue("@DCDate", thisDay);
                    cmd.Parameters.AddWithValue("@TotalAmount", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }
                //for (int i = 0; i < counter; i++)
                //{
                OleDbCommand cmd1 = new OleDbCommand("insert into SOProducts(SOID,PModel,PQty)values(@SOID,@PModel,@PQty);", mc.conn);
                cmd1.Parameters.AddWithValue("@SOID", textBox6.Text);
                cmd1.Parameters.AddWithValue("@PModel", comboBox2.SelectedItem);
                cmd1.Parameters.AddWithValue("@PQty", textBox2.Text);
                cmd1.ExecuteNonQuery();
                //}
                MessageBox.Show("Order successfully added....");
                mc.conn.Close();
            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
            finally
            {
                mc.conn.Close();
            }
        }
           
        }
    }

