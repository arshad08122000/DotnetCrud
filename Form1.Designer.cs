namespace CRUD
{
    partial class CRUDForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDForm));
            this.headtag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nametag = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.nametagpanel = new System.Windows.Forms.Panel();
            this.RegisterTag = new System.Windows.Forms.Label();
            this.comboBoxregno = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phonenotag = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxphoneno = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gendertag = new System.Windows.Forms.Label();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewdetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxminimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headtag
            // 
            this.headtag.Location = new System.Drawing.Point(37, 17);
            this.headtag.Name = "headtag";
            this.headtag.Size = new System.Drawing.Size(44, 26);
            this.headtag.TabIndex = 1;
            this.headtag.Text = "CRUD ";
            this.headtag.Click += new System.EventHandler(this.headtag_Click);
            this.headtag.MouseHover += new System.EventHandler(this.headtag_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(126, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 27);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Nametag
            // 
            this.Nametag.AutoSize = true;
            this.Nametag.Location = new System.Drawing.Point(106, 100);
            this.Nametag.Name = "Nametag";
            this.Nametag.Size = new System.Drawing.Size(35, 13);
            this.Nametag.TabIndex = 5;
            this.Nametag.Text = "Name";
            // 
            // textBoxname
            // 
            this.textBoxname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxname.Location = new System.Drawing.Point(109, 127);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(255, 13);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // nametagpanel
            // 
            this.nametagpanel.BackColor = System.Drawing.Color.LightGray;
            this.nametagpanel.Location = new System.Drawing.Point(109, 142);
            this.nametagpanel.Name = "nametagpanel";
            this.nametagpanel.Size = new System.Drawing.Size(254, 1);
            this.nametagpanel.TabIndex = 0;
            // 
            // RegisterTag
            // 
            this.RegisterTag.AutoSize = true;
            this.RegisterTag.Location = new System.Drawing.Point(511, 100);
            this.RegisterTag.Name = "RegisterTag";
            this.RegisterTag.Size = new System.Drawing.Size(63, 13);
            this.RegisterTag.TabIndex = 6;
            this.RegisterTag.Text = "Register No";
            // 
            // comboBoxregno
            // 
            this.comboBoxregno.DisplayMember = "12323";
            this.comboBoxregno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxregno.FormattingEnabled = true;
            this.comboBoxregno.ItemHeight = 13;
            this.comboBoxregno.Items.AddRange(new object[] {
            "123456",
            "988765",
            "1298",
            "123197",
            "1298736",
            "18265"});
            this.comboBoxregno.Location = new System.Drawing.Point(514, 119);
            this.comboBoxregno.Name = "comboBoxregno";
            this.comboBoxregno.Size = new System.Drawing.Size(152, 21);
            this.comboBoxregno.TabIndex = 2;
            this.comboBoxregno.ValueMember = "321313";
            this.comboBoxregno.SelectedIndexChanged += new System.EventHandler(this.comboBoxregno_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(514, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 1);
            this.panel2.TabIndex = 7;
            // 
            // phonenotag
            // 
            this.phonenotag.AutoSize = true;
            this.phonenotag.Location = new System.Drawing.Point(106, 181);
            this.phonenotag.Name = "phonenotag";
            this.phonenotag.Size = new System.Drawing.Size(55, 13);
            this.phonenotag.TabIndex = 8;
            this.phonenotag.Text = "Phone No";
            this.phonenotag.Click += new System.EventHandler(this.phonenotag_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(109, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 1);
            this.panel3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "+11",
            "+100",
            "+111",
            "+91",
            "00",
            "+00",
            "+000"});
            this.comboBox1.Location = new System.Drawing.Point(109, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(165, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 1);
            this.panel4.TabIndex = 11;
            // 
            // textBoxphoneno
            // 
            this.textBoxphoneno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxphoneno.Location = new System.Drawing.Point(165, 221);
            this.textBoxphoneno.Name = "textBoxphoneno";
            this.textBoxphoneno.Size = new System.Drawing.Size(255, 13);
            this.textBoxphoneno.TabIndex = 1;
            this.textBoxphoneno.TextChanged += new System.EventHandler(this.textBoxphoneno_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(109, 323);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 1);
            this.panel5.TabIndex = 12;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxaddress.Location = new System.Drawing.Point(109, 308);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(470, 13);
            this.textBoxaddress.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Address";
            // 
            // Gendertag
            // 
            this.Gendertag.AutoSize = true;
            this.Gendertag.Location = new System.Drawing.Point(106, 369);
            this.Gendertag.Name = "Gendertag";
            this.Gendertag.Size = new System.Drawing.Size(42, 13);
            this.Gendertag.TabIndex = 15;
            this.Gendertag.Text = "Gender";
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Location = new System.Drawing.Point(237, 369);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonmale.TabIndex = 8;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Location = new System.Drawing.Point(331, 369);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonfemale.TabIndex = 16;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // buttoninsert
            // 
            this.buttoninsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttoninsert.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttoninsert.FlatAppearance.BorderSize = 0;
            this.buttoninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttoninsert.Location = new System.Drawing.Point(289, 447);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(75, 23);
            this.buttoninsert.TabIndex = 17;
            this.buttoninsert.Text = "INSERT";
            this.buttoninsert.UseVisualStyleBackColor = false;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(445, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(107, 557);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 1);
            this.panel6.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(109, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 13);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reigster No";
            // 
            // dataGridViewdetails
            // 
            this.dataGridViewdetails.AllowUserToAddRows = false;
            this.dataGridViewdetails.AllowUserToDeleteRows = false;
            this.dataGridViewdetails.AllowUserToOrderColumns = true;
            this.dataGridViewdetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5});
            this.dataGridViewdetails.Location = new System.Drawing.Point(126, 574);
            this.dataGridViewdetails.MultiSelect = false;
            this.dataGridViewdetails.Name = "dataGridViewdetails";
            this.dataGridViewdetails.ReadOnly = true;
            this.dataGridViewdetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewdetails.ShowEditingIcon = false;
            this.dataGridViewdetails.Size = new System.Drawing.Size(590, 129);
            this.dataGridViewdetails.TabIndex = 28;
            this.dataGridViewdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 104;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Student_Register";
            this.Column4.HeaderText = "Register No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 106;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Address";
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Student_Gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 107;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(755, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(177, 443);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 27);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(363, 530);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 24);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBoxminimize
            // 
            this.pictureBoxminimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxminimize.Image")));
            this.pictureBoxminimize.Location = new System.Drawing.Point(722, 10);
            this.pictureBoxminimize.Name = "pictureBoxminimize";
            this.pictureBoxminimize.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxminimize.TabIndex = 4;
            this.pictureBoxminimize.TabStop = false;
            this.pictureBoxminimize.Click += new System.EventHandler(this.pictureBoxminimize_Click);
            this.pictureBoxminimize.MouseHover += new System.EventHandler(this.pictureBoxminimize_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(591, 447);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(234, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Operation Form";
            // 
            // CRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewdetails);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.Gendertag);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxphoneno);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.phonenotag);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxregno);
            this.Controls.Add(this.RegisterTag);
            this.Controls.Add(this.nametagpanel);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.Nametag);
            this.Controls.Add(this.pictureBoxminimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headtag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD OPERATIONS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headtag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxminimize;
        private System.Windows.Forms.Label Nametag;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Panel nametagpanel;
        private System.Windows.Forms.Label RegisterTag;
        private System.Windows.Forms.ComboBox comboBoxregno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label phonenotag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxphoneno;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Gendertag;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridViewdetails;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

