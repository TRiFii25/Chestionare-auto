using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atestat1
{

    public partial class Login : Form
    {
        public string user { get; set; }
        public int ok;
        public static string SetValueForText1 = "";
        

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.intrebare' table. You can move, or remove it, as needed.
            this.intrebareTableAdapter.Fill(this.db1DataSet.intrebare);
            // TODO: This line of code loads data into the 'db1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.db1DataSet.Utilizatori);
            // TODO: This line of code loads data into the 'db1DataSet.punctaj' table. You can move, or remove it, as needed.
            this.punctajTableAdapter.Fill(this.db1DataSet.punctaj);
            // TODO: This line of code loads data into the 'db1DataSet.intrebari' table. You can move, or remove it, as needed.
            db1DataSet.EnforceConstraints = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok = 0;
            db1DataSet.UtilizatoriDataTable dt = utilizatoriTableAdapter.GetDataByCredentials(usernameTxt.Text, parolaTxt.Text);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("V-ați autentificat cu succes!","Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ok = 1;
                user = usernameTxt.ToString();
                
                SetValueForText1 = usernameTxt.Text;
                Main f3 = new Main();
                f3.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Username-ul și sau parola sunt incorecte!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();
                
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inregistrare f2 = new Inregistrare();
            f2.Show();
            Visible = false;
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                parolaTxt.PasswordChar = '\0';
            }
            else
            {
                parolaTxt.PasswordChar = '*';
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
