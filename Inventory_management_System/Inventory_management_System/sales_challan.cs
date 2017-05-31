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
    public partial class sales_challan : Form
    {
        Connection mc = new Connection();
        public sales_challan()
        {
            InitializeComponent();
            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }

        
        private void sales_challan_Load(object sender, EventArgs e)
        {
            try
            {

                mc.conn.Open();


                // SNO
                {
                    int c = 0;

                    OleDbCommand cmd = new OleDbCommand("select count (SNO) from DeliveryChalan", mc.conn);

                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        c = Convert.ToInt32(dr[0]);
                        c++;

                    }

                    textBox1.Text = c.ToString();
                }
                ////SOID

                {
                    OleDbCommand cmd1 = new OleDbCommand("SELECT SOID From SO  where Approve='Approved'", mc.conn);

                    OleDbDataReader Dr1 = cmd1.ExecuteReader();

                    while (Dr1.Read())
                    {

                        comboBox2.Items.Add(Dr1["SOID"]);
                    }

                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                string status = "Open";
                OleDbCommand cmd = new OleDbCommand("Insert into DeliveryChalan([DCID],[SOID],[Status],[DDate],[CName],[RDate],[SNO]) Values (@BCID,@SOID,@Status,@DDate,@CName,@RDate,@SNO)", mc.conn);

                cmd.Parameters.AddWithValue("@DCID", textBox6.Text);
                cmd.Parameters.AddWithValue("@SOID", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@Status",status);
                cmd.Parameters.AddWithValue("@DDate", textBox2.Text);
                cmd.Parameters.AddWithValue("@CName", cmobile.Text);
                DateTime thisDay = DateTime.Today;
                cmd.Parameters.AddWithValue("@RDate", thisDay);
                cmd.Parameters.AddWithValue("@SNO", textBox1.Text);
                cmd.ExecuteNonQuery();

                OleDbCommand cmd1 = new OleDbCommand("update SO set Status = 'Close' where SOID ='" + comboBox2.Text + "'", mc.conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Delivery Chalan Generated...");
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

            textBox1.Text = "";
            cname.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            cmobile.Text = "";
            cphone.Text = "";
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();



                OleDbCommand cmd = new OleDbCommand("Select * From SOProducts where SOID='" + comboBox2.SelectedItem + "'", mc.conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBox4.Text = dr["PModel"].ToString();
                    textBox3.Text = dr["PQty"].ToString();
                }


                OleDbCommand cmd1 = new OleDbCommand("Select * From SO where SOID = '" + comboBox2.SelectedItem + "'", mc.conn);
                OleDbDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {
                     cname.Text = dr1["CID"].ToString();
                    cmobile.Text = dr1["CName"].ToString();
                    cphone.Text = dr1["CDept"].ToString();
                    textBox2.Text = dr1["DDate"].ToString();

                }


                string[] stringArray = comboBox2.Text.Split(new char[] { '_' }, StringSplitOptions.None);
                textBox6.Text = "DC_" + stringArray[1] + "_" + System.DateTime.Today.Year;


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
