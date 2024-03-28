namespace atestat1
{
    partial class Inregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crearenumeTxt = new System.Windows.Forms.TextBox();
            this.creareprenumeTxt = new System.Windows.Forms.TextBox();
            this.creareemailTxt = new System.Windows.Forms.TextBox();
            this.creareusernameTxt = new System.Windows.Forms.TextBox();
            this.creareparolaTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.crearecodTxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.db1DataSet = new atestat1.db1DataSet();
            this.punctajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punctajTableAdapter = new atestat1.db1DataSetTableAdapters.punctajTableAdapter();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new atestat1.db1DataSetTableAdapters.UtilizatoriTableAdapter();
            this.intrebareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrebareTableAdapter = new atestat1.db1DataSetTableAdapters.intrebareTableAdapter();
            this.confirmareparolaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parola(cel puțin 4 caractere):";
            // 
            // crearenumeTxt
            // 
            this.crearenumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crearenumeTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearenumeTxt.Location = new System.Drawing.Point(10, 48);
            this.crearenumeTxt.Name = "crearenumeTxt";
            this.crearenumeTxt.Size = new System.Drawing.Size(174, 15);
            this.crearenumeTxt.TabIndex = 5;
            // 
            // creareprenumeTxt
            // 
            this.creareprenumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creareprenumeTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareprenumeTxt.Location = new System.Drawing.Point(10, 87);
            this.creareprenumeTxt.Name = "creareprenumeTxt";
            this.creareprenumeTxt.Size = new System.Drawing.Size(174, 15);
            this.creareprenumeTxt.TabIndex = 6;
            // 
            // creareemailTxt
            // 
            this.creareemailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creareemailTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareemailTxt.Location = new System.Drawing.Point(10, 126);
            this.creareemailTxt.Name = "creareemailTxt";
            this.creareemailTxt.Size = new System.Drawing.Size(174, 15);
            this.creareemailTxt.TabIndex = 7;
            // 
            // creareusernameTxt
            // 
            this.creareusernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creareusernameTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareusernameTxt.Location = new System.Drawing.Point(10, 160);
            this.creareusernameTxt.Name = "creareusernameTxt";
            this.creareusernameTxt.Size = new System.Drawing.Size(174, 15);
            this.creareusernameTxt.TabIndex = 8;
            // 
            // creareparolaTxt
            // 
            this.creareparolaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creareparolaTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareparolaTxt.Location = new System.Drawing.Point(10, 194);
            this.creareparolaTxt.Name = "creareparolaTxt";
            this.creareparolaTxt.PasswordChar = '*';
            this.creareparolaTxt.Size = new System.Drawing.Size(174, 15);
            this.creareparolaTxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(60, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Creare cont";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(100, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Spre logare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cod modificare(codul trebuie să fie de exact 4 cifre):";
            // 
            // crearecodTxt
            // 
            this.crearecodTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crearecodTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearecodTxt.Location = new System.Drawing.Point(8, 260);
            this.crearecodTxt.Name = "crearecodTxt";
            this.crearecodTxt.Size = new System.Drawing.Size(176, 15);
            this.crearecodTxt.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.Location = new System.Drawing.Point(248, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 22);
            this.button3.TabIndex = 15;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // db1DataSet
            // 
            this.db1DataSet.DataSetName = "db1DataSet";
            this.db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punctajBindingSource
            // 
            this.punctajBindingSource.DataMember = "punctaj";
            this.punctajBindingSource.DataSource = this.db1DataSet;
            // 
            // punctajTableAdapter
            // 
            this.punctajTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.db1DataSet;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // intrebareBindingSource
            // 
            this.intrebareBindingSource.DataMember = "intrebare";
            this.intrebareBindingSource.DataSource = this.db1DataSet;
            // 
            // intrebareTableAdapter
            // 
            this.intrebareTableAdapter.ClearBeforeFill = true;
            // 
            // confirmareparolaTxt
            // 
            this.confirmareparolaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmareparolaTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmareparolaTxt.Location = new System.Drawing.Point(10, 228);
            this.confirmareparolaTxt.Name = "confirmareparolaTxt";
            this.confirmareparolaTxt.PasswordChar = '*';
            this.confirmareparolaTxt.Size = new System.Drawing.Size(174, 15);
            this.confirmareparolaTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirmare parolă:\r\n";
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(285, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmareparolaTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.crearecodTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creareparolaTxt);
            this.Controls.Add(this.creareusernameTxt);
            this.Controls.Add(this.creareemailTxt);
            this.Controls.Add(this.creareprenumeTxt);
            this.Controls.Add(this.crearenumeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox crearenumeTxt;
        private System.Windows.Forms.TextBox creareprenumeTxt;
        private System.Windows.Forms.TextBox creareemailTxt;
        private System.Windows.Forms.TextBox creareusernameTxt;
        private System.Windows.Forms.TextBox creareparolaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox crearecodTxt;
        private System.Windows.Forms.Button button3;
        private db1DataSet db1DataSet;
        private System.Windows.Forms.BindingSource punctajBindingSource;
        private db1DataSetTableAdapters.punctajTableAdapter punctajTableAdapter;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private db1DataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource intrebareBindingSource;
        private db1DataSetTableAdapters.intrebareTableAdapter intrebareTableAdapter;
        private System.Windows.Forms.TextBox confirmareparolaTxt;
        private System.Windows.Forms.Label label6;
    }
}