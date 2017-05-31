namespace Inventory_management_System
{
    partial class Product
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
            this.pprice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.palloworder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Vdelivery = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pprice
            // 
            this.pprice.Location = new System.Drawing.Point(689, 232);
            this.pprice.Multiline = true;
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(178, 26);
            this.pprice.TabIndex = 93;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6 Months",
            "1 year",
            "3 year ",
            "5 year",
            "10 year",
            "Life Time",
            "No warranty"});
            this.comboBox1.Location = new System.Drawing.Point(689, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(370, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 36);
            this.label14.TabIndex = 89;
            this.label14.Text = "Produts Entry Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 88;
            this.button1.Text = "ADD Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(93, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Inventory Status";
            // 
            // palloworder
            // 
            this.palloworder.Location = new System.Drawing.Point(689, 169);
            this.palloworder.Multiline = true;
            this.palloworder.Name = "palloworder";
            this.palloworder.Size = new System.Drawing.Size(178, 25);
            this.palloworder.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(518, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Allow Per Order";
            // 
            // Vdelivery
            // 
            this.Vdelivery.Location = new System.Drawing.Point(284, 347);
            this.Vdelivery.Multiline = true;
            this.Vdelivery.Name = "Vdelivery";
            this.Vdelivery.Size = new System.Drawing.Size(157, 25);
            this.Vdelivery.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(93, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 78;
            this.label11.Text = "EstimatedDelivery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(93, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 77;
            this.label12.Text = "Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(518, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Product Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(518, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "WarrentyPeriod";
            // 
            // pamount
            // 
            this.pamount.Location = new System.Drawing.Point(689, 110);
            this.pamount.Multiline = true;
            this.pamount.Name = "pamount";
            this.pamount.Size = new System.Drawing.Size(178, 25);
            this.pamount.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(518, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 71;
            this.label6.Text = "Amount On Hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(518, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Price";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(284, 166);
            this.pname.Multiline = true;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(157, 25);
            this.pname.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(93, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Product Name";
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(284, 107);
            this.p_id.Multiline = true;
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Size = new System.Drawing.Size(104, 23);
            this.p_id.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Product ID";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "In Hand",
            "Not in Hand"});
            this.comboBox3.Location = new System.Drawing.Point(284, 296);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(157, 21);
            this.comboBox3.TabIndex = 94;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Hand_Made",
            "Water Purifier",
            "Hair Cutter",
            "Turbo Batteries",
            "Accessories",
            "Chargers",
            "Replacment Parts",
            "Quantum Batteries",
            "Accessories",
            "Chargers",
            "Studio Power",
            "Flash Kits"});
            this.comboBox4.Location = new System.Drawing.Point(689, 354);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(178, 21);
            this.comboBox4.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.p_id);
            this.panel1.Controls.Add(this.pprice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pamount);
            this.panel1.Controls.Add(this.palloworder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Vdelivery);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(92, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 485);
            this.panel1.TabIndex = 96;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 632);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox palloworder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Vdelivery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel panel1;
    }
}