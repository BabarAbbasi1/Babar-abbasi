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
    public partial class sale_approvence : Form
    {
        Connection mc = new Connection();
        public sale_approvence()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\Inventory_Management_System.accdb";
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sale_approvence_Load(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT SOID From SO where Approve='UnApproved'", mc.conn);

                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["SOID"]);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * From SO where SOID='" + comboBox1.SelectedItem + "'", mc.conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cname.Text = dr["SOID"].ToString();
                    textBox3.Text = dr["CID"].ToString();
                    textBox5.Text = dr["CName"].ToString();
                    textBox2.Text = dr["CDept"].ToString();
                    textBox4.Text = dr["CContectPerson"].ToString();
                    cpph.Text = dr["CPPH"].ToString();
                    textBox5.Text = dr["DDate"].ToString();
                    textBox6.Text = dr["TotalAmount"].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
        {

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Select Approve Status....");
            }
            else
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("update SO set Approve ='" + comboBox1.Text + "' where SOID ='" + cname.Text + "'", mc.conn);

                cmd.ExecuteNonQuery();

                mc.conn.Close();

                DialogResult di = MessageBox.Show("Verification Approved");
            }
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
