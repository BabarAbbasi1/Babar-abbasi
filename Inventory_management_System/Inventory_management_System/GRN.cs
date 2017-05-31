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
    public partial class GRN : Form
    {
        Connection mc1 = new Connection();
       
        public GRN()

        {
            InitializeComponent();

           
            mc1.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }
        //my_connection mc = new my_connection();

        

      

 

int sn = 0;
       
        private void GRN_Load(object sender, EventArgs e)
        {
            try
            {
                //mc.conn.Open();

                //mc.Close();
                mc1.conn.Open();

               

                ////POID Populate

                OleDbCommand cmd = new OleDbCommand("SELECT POID from PO where Approve='Approved' AND Status='Open'", mc1.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["POID"]).ToString();

                }

                try
                {
                    

                    OleDbCommand cmd2 = new OleDbCommand("Select SNO from GRN ", mc1.conn);
                    OleDbDataReader Dr2 = cmd2.ExecuteReader();

                    if(Dr2.Read())
                    {

                        sn = Convert.ToInt32(Dr2["SNO"]);sn++;
                        

                           

                            //textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year
                        
                    } 
                    textBox2.Text ="SNO-00"+sn.ToString()+"00"+sn.ToString();


                }

                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }


               
                //mc.conn.Close();
                mc1.conn.Close();

               
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            finally
            {
                //mc.conn.Close();
                mc1.conn.Close();
            }

        }

        //string gid = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //mc.conn.Open();

                mc1.conn.Open();

                ////POID Populate

                OleDbCommand cmd = new OleDbCommand("SELECT * from POProducts where POID = '" + comboBox1.SelectedItem + "'", mc1.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    p_id.Text = Dr["PModel"].ToString();

                    qty.Text = Dr[2].ToString();
                    pname.Text = Dr[3].ToString();
                    p_total.Text = Dr[4].ToString();





                    string[] stringArray = comboBox1.Text.Split(new char[] { '-' }, StringSplitOptions.None);

                    GRN_ID.Text = "GRN-" + stringArray[1] + "-" + System.DateTime.Today.Year;

                }


                OleDbCommand cmd1 = new OleDbCommand("SELECT * from PO where POID = '"+comboBox1.SelectedItem + "'", mc1.conn);
                OleDbDataReader Dr1 = cmd1.ExecuteReader();

                while (Dr1.Read())
                {

                    vname.Text = Dr1["VName"].ToString();

                    ddate.Text = Dr1["DDate"].ToString();

                    //pname.Text = Dr[3].ToString();
                    //p_total.Text = Dr[4].ToString();    
                }



               
                

               

                //mc.conn.Close();
                mc1.conn.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            finally
            {
                //mc.conn.Close();
                mc1.conn.Close();
            }
        }

        string status = "Open";
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

                    //mc.conn.Open();
                    mc1.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into GRN([GRNID],[BaseDocument],[Status],[VName],[DDate],[GRDate],[SNO]) values (@GRNID,@BaseDocument,@Status,@VName,@DDate,@GRDate,@SNO)", mc1.conn);

                    cmd.Parameters.AddWithValue("@GRNID", GRN_ID.Text);
                    cmd.Parameters.AddWithValue("@BaseDocument", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@VName", vname.Text);
                    cmd.Parameters.AddWithValue("@DDate", ddate.Text);
                    cmd.Parameters.AddWithValue("@GRDate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@SNO", textBox2.Text);
                    cmd.ExecuteNonQuery();


                    //mc.conn.Close();
                    mc1.conn.Close();

                    DialogResult rs = MessageBox.Show("GRN HAS BEEN CREATED ! Congrat!");

                    if (rs == DialogResult.OK)
                    {
                       

                        //mc.conn.Open();
                        mc1.conn.Open();


                        OleDbCommand cmd1 = new OleDbCommand("Update PO set Status ='Closed' where POID='" + comboBox1.SelectedItem + "'", mc1.conn);

                        cmd1.ExecuteNonQuery();
                        //mc.conn.Close();
                        mc1.conn.Close();


                         p_id.Text = "";
                        p_total.Text = "";
                        pname.Text = "";
                        vname.Text = "";
                        ddate.Text = "";
                        textBox2.Text = "";
                        comboBox1.SelectedItem = "";
                        GRN_ID.Text = "";
                        qty.Text = "";



                        

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
                //mc.conn.Close();
                mc1.conn.Close();
            }
        
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
