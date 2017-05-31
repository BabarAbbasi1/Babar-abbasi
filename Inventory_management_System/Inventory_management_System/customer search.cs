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
    public partial class customer_search : Form
    {
        Connection mc = new Connection();
        public customer_search()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }
        //my_connection mc = new my_connection();

        private void customer_search_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Enter ID In Search Box !");

                }

                else
                {

                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("SELECT * From Customer", mc.conn);
                    OleDbDataReader Dr = cmd.ExecuteReader();



                    while (Dr.Read())
                    {
                        if (Dr["CID"].ToString() == textBox4.Text)
                        {
                            c_id.Text = (Dr["CID"]).ToString();

                            cname.Text = (Dr["Cname"]).ToString();
                            textBox5.Text = (Dr["CStatus"]).ToString();
                            textBox3.Text = (Dr["Gender"]).ToString();
                            agecount.Text = (Dr["Date_time"]).ToString();
                            textBox1.Text = (Dr["City"]).ToString();
                            climit.Text = (Dr["CreditLimit"]).ToString();
                            caddress.Text = (Dr["CAddress"]).ToString();
                            cmobile.Text = (Dr["PH1"]).ToString();
                            cphone.Text = (Dr["PH2"]).ToString();
                            ccontectpersone.Text = (Dr["ContectPerson"]).ToString();
                            cpph.Text = (Dr["CPPH"]).ToString();
                            cmail.Text = (Dr["CEmail"]).ToString();
                            textBox2.Text = (Dr["CGroup"]).ToString();
                            break;

                        }


                        //MessageBox.Show("Cuatomer ID Not Found !");
                        //break;


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
