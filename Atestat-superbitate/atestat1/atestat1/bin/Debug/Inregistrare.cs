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
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            Visible = false;
            
        }
        public bool verificare(string a)
        {
            bool ok = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > '9' || a[i] < '0')
                {
                    ok = false;
                }
            }
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 1;
            if (crearenumeTxt.Text == "" || creareprenumeTxt.Text == "" || creareemailTxt.Text == "" || creareusernameTxt.Text == "" || creareparolaTxt.Text == "" || crearecodTxt.Text == "" || confirmareparolaTxt.Text=="")
            {
                MessageBox.Show("Unul dintre câmpurile obiligatorii este necompletat!", "Înregistrarea nu a fost realizată!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok=0;
            }
            if (utilizatoriTableAdapter.aflareutilizator(creareusernameTxt.Text) != null)
            {
                MessageBox.Show("Există deja un utilizator cu acest nume!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if (creareparolaTxt.Text.Length < 4)
            {
                MessageBox.Show("Parola nu este suficient de lungă!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if (creareparolaTxt.Text != confirmareparolaTxt.Text)
            {
                MessageBox.Show("Parolele nu coincid!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if (crearecodTxt.Text.Length != 4)
            {
                MessageBox.Show("Codul nu este de exact 4 cifre!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if ( verificare(crearecodTxt.Text) == false)
            {
                MessageBox.Show("Codul nu conține doar cifre!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = 0;
            }
            if (ok == 1)
            {
               MessageBox.Show("Crearea contului a avut loc cu succes!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int id=int.Parse(utilizatoriTableAdapter.maximm().ToString())+1;
            utilizatoriTableAdapter.inregistrare((crearenumeTxt.Text).ToString(), (creareprenumeTxt.Text).ToString(), (creareemailTxt.Text).ToString(), (creareusernameTxt.Text).ToString(), (creareparolaTxt.Text).ToString(),"0", "0", "0", "0", id, "0");
            punctajTableAdapter.insertpunctaj("0", "0", id);
            punctajTableAdapter.Update(db1DataSet.punctaj);
            utilizatoriTableAdapter.Update(db1DataSet.Utilizatori);
            this.Update();
            Login f20 = new Login();
            f20.Show();
            Visible = false;
            }                   
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.intrebare' table. You can move, or remove it, as needed.
            this.intrebareTableAdapter.Fill(this.db1DataSet.intrebare);
            // TODO: This line of code loads data into the 'db1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.db1DataSet.Utilizatori);
            // TODO: This line of code loads data into the 'db1DataSet.punctaj' table. You can move, or remove it, as needed.
            this.punctajTableAdapter.Fill(this.db1DataSet.punctaj);
            // TODO: This line of code loads data into the 'db1DataSet.intrebari' table. You can move, or remove it, as needed.        
            // TODO: This line of code loads data into the 'db1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.db1DataSet.Utilizatori);
            db1DataSet.EnforceConstraints = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


        
    }
}
