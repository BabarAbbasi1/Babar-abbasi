namespace Inventory_management_System
{
    partial class invoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ddate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ptotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pquantity = new System.Windows.Forms.TextBox();
            this.pname1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.INV_ID = new System.Windows.Forms.TextBox();
            this.po = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.vname = new System.Windows.Forms.TextBox();
            this.vid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vcontact = new System.Windows.Forms.TextBox();
            this.vcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vgroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(91, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.ddate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.ptotal);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.pquantity);
            this.panel4.Controls.Add(this.pname1);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(484, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 407);
            this.panel4.TabIndex = 143;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(38, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 136;
            this.label12.Text = "Delivery Date";
            // 
            // ddate
            // 
            this.ddate.Location = new System.Drawing.Point(199, 117);
            this.ddate.Multiline = true;
            this.ddate.Name = "ddate";
            this.ddate.ReadOnly = true;
            this.ddate.Size = new System.Drawing.Size(140, 23);
            this.ddate.TabIndex = 137;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 34);
            this.button1.TabIndex = 135;
            this.button1.Text = "Generate Invoice!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 300);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(106, 25);
            this.textBox3.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(40, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "Total Amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 252);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(104, 25);
            this.textBox2.TabIndex = 132;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(40, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 131;
            this.label10.Text = "TAX ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(40, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 25);
            this.label18.TabIndex = 122;
            this.label18.Text = "Product ID";
            // 
            // ptotal
            // 
            this.ptotal.Location = new System.Drawing.Point(201, 208);
            this.ptotal.Multiline = true;
            this.ptotal.Name = "ptotal";
            this.ptotal.ReadOnly = true;
            this.ptotal.Size = new System.Drawing.Size(104, 25);
            this.ptotal.TabIndex = 121;
            this.ptotal.TextChanged += new System.EventHandler(this.ptotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(40, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 120;
            this.label9.Text = "Product Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 23);
            this.textBox1.TabIndex = 130;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(40, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 25);
            this.label19.TabIndex = 124;
            this.label19.Text = "Product Name";
            // 
            // pquantity
            // 
            this.pquantity.Location = new System.Drawing.Point(201, 165);
            this.pquantity.Multiline = true;
            this.pquantity.Name = "pquantity";
            this.pquantity.ReadOnly = true;
            this.pquantity.Size = new System.Drawing.Size(104, 23);
            this.pquantity.TabIndex = 129;
            // 
            // pname1
            // 
            this.pname1.Location = new System.Drawing.Point(201, 74);
            this.pname1.Multiline = true;
            this.pname1.Name = "pname1";
            this.pname1.ReadOnly = true;
            this.pname1.Size = new System.Drawing.Size(138, 23);
            this.pname1.TabIndex = 125;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(40, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 25);
            this.label21.TabIndex = 128;
            this.label21.Text = "Quantity";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.INV_ID);
            this.panel3.Controls.Add(this.po);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(120, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 134);
            this.panel3.TabIndex = 142;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(13, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 120;
            this.label13.Text = "Receving  Date";
            // 
            // INV_ID
            // 
            this.INV_ID.Location = new System.Drawing.Point(161, 23);
            this.INV_ID.Multiline = true;
            this.INV_ID.Name = "INV_ID";
            this.INV_ID.ReadOnly = true;
            this.INV_ID.Size = new System.Drawing.Size(119, 24);
            this.INV_ID.TabIndex = 116;
            // 
            // po
            // 
            this.po.Location = new System.Drawing.Point(161, 63);
            this.po.Multiline = true;
            this.po.Name = "po";
            this.po.ReadOnly = true;
            this.po.Size = new System.Drawing.Size(119, 24);
            this.po.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 117;
            this.label6.Text = "Invoice ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 119;
            this.label1.Text = "P O ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.vname);
            this.panel2.Controls.Add(this.vid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.vcontact);
            this.panel2.Controls.Add(this.vcode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.vgroup);
            this.panel2.Location = new System.Drawing.Point(120, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 267);
            this.panel2.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 135;
            this.label7.Text = "Vendor ID";
            // 
            // vname
            // 
            this.vname.Location = new System.Drawing.Point(161, 21);
            this.vname.Multiline = true;
            this.vname.Name = "vname";
            this.vname.ReadOnly = true;
            this.vname.Size = new System.Drawing.Size(119, 24);
            this.vname.TabIndex = 131;
            // 
            // vid
            // 
            this.vid.Location = new System.Drawing.Point(161, 67);
            this.vid.Multiline = true;
            this.vid.Name = "vid";
            this.vid.ReadOnly = true;
            this.vid.Size = new System.Drawing.Size(119, 23);
            this.vid.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 132;
            this.label2.Text = "Vendor Name";
            // 
            // vcontact
            // 
            this.vcontact.Location = new System.Drawing.Point(161, 209);
            this.vcontact.Multiline = true;
            this.vcontact.Name = "vcontact";
            this.vcontact.ReadOnly = true;
            this.vcontact.Size = new System.Drawing.Size(148, 25);
            this.vcontact.TabIndex = 134;
            // 
            // vcode
            // 
            this.vcode.Location = new System.Drawing.Point(161, 160);
            this.vcode.Multiline = true;
            this.vcode.Name = "vcode";
            this.vcode.ReadOnly = true;
            this.vcode.Size = new System.Drawing.Size(148, 23);
            this.vcode.TabIndex = 139;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(13, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 133;
            this.label8.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 138;
            this.label4.Text = "Vendor Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 136;
            this.label5.Text = "Vendor Group";
            // 
            // vgroup
            // 
            this.vgroup.Location = new System.Drawing.Point(161, 114);
            this.vgroup.Multiline = true;
            this.vgroup.Name = "vgroup";
            this.vgroup.ReadOnly = true;
            this.vgroup.Size = new System.Drawing.Size(148, 23);
            this.vgroup.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(381, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 114;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1199, 632);
            this.Controls.Add(this.panel1);
            this.Name = "invoice";
            this.Text = "-++++++";
            this.Load += new System.EventHandler(this.invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox INV_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox po;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pquantity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox pname1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vid;
        private System.Windows.Forms.TextBox vcontact;
        private System.Windows.Forms.TextBox vcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vgroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox ptotal;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ddate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
    }
}