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
    public partial class Login : Form
    {

        Connection mc = new Connection();
        public Login()
        {
            InitializeComponent();

            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }


            try
            {
           

            mc.conn.Open();

            //int pas = Convert.ToInt32(pass.Text);

            OleDbCommand cmd = new OleDbCommand("SELECT Password,Username From login;", mc.conn);
            OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {


                    if (dr["Username"].ToString()== username.Text && dr["Password"].ToString()== pass.Text)
                    {
                        main_window cs = new main_window();
                        cs.Show();
                        this.Hide();
                        //break;
                       
                    }


                    else
                    {
                        if (dr["Username"].ToString()!=username.Text)
                        {
                            MessageBox.Show("Invalid User Name", "Invalid User Name");
                            username.Clear();
                            
                        }
                        else if (dr["Password"].ToString() != pass.Text)
                        {
                            MessageBox.Show("Invalid Password", "Invalid Password");
                            pass.Clear();

                        }

                        else
                        {
                            MessageBox.Show("Invalid ID PASSWORD..!");
                        
                        }
                    }


                }
                mc.conn.Close();
            }

            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                 
        
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            create_Account cr = new create_Account();
            cr.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
