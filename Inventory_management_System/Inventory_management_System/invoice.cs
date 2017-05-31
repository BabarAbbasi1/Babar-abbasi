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
    public partial class invoice : Form
       {
        Connection mc = new Connection();
        public invoice()
        {
            InitializeComponent();
            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         

        }

        //my_connection mc = new my_connection();

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                ////POID Populate

                OleDbCommand cmd = new OleDbCommand("SELECT GRNID from GRN where Status='Open'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["GRNID"]).ToString();


                }
                

                //mc.conn.Close();
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

                ////POID Populate

                OleDbCommand cmd = new OleDbCommand("SELECT * from GRN where GRNID = '" + comboBox1.SelectedItem + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    po.Text = Dr["BaseDocument"].ToString();
                    vname.Text = Dr["VName"].ToString();
                    ddate.Text = Dr["DDate"].ToString();
                    //p_total.Text = Dr[4].ToString();

                }

                string[] stringArray = comboBox1.Text.Split(new char[] { '-' }, StringSplitOptions.None);

                INV_ID.Text = "INV-" + stringArray[1] + "-" + System.DateTime.Today.Year;


                OleDbCommand cmd1 = new OleDbCommand("SELECT * from POProducts where POID = '" + po.Text + "'", mc.conn);
                OleDbDataReader Dr1 = cmd1.ExecuteReader();

                while (Dr1.Read())
                {


                    textBox1.Text = Dr1["PModel"].ToString();
                    pname1.Text = Dr1["p_name"].ToString();
                    pquantity.Text = Dr1["PQty"].ToString();
                    ptotal.Text = Dr1["Total_Amount"].ToString();

                }

                OleDbCommand cmd2 = new OleDbCommand("SELECT * from Vendor where VName = '" + vname.Text + "'", mc.conn);
                OleDbDataReader Dr2 = cmd2.ExecuteReader();

                while (Dr2.Read())
                {

                    vid.Text = Dr2["VID"].ToString();
                    vgroup.Text = Dr2["VGroup"].ToString();
                    //vcontact.Text = Dr2["CPName"].ToString();
                    vcode.Text = Dr2["VCode"].ToString();
                    vcontact.Text = Dr2["PH1"].ToString();

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

        int adtax = 0;int toamout = 0;
        private void ptotal_TextChanged(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(ptotal.Text);
            adtax = v * 17 / 100;
            textBox2.Text= adtax.ToString();



            toamout = v + adtax;
            textBox3.Text = toamout.ToString();

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBox1.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Selce ID From Box !");
                }
                else
                {
                    //id = Convert.ToInt32(c_id.Text);

                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into Invoice([InvoiceNo],[VendorID],[VNAME],[CPPH],[DDate],[RDate],[AmountPayable],[GRNID]) values (@InvoiceNo,@VendorID,@VNAME,@CPPH,@DDate,@RDate,@AmountPayable,@GRNID)", mc.conn);

                    cmd.Parameters.AddWithValue("@InvoiceNo", INV_ID.Text);
                    cmd.Parameters.AddWithValue("@VendorID", vid.Text);
                    cmd.Parameters.AddWithValue("@VNAME", vname.Text);
                    cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(vcontact.Text));
                    cmd.Parameters.AddWithValue("@DDate", ddate.Text);
                    cmd.Parameters.AddWithValue("@RDate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@AmountPayable", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@GRNID", comboBox1.SelectedItem);
                    cmd.ExecuteNonQuery();


                    mc.conn.Close();

                    DialogResult rs = MessageBox.Show("Invoice HAS BEEN CREATED ! Congrats!");

                    if (rs == DialogResult.OK)
                    {


                        mc.conn.Open();


                        OleDbCommand cmd1 = new OleDbCommand("Update GRN set Status ='Closed' where GRNID='" + comboBox1.SelectedItem + "'", mc.conn);

                        cmd1.ExecuteNonQuery();
                        mc.conn.Close();


                        INV_ID.Text = "";
                        vid.Text = "";
                        vgroup.Text = "";
                        vname.Text = "";
                        ddate.Text = "";
                        vcontact.Text = "";
                        po.Text = "";
                       
                        vcode.Text = "";
                        comboBox1.Text = "";
                        INV_ID.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        ptotal.Text = "";
                        pquantity.Text = "";
                        pname1.Text = "";

                        





                        //DialogResult dr = MessageBox.Show("Congrats! Verification Approved..");

                    }

                    //}
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