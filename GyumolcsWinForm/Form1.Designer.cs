namespace GyumolcsWinForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_ar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_azonsosito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox_Gyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_modify);
            this.groupBox1.Controls.Add(this.dateTimePicker_datum);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_ar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_db);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.textBox_azonsosito);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(143, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gyümölcsök adatai";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(46, 341);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(185, 32);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(46, 291);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(185, 32);
            this.button_modify.TabIndex = 11;
            this.button_modify.Text = "Módosít";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Location = new System.Drawing.Point(107, 176);
            this.dateTimePicker_datum.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_datum.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker_datum.TabIndex = 10;
            this.dateTimePicker_datum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(46, 232);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(185, 32);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Új gyümölcs";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_ar
            // 
            this.textBox_ar.Location = new System.Drawing.Point(111, 104);
            this.textBox_ar.Name = "textBox_ar";
            this.textBox_ar.Size = new System.Drawing.Size(114, 20);
            this.textBox_ar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Azonosító";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(111, 140);
            this.numericUpDown_db.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_db.TabIndex = 6;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(111, 67);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(114, 20);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_azonsosito
            // 
            this.textBox_azonsosito.Location = new System.Drawing.Point(111, 30);
            this.textBox_azonsosito.Name = "textBox_azonsosito";
            this.textBox_azonsosito.ReadOnly = true;
            this.textBox_azonsosito.Size = new System.Drawing.Size(114, 20);
            this.textBox_azonsosito.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dátum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ár";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox_Gyumolcsok
            // 
            this.listBox_Gyumolcsok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Gyumolcsok.FormattingEnabled = true;
            this.listBox_Gyumolcsok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Gyumolcsok.Name = "listBox_Gyumolcsok";
            this.listBox_Gyumolcsok.Size = new System.Drawing.Size(143, 398);
            this.listBox_Gyumolcsok.TabIndex = 2;
            this.listBox_Gyumolcsok.SelectedIndexChanged += new System.EventHandler(this.listBox_Gyumolcsok_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 398);
            this.Controls.Add(this.listBox_Gyumolcsok);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_azonsosito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.ListBox listBox_Gyumolcsok;
    }
}

