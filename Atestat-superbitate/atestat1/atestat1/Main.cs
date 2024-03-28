using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace atestat1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codulrutier f4 = new codulrutier();
            f4.Show();
            Visible = false;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mediudeinvatare f5 = new mediudeinvatare();
            f5.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login f14 = new Login();
            f14.Show();
            Visible = false;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            examen f50 = new examen();
            f50.Show();
            Visible = false;
        }
    }
}
