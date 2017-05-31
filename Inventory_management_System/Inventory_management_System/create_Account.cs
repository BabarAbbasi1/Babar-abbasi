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
    public partial class create_Account : Form
    {
        Connection mc = new Connection();

        public create_Account()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }
      
        string gender = "";
        int id = 0;

        private void create_Account_Load(object sender, EventArgs e)
        {
            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT count (user_id) from login ", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    id = Convert.ToInt32((Dr[0])); id++;

                }

                textBox7.Text = "LI-00" + id.ToString() + "-" + System.DateTime.Today.Year;


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
       
        private void button5_Click(object sender, EventArgs e)
        {
          
        
        }

        private void button5_Click_1(object sender, EventArgs e)
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

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("All filed Required Must Be Filled");
                }
                else
                {
                //    id = Convert.ToInt32(textBox7.Text);

                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into login([user_id],[Username],[Password],[Gender],[Contact],[Address],[Email]) values (@user_id,@Username,@Password,@Gender,@Contact,@Address,@Email)", mc.conn);

                    cmd.Parameters.AddWithValue("@user_id", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Contact", Convert.ToInt32(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Address", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.ExecuteNonQuery();


                    mc.conn.Close();

                    DialogResult rs = MessageBox.Show("Your Account Sucessfully Created !", " Let's Login");

                    if (rs == DialogResult.OK)
                    {
                        Login ln = new Login();
                        ln.Show();
                        this.Hide();


                    }
                    if (rs == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }

            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }
    }
}
