namespace Inventory_management_System
{
    partial class my_connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(my_connection));
            this.conn = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // conn
            // 
            this.conn.ConnectionString = resources.GetString("conn.ConnectionString");
            // 
            // my_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 300);
            this.Name = "my_connection";
            this.Text = "my_connection";
            this.Load += new System.EventHandler(this.my_connection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Data.OleDb.OleDbConnection conn;
    }
}