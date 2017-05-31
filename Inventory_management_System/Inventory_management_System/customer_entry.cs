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
using System.Drawing.Drawing2D;

namespace Inventory_management_System
{
    public partial class customer_entry : Form
    {
        //myconnection mc = new myconnection();

        Connection mc = new Connection();

        public customer_entry()
        {
            InitializeComponent();

            mc.conn.ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
           
        }
        
        
        //OleDbConnection conn = new OleDbConnection();
       
        //int c = 0;

        private void customer_entry_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //myconn m = new myconn();

            //conn.ConnectionString = m.ConnectionString;

            //conn.Open();





            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT count (CID) from Customer ", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    id = Convert.ToInt32((Dr[0]));id++;
                    
                }

                c_id.Text = "CR-00" + id.ToString() + "-" + System.DateTime.Today.Year;
            

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
        string gender = "";
        int id = 0001;
        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        
        {
            try
            {

                //if (textBox2.Text == "" || textBox3.Text == "")
                //  {
                //      confirm= textBox3.Text;
                //      return;
                //  }
                //  if (textBox2.Text != textBox3.Text)
                //  {
                //      MessageBox.Show("confirm password not matching with new passsword");
                //      textBox3.Focus();
                //      return;
                //  }


                //Gender COde
                if (radioButton1.Checked == true)
                {

                    gender = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {

                    gender = radioButton2.Text;
                }

                if (c_id.Text == "" || cname.Text == "" || climit.Text == "" || cstatus.Text == "" || cmail.Text == "" || cmobile.Text == "" || cphone.Text == "" || cpph.Text == "" || gender == "" || ccontectpersone.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("All filed Required Must Be Filled");
                }
                else
                {
                    //id = Convert.ToInt32(c_id.Text);

                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into Customer([CID],[Cname],[Gender],[CAddress],[City],[PH1],[PH2],[ContectPerson],[CPPH],[CEmail],[CreditLimit],[CStatus],[CGroup],[Date_time]) values (@CID,@Cname,@Gender,@CAddress,@City,@PH1,@PH2,@Contectperson,@CPPH,@CEmail,@CreditLimit,@CStatus,@CGroup,@Date_time)", mc.conn);

                    cmd.Parameters.AddWithValue("@CID", "CR" + id + "/2017");
                    cmd.Parameters.AddWithValue("@Cname", cname.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@CAddress", caddress.Text);
                    cmd.Parameters.AddWithValue("@City", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@PH1", Convert.ToInt32(cmobile.Text));
                    cmd.Parameters.AddWithValue("@PH2", Convert.ToInt32(cphone.Text));
                    cmd.Parameters.AddWithValue("@Contectperson", ccontectpersone.Text);
                    cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(cpph.Text));
                    cmd.Parameters.AddWithValue("@CEmail", cmail.Text);
                    cmd.Parameters.AddWithValue("@CreditLimit", Convert.ToInt32(climit.Text));
                    cmd.Parameters.AddWithValue("@CStatus", cstatus.Text);
                    cmd.Parameters.AddWithValue("@CGroup", comboBox2.SelectedItem);
                    cmd.Parameters.AddWithValue("@Date_time", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();


                    mc.conn.Close();

                    DialogResult rs = MessageBox.Show("Record Successfully Inserted !");

                    if (rs == DialogResult.OK)
                    {
                        c_id.Text = "";
                        cname.Text = "";
                        gender = "";
                        caddress.Text = "";
                        cmobile.Text = "";
                        cphone.Text = "";
                        climit.Text = "";
                        cstatus.Text = "";
                        comboBox2.Text = "";
                        ccontectpersone.Text = "";
                        cpph.Text = "";
                        cmail.Text = "";


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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public class myconn
    {
        public string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";

    }
    }

    
}
