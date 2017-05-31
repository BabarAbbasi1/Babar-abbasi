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
    public partial class status__approve : Form
    {
        Connection mc = new Connection();
        public status__approve()
        {
            InitializeComponent();

            mc.conn.ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory+"//Inventory_Management_System.accdb";
         
        }
        //my_connection mc = new my_connection();



        private void status__approve_Load(object sender, EventArgs e)
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
               

            OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT CStatus From Customer  where CStatus='"+"Un_Approved"+ "'", mc.conn);
            OleDbDataReader Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {

                comboBox1.Items.Add(Dr["CStatus"]);
            }
                mc.conn.Close();
            }

            catch(Exception er)
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

                OleDbCommand cmd = new OleDbCommand("SELECT *  From Customer  where CStatus='" + comboBox1.SelectedItem + "'", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    comboBox1.Items.Add(Dr["CStatus"]);
                    c_id.Text = Dr["CID"].ToString();
                    cname.Text = Dr["Cname"].ToString();
                    textBox3.Text = Dr["Gender"].ToString();
                    agecount.Text = Dr["Date_time"].ToString();
                    climit.Text = Dr["CreditLimit"].ToString();
                    textBox1.Text = Dr["City"].ToString();
                    cmobile.Text = Dr["PH1"].ToString();
                    cphone.Text = Dr["PH2"].ToString();
                    ccontectpersone.Text = Dr["ContectPerson"].ToString();
                    cpph.Text = Dr["CPPH"].ToString();
                    cmail.Text = Dr["CEmail"].ToString();
                    textBox2.Text = Dr["CGroup"].ToString();
                    caddress.Text = Dr["CAddress"].ToString();


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


                    OleDbCommand cmd = new OleDbCommand("update Customer set CStatus ='" + comboBox2.Text + "' where CStatus ='" + comboBox1.Text + "'", mc.conn);

                    cmd.ExecuteNonQuery();

                    mc.conn.Close();

                    DialogResult dr = MessageBox.Show("Congrats! Verification Approved..");

                    if (dr == DialogResult.OK)
                    {

                        c_id.Text = "";
                        cname.Text = "";
                        textBox1.Text = "";
                        caddress.Text = "";
                        cmobile.Text = "";
                        cphone.Text = "";
                        climit.Text = "";
                        textBox2.Text = "";
                        comboBox2.Text = "";
                        ccontectpersone.Text = "";
                        cpph.Text = "";
                        cmail.Text = "";
                        textBox3.Text = "";
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
