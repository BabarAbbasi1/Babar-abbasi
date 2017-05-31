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
    public partial class ADD_Vender : Form
    {
        public ADD_Vender()
        {
            InitializeComponent();
           
        }

        my_connection mc = new my_connection();

       
        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                if (v_id.Text == "" || vname.Text == ""  || vstatus.Text == "" || vmail.Text == "" || vmobile.Text == "" || vphone.Text == "" || cpph.Text == "" || vcontectpersone.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("All filed Required Must Be Filled");
                }
                else
                {
                    

                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into Vendor([VID],[VName],[VCode],[VCity],[PH1],[PH2],[VAddress],[CPName],[CPPH],[VEmail],[VGroup],[VStatus],[Vdate]) values (@VID,@VName,@VCode,@VCity,@PH1,@PH2,@VAddress,@CPName,@CPPH,@VEmail,@VGroup,@VStatus,@Vdate)", mc.conn);

                    cmd.Parameters.AddWithValue("@VID", v_id.Text);
                    cmd.Parameters.AddWithValue("@VName", vname.Text);

                    cmd.Parameters.AddWithValue("@VCode", vcode.Text);
                    cmd.Parameters.AddWithValue("@VCity", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@PH1", Convert.ToInt32(vmobile.Text));
                    cmd.Parameters.AddWithValue("@PH2", Convert.ToInt32(vphone.Text));
                    cmd.Parameters.AddWithValue("@VAddress", vaddress.Text);
                    cmd.Parameters.AddWithValue("@CPName", vcontectpersone.Text);
                    cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(cpph.Text));
                    //cmd.Parameters.AddWithValue("@CreditLimit", Convert.ToInt32(climit.Text));
                    cmd.Parameters.AddWithValue("@VEmail", vmail.Text);
                    cmd.Parameters.AddWithValue("@VGroup", comboBox2.SelectedItem);
                        cmd.Parameters.AddWithValue("@VStatus", vstatus.Text);
                    cmd.Parameters.AddWithValue("@Vdate", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();


                    mc.conn.Close();

                    DialogResult rs = MessageBox.Show("Vendor Successfully Registred !");

                   


                    if (rs == DialogResult.OK)
                    {
                        v_id.Text = "";
                        vname.Text = "";
                        
                        vaddress.Text = "";
                        vmobile.Text = "";
                        vphone.Text = "";
                        
                        vstatus.Text = "";
                        comboBox2.Text = "";
                        vcontectpersone.Text = "";
                        cpph.Text = "";
                        vmail.Text = "";


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
        

        private void ADD_Vender_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            int id = 0;

            int c = 0;

            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT count(VID) from Vendor ", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    c = Convert.ToInt32((Dr[0])); id++;

                }

                v_id.Text = "VI-00" + c.ToString() + "-" + System.DateTime.Today.Year;


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
