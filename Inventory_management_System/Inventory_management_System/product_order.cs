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
    public partial class product_order : Form

        
    {
        Connection mc = new Connection();
        public product_order()
        {
            InitializeComponent();
            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }

        string[] prds = new string[50];
        string[] name = new string[50]; 
        int[] qty = new int[50];
        int[] tot = new int[50];
        int[] pp = new int[50];
        string[] po = new string[50];
        int counter = 0; 

        //my_connection mc = new my_connection();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int c = 0;
            //try
            //{
            //    mc.conn.Open();
            //    OleDbCommand cmd = new OleDbCommand("select count(poid) from po where vdept='" + comboBox1.Text + "'", mc.conn);
            //    OleDbDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        c = Convert.ToInt32(dr[0]); c++;
            //    }
            //    if (comboBox1.Text == "Consumer")
            //    {
            //        c_id.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            //    }
            //    mc.conn.Close();
            //}


            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void product_order_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
            
            
            try
            {
                mc.conn.Open();

                ////POID Populate

                OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT(VDept) from PO ", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox5.Items.Add(Dr["VDept"]).ToString();

                }

               

               


                ////////Vender ID Populate
              
                OleDbCommand cmd1 = new OleDbCommand("SELECT VID from Vendor", mc.conn);
                OleDbDataReader Dr1 = cmd1.ExecuteReader();

                while (Dr1.Read())
                {

                    comboBox4.Items.Add(Dr1["VID"]);

                }


                ////////Product ID Populate

                OleDbCommand cmd2 = new OleDbCommand("SELECT PModel from Products", mc.conn);
                OleDbDataReader Dr2 = cmd2.ExecuteReader();

                while (Dr2.Read())
                {

                    comboBox6.Items.Add(Dr2["PModel"]);

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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT *  From Vendor  where VID='" + comboBox4.SelectedItem + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {


                    Vname.Text = Dr["VName"].ToString();
                    Vcontact.Text = Dr["PH1"].ToString();
                    vdepart.Text = Dr["VGroup"].ToString();
                    vcn.Text = Dr["CPName"].ToString();
                    cpph.Text = Dr["CPPH"].ToString();
                    
                    
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

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT *  From Products  where PModel='" + comboBox6.SelectedItem + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {


                    pname1.Text = Dr["PName"].ToString();
                    pprice.Text = Dr["BasePrice"].ToString();
                    //pquantity.Text = Dr["VGroup"].ToString();
                    //ptotal.Text = Dr["CPName"].ToString();

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

        private void pquantity_TextChanged(object sender, EventArgs e)
        {

            if (pquantity.Text == "")
            {

                pquantity.Text = "0";

            }

            else
            {
                

                int total = Convert.ToInt32(pprice.Text) * Convert.ToInt32(pquantity.Text);


                ptotal.Text = total.ToString();
            }


        }
           int c = 0; 
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            mc.conn.Open();

            OleDbCommand cmd = new OleDbCommand("select count(POID) from PO where VDept='" + comboBox5.Text + "'", mc.conn);

            OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
            { 
                c = Convert.ToInt32(dr[0]); c++; 
            
            } 
            if (comboBox5.Text == "Consumer")
            { 
                textBox1.Text = "Con-00" +c.ToString()+ "-"+System.DateTime.Today.Year;
            
            }
            if (comboBox5.Text == "HR")
            {
                textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }
            if (comboBox5.Text == "Sales")
            {
                textBox1.Text = "Sales-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            } 
            
            mc.conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               mc.conn.Open();
                
                for (int i = 0; i<counter; i++)
                {
                    OleDbCommand cmd = new OleDbCommand("insert into POProducts ([POID],[PModel],[PQty],[p_name],[Total_Amount]) values (@POID,@PModel,@PQty,@p_name,@Total_Amount)", mc.conn);

                    cmd.Parameters.AddWithValue("@POID", textBox1.Text);
                    //cmd.Parameters.AddWithValue("@PModel", pname.Text);
                    cmd.Parameters.AddWithValue("@PModel", comboBox6.SelectedItem);
                    cmd.Parameters.AddWithValue("@PQty", Convert.ToInt32(pquantity.Text));
                    cmd.Parameters.AddWithValue("@p_name", pname1.Text);
                    cmd.Parameters.AddWithValue("@Total_Amount", Convert.ToInt32(ptotal.Text));

                   
                    cmd.ExecuteNonQuery();

                }

                mc.conn.Close();

                mc.conn.Open();

                string status = "Open";
                string app = "Un_approved";
                OleDbCommand cmd1 = new OleDbCommand("insert into PO ([POID],[DDate],[Status],[Approve],[VDept],[VName],[VID],[VContectPerson],[VCPPH],[TotalAmount]) values (@POID,@DDate,@Status,@Approve,@VDept,@VName,@VID,@VContectPerson,@VCPPH,@TotalAmount)", mc.conn);
                cmd1.Parameters.AddWithValue("@POID", textBox1.Text);
                cmd1.Parameters.AddWithValue("@DDate", dateTimePicker2.Value.Date);
                cmd1.Parameters.AddWithValue("@Status", status);
                cmd1.Parameters.AddWithValue("@Approve", app);
                cmd1.Parameters.AddWithValue("@VDept", comboBox5.SelectedItem);
                cmd1.Parameters.AddWithValue("@VName", Vname.Text);

                cmd1.Parameters.AddWithValue("@VID", comboBox4.SelectedItem);
                cmd1.Parameters.AddWithValue("@VContectPerson", vcn.Text);
                cmd1.Parameters.AddWithValue("@VCPPH", Convert.ToInt32(cpph.Text));
                cmd1.Parameters.AddWithValue("@TotalAmount", Convert.ToInt32(ptotal.Text));


                cmd1.ExecuteNonQuery();





                mc.conn.Close();
                
                MessageBox.Show("Transaction done!!");

                pname1.Text = "";
                comboBox6.SelectedItem = "";
                pquantity.Text = "";
                pname1.Text = "";
                ptotal.Text = "";
                textBox1.Text = "";
                comboBox5.Text = "";
                pprice.Text = "";
                          
               

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";

                comboBox4.Text = "";                
                vcn.Text = "";
                Vcontact.Text = "";
                vdepart.Text = "";
                Vname.Text = "";
                cpph.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + Environment.NewLine;
            textBox4.Text += comboBox6.Text + Environment.NewLine;
            textBox6.Text += pprice.Text + Environment.NewLine;
            textBox5.Text += pname1.Text + Environment.NewLine;
            textBox7.Text += ptotal.Text + Environment.NewLine;
            textBox8.Text += pquantity.Text + Environment.NewLine;

            prds[counter] = comboBox6.SelectedItem.ToString();
            qty[counter] = Convert.ToInt32(pquantity.Text);
            pp[counter] = Convert.ToInt32(pprice.Text + Environment.NewLine);
            tot[counter] = Convert.ToInt32(ptotal.Text + Environment.NewLine);
            name[counter] = pname1.Text + Environment.NewLine;
            po[counter] = textBox1.Text + Environment.NewLine;
            counter++;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
