namespace Inventory_management_System
{
    partial class main_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerEnrtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerUpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvePurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALEORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPPROVEORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHALLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALEINVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.approvanceToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.purchaseOrderToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerEnrtyToolStripMenuItem,
            this.customerUpdateToolStripMenuItem,
            this.customerUpdateToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // customerEnrtyToolStripMenuItem
            // 
            this.customerEnrtyToolStripMenuItem.Name = "customerEnrtyToolStripMenuItem";
            this.customerEnrtyToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.customerEnrtyToolStripMenuItem.Text = "Customer Enrty";
            this.customerEnrtyToolStripMenuItem.Click += new System.EventHandler(this.customerEnrtyToolStripMenuItem_Click);
            // 
            // customerUpdateToolStripMenuItem
            // 
            this.customerUpdateToolStripMenuItem.Name = "customerUpdateToolStripMenuItem";
            this.customerUpdateToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.customerUpdateToolStripMenuItem.Text = "Customer Update";
            // 
            // customerUpdateToolStripMenuItem1
            // 
            this.customerUpdateToolStripMenuItem1.Name = "customerUpdateToolStripMenuItem1";
            this.customerUpdateToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.customerUpdateToolStripMenuItem1.Text = "Customer Search";
            this.customerUpdateToolStripMenuItem1.Click += new System.EventHandler(this.customerUpdateToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // approvanceToolStripMenuItem
            // 
            this.approvanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveCustomerToolStripMenuItem,
            this.approvePurchaseOrderToolStripMenuItem});
            this.approvanceToolStripMenuItem.Name = "approvanceToolStripMenuItem";
            this.approvanceToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.approvanceToolStripMenuItem.Text = "Approvance";
            // 
            // approveCustomerToolStripMenuItem
            // 
            this.approveCustomerToolStripMenuItem.Name = "approveCustomerToolStripMenuItem";
            this.approveCustomerToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.approveCustomerToolStripMenuItem.Text = "Approve Customer ";
            this.approveCustomerToolStripMenuItem.Click += new System.EventHandler(this.approveCustomerToolStripMenuItem_Click);
            // 
            // approvePurchaseOrderToolStripMenuItem
            // 
            this.approvePurchaseOrderToolStripMenuItem.Name = "approvePurchaseOrderToolStripMenuItem";
            this.approvePurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.approvePurchaseOrderToolStripMenuItem.Text = "PO Approvence ";
            this.approvePurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.approvePurchaseOrderToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderEntryToolStripMenuItem,
            this.searchVenderToolStripMenuItem,
            this.venderDeleteToolStripMenuItem});
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // venderEntryToolStripMenuItem
            // 
            this.venderEntryToolStripMenuItem.Name = "venderEntryToolStripMenuItem";
            this.venderEntryToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.venderEntryToolStripMenuItem.Text = "Vender Entry";
            this.venderEntryToolStripMenuItem.Click += new System.EventHandler(this.venderEntryToolStripMenuItem_Click);
            // 
            // searchVenderToolStripMenuItem
            // 
            this.searchVenderToolStripMenuItem.Name = "searchVenderToolStripMenuItem";
            this.searchVenderToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.searchVenderToolStripMenuItem.Text = "Search Vender";
            // 
            // venderDeleteToolStripMenuItem
            // 
            this.venderDeleteToolStripMenuItem.Name = "venderDeleteToolStripMenuItem";
            this.venderDeleteToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.venderDeleteToolStripMenuItem.Text = "Vender Delete";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsEntryToolStripMenuItem,
            this.productUpdateToolStripMenuItem,
            this.productSearchToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // productsEntryToolStripMenuItem
            // 
            this.productsEntryToolStripMenuItem.Name = "productsEntryToolStripMenuItem";
            this.productsEntryToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.productsEntryToolStripMenuItem.Text = "Products Entry";
            this.productsEntryToolStripMenuItem.Click += new System.EventHandler(this.productsEntryToolStripMenuItem_Click);
            // 
            // productUpdateToolStripMenuItem
            // 
            this.productUpdateToolStripMenuItem.Name = "productUpdateToolStripMenuItem";
            this.productUpdateToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.productUpdateToolStripMenuItem.Text = "Product Update";
            // 
            // productSearchToolStripMenuItem
            // 
            this.productSearchToolStripMenuItem.Name = "productSearchToolStripMenuItem";
            this.productSearchToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.productSearchToolStripMenuItem.Text = "Product Search";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 26);
            this.toolStripMenuItem1.Text = "Order";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem2.Text = "DO Order";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem3.Text = "Purchase Order";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem4.Text = "Purchase Order";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem5.Text = "Order Search";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem6.Text = "Order Search";
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem1});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.purchaseOrderToolStripMenuItem.Text = "GRN";
            // 
            // purchaseOrderToolStripMenuItem1
            // 
            this.purchaseOrderToolStripMenuItem1.Name = "purchaseOrderToolStripMenuItem1";
            this.purchaseOrderToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.purchaseOrderToolStripMenuItem1.Text = "Generate GRN";
            this.purchaseOrderToolStripMenuItem1.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem1_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createInvoiceToolStripMenuItem});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALEORDERToolStripMenuItem,
            this.aPPROVEORDERToolStripMenuItem,
            this.cHALLANToolStripMenuItem,
            this.sALEINVOICEToolStripMenuItem});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(137, 26);
            this.toolStripMenuItem7.Text = "SALES ORDER";
            // 
            // sALEORDERToolStripMenuItem
            // 
            this.sALEORDERToolStripMenuItem.Name = "sALEORDERToolStripMenuItem";
            this.sALEORDERToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sALEORDERToolStripMenuItem.Text = "SALE ORDER";
            this.sALEORDERToolStripMenuItem.Click += new System.EventHandler(this.sALEORDERToolStripMenuItem_Click);
            // 
            // aPPROVEORDERToolStripMenuItem
            // 
            this.aPPROVEORDERToolStripMenuItem.Name = "aPPROVEORDERToolStripMenuItem";
            this.aPPROVEORDERToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.aPPROVEORDERToolStripMenuItem.Text = "APPROVE ORDER";
            this.aPPROVEORDERToolStripMenuItem.Click += new System.EventHandler(this.aPPROVEORDERToolStripMenuItem_Click);
            // 
            // cHALLANToolStripMenuItem
            // 
            this.cHALLANToolStripMenuItem.Name = "cHALLANToolStripMenuItem";
            this.cHALLANToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.cHALLANToolStripMenuItem.Text = "CHALLAN";
            this.cHALLANToolStripMenuItem.Click += new System.EventHandler(this.cHALLANToolStripMenuItem_Click);
            // 
            // sALEINVOICEToolStripMenuItem
            // 
            this.sALEINVOICEToolStripMenuItem.Name = "sALEINVOICEToolStripMenuItem";
            this.sALEINVOICEToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sALEINVOICEToolStripMenuItem.Text = "SALE INVOICE";
            this.sALEINVOICEToolStripMenuItem.Click += new System.EventHandler(this.sALEINVOICEToolStripMenuItem_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 632);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E R P Managment Sys";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.main_window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerEnrtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerUpdateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem approvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvePurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchVenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem sALEORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPPROVEORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHALLANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALEINVOICEToolStripMenuItem;
    }
}