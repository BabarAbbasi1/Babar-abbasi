using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management_System
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
            create_Account data = new create_Account();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_window_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerEnrtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_entry data = new customer_entry();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void approveCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status__approve data = new status__approve();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GRN  data = new GRN();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void venderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Vender data = new ADD_Vender();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void productsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product data = new Product();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void customerUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customer_search data = new customer_search();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void approvePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            po_approvence data = new po_approvence();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            product_order data = new product_order();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice data = new invoice();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void sALEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_order data = new Sale_order();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void aPPROVEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            po_approvence data = new po_approvence();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void cHALLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_challan data = new sales_challan();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }

        private void sALEINVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sale_Invoice data = new sale_Invoice();
            data.MdiParent = this;
            data.Dock = DockStyle.Fill;
            data.FormBorderStyle = FormBorderStyle.None;
            data.Show();
        }
    }
}
