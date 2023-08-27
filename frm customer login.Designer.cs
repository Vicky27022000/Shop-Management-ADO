namespace shopy
{
    partial class order
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
            this.Product = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.totala = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd)).BeginInit();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(133, 213);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 34);
            this.Product.TabIndex = 4;
            this.Product.Text = "Product";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(319, 129);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(153, 28);
            this.cmbtype.TabIndex = 5;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype1_SelectedIndexChanged);
            // 
            // cmbproduct
            // 
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(319, 219);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(153, 28);
            this.cmbproduct.TabIndex = 6;
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type";
            // 
            // gd
            // 
            this.gd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd.Location = new System.Drawing.Point(96, 324);
            this.gd.Name = "gd";
            this.gd.RowHeadersWidth = 62;
            this.gd.RowTemplate.Height = 28;
            this.gd.Size = new System.Drawing.Size(376, 184);
            this.gd.TabIndex = 8;
            this.gd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 71);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order Imformation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price :";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(336, 566);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 26);
            this.txtprice.TabIndex = 11;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Lime;
            this.log.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(180, 617);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(160, 66);
            this.log.TabIndex = 12;
            this.log.Text = "Log Out";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(406, 617);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 66);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(765, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(533, 348);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(199, 70);
            this.add.TabIndex = 17;
            this.add.Text = "Add to Card";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button3_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Khaki;
            this.Remove.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(533, 442);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(160, 66);
            this.Remove.TabIndex = 18;
            this.Remove.Text = "Remove from chart";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.LightSalmon;
            this.Confirm.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(933, 601);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(178, 66);
            this.Confirm.TabIndex = 19;
            this.Confirm.Text = "Order Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // totala
            // 
            this.totala.BackColor = System.Drawing.Color.LemonChiffon;
            this.totala.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totala.Location = new System.Drawing.Point(791, 533);
            this.totala.Name = "totala";
            this.totala.Size = new System.Drawing.Size(194, 38);
            this.totala.TabIndex = 20;
            this.totala.Text = "Total Amount :";
            this.totala.UseVisualStyleBackColor = false;
            this.totala.Click += new System.EventHandler(this.totala_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(791, 337);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 171);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(1012, 542);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(150, 26);
            this.txttotal.TabIndex = 22;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(933, 243);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(150, 26);
            this.txtemail.TabIndex = 23;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(933, 157);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(150, 26);
            this.txtphone.TabIndex = 24;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(933, 68);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 26);
            this.txtname.TabIndex = 25;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1456, 752);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.totala);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.log);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbproduct);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.Product);
            this.Name = "order";
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button totala;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
    }
}