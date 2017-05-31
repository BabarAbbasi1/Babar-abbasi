using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inventory_management_System
{
    public partial class sale_Invoice : Form
    {
        Connection mc = new Connection();
        public sale_Invoice()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sale_Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT DCID From DeliveryChalan where Status='" + "Open" + "'", mc.conn);

                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox2.Items.Add(Dr["DCID"]);
                }

                int c = 0;

                OleDbCommand cmd1 = new OleDbCommand("select count (InvoiceNo) from InvoiceRecievable", mc.conn);

                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    c = Convert.ToInt32(dr1[0]);
                    c++;

                }

                cname.Text = c.ToString();

                mc.conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
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
                {
                    OleDbCommand cmd = new OleDbCommand("select * from DeliveryChalan where DCID='" + comboBox2.SelectedItem + "'", mc.conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        textBox4.Text = dr["SOID"].ToString();
                        textBox1.Text = dr["CName"].ToString();
                        textBox2.Text = dr["DDate"].ToString();
                        
                    }


                    {

                        OleDbCommand cmd1 = new OleDbCommand("Select * from Customer where Cname= '" + textBox1.Text + "'", mc.conn);
                        OleDbDataReader dr1 = cmd1.ExecuteReader();

                        while (dr1.Read())
                        {
                            textBox6.Text = dr1["CID"].ToString();
                            textBox8.Text = dr1["CGroup"].ToString();
                            textBox3.Text = dr1["PH1"].ToString();
                        }
                    }

                    {


                        OleDbCommand cmd2 = new OleDbCommand("Select * from SOProducts where SOID='" + textBox4.Text + "'", mc.conn);
                        OleDbDataReader dr2 = cmd2.ExecuteReader();

                        while (dr2.Read())
                        {
                            textBox5.Text = dr2["PModel"].ToString();
                            textBox9.Text = dr2["PQty"].ToString();

                        }
                    }

                    {
                        OleDbCommand cmd3 = new OleDbCommand("Select * from Products where PModel = '" + textBox5.Text + "'", mc.conn);
                        OleDbDataReader dr3 = cmd3.ExecuteReader();

                        while (dr3.Read())
                        {
                            cmobile.Text = dr3["PName"].ToString();
                        }

                    }
                    {

                        OleDbCommand cmd4 = new OleDbCommand("select * from SO where SOID = '" + textBox4.Text + "'", mc.conn);
                        OleDbDataReader dr4 = cmd4.ExecuteReader();

                        while (dr4.Read())
                        {
                            textBox12.Text = dr4["TotalAmount"].ToString();
                        }
                    }

                    mc.conn.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                mc.conn.Close();
            }
        }

        int t = 0;
        int a = 0;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            t = Convert.ToInt32(textBox10.Text) * 17 / 100;

            textBox11.Text = t.ToString();

            a = Convert.ToInt32(textBox10.Text) + Convert.ToInt32(textBox11.Text);
            textBox12.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("insert into InvoiceRecievable([InvoiceNo],[CustomerID],[CustomerName],[Phone_No],[DDate],[RDate],[AmountRecievable],[DCID]) Values (@InvoiceNo,@CustomerID,@CustomerName,@Phone_No,@DDate,@RDate,@AmountRecievable,@DCID)", mc.conn);

                cmd.Parameters.AddWithValue("@InvoiceNo", cname.Text);
                cmd.Parameters.AddWithValue("@CustomerID", textBox6.Text);
                cmd.Parameters.AddWithValue("@CustomerName", textBox7.Text);
                cmd.Parameters.AddWithValue("@Phone_No", Convert.ToInt32(textBox3.Text));
                cmd.Parameters.AddWithValue("@DDate", textBox2.Text);
                cmd.Parameters.AddWithValue("@RDate", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@AmountRecievable", Convert.ToInt32(textBox12.Text));
                cmd.Parameters.AddWithValue("@DCID", comboBox2.SelectedItem);
                cmd.ExecuteNonQuery();

                OleDbCommand cmd1 = new OleDbCommand("UPDATE DeliveryChalan set Status='Close' where DCID ='" + comboBox2.SelectedItem + "'", mc.conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Invoice Has Been Generated!");
                mc.conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                mc.conn.Close();
            }

        }
    }
}
