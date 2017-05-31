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
    public partial class po_approvence : Form
    {

        Connection mc = new Connection();

        public po_approvence()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }
        //my_connection mc = new my_connection();


        private void po_approvence_Load(object sender, EventArgs e)
        {

            try
            {

                
                mc.conn.Open();

                //AND Status='"+"Open"+"'"
                OleDbCommand cmd = new OleDbCommand("SELECT POID From PO where Approve='"+"Un_approved"+"'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["POID"]);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT *  From PO where POID='" +comboBox1.Text + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    //comboBox2.Items.Add(Dr["Approve"]);
                    c_id.Text = Dr["POID"].ToString();
                    cname.Text = Dr["VName"].ToString();
                    ccontectpersone.Text = Dr["VContectPerson"].ToString();
                    amount.Text = Dr["TotalAmount"].ToString();

                    ddate.Text = Dr["DDate"].ToString();
                    textBox2.Text = Dr["VDept"].ToString();
                    cmobile.Text = Dr["VCPPH"].ToString();
                 


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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Select Approvence..");
                }
                else
                {
                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("update PO set Approve ='" +comboBox2.Text + "' where POID='"+comboBox1.Text+"' " , mc.conn);

                    cmd.ExecuteNonQuery();

                    mc.conn.Close();

                    DialogResult dr = MessageBox.Show("Congrats! Verification Approved..");

                    if (dr == DialogResult.OK)
                    {

                        c_id.Text = "";
                        cname.Text = "";
                       
                        cmobile.Text = "";
                      
                        textBox2.Text = "";
                        comboBox2.Text = "";
                        ccontectpersone.Text = "";
                     
                    }
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
    }
}
