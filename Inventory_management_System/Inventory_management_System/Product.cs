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
    public partial class Product : Form
    {
        Connection mc = new Connection();

        public Product()
        {
            InitializeComponent();
            mc.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "//Inventory_Management_System.accdb";
         
        }
        //my_connection mc = new my_connection();
 int id = 0;

        private void Product_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

           
            //int c = 0;

            try
            {
                mc.conn.Open();


                OleDbCommand cmd = new OleDbCommand("SELECT count(PModel) from Products ", mc.conn);
                OleDbDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {

                    id = Convert.ToInt32((Dr[0])); id++;

                }

                p_id.Text = "PI-00" + id.ToString() + "-" + System.DateTime.Today.Year;


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


                if (p_id.Text == "" || pname.Text == "" || pprice.Text == "" || comboBox3.Text == "" || Vdelivery.Text == "" || pamount.Text == "" || palloworder.Text == "" || comboBox1.Text == "" || comboBox4.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("All filed Required Must Be Filled");
                }
                else
                {


                    mc.conn.Open();


                    OleDbCommand cmd = new OleDbCommand("insert into Products([PModel],[PName],[BasePrice],[InventoryStatus],[EstimatedDelivery],[AmountOnHand],[AllowPerOrder],[WarrentyPeriod],[ProductType],[PDate]) values (@PModel,@PName,@BasePrice,@InventoryStatus,@EstimatedDelivery,@AmountOnHand,@AllowPerOrder,@WarrentyPeriod,@ProductType,@PDate)", mc.conn);

                    cmd.Parameters.AddWithValue("@PModel", p_id.Text);
                    cmd.Parameters.AddWithValue("@PName", pname.Text);
                    cmd.Parameters.AddWithValue("@BasePrice", Convert.ToInt32(pprice.Text));
                    cmd.Parameters.AddWithValue("@InventoryStatus",comboBox3.SelectedItem);
                    cmd.Parameters.AddWithValue("@EstimatedDelivery", Convert.ToInt32(Vdelivery.Text));
                    cmd.Parameters.AddWithValue("@AmountOnHand", Convert.ToInt32(pamount.Text));
                    cmd.Parameters.AddWithValue("@AllowPerOrder",Convert.ToInt32(palloworder.Text));
                    cmd.Parameters.AddWithValue("@WarrentyPeriod", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@ProductType",comboBox4.SelectedItem);
                     cmd.Parameters.AddWithValue("@PDate",dateTimePicker1.Value.Date);
                   

                    cmd.ExecuteNonQuery();


                    mc.conn.Close();

                    DialogResult rs = MessageBox.Show("Product Successfully Registred !");




                    if (rs == DialogResult.OK)
                    {
                        p_id.Text = "";
                        pname.Text = "";

                       

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
