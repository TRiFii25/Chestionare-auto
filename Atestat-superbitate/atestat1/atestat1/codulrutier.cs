using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace atestat1
{
    public partial class codulrutier : Form
    {
        public codulrutier()
        {
            InitializeComponent();
            System.IO.Directory.SetCurrentDirectory(Variabile.cale);
            axAcroPDF1.LoadFile(Variabile.cale + "\\pdf\\curs_legislatie.pdf");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Variabile.cale + "\\pdf";
            ofd.FileName = "";
            ofd.Filter="Fisiere pdf (*.pdf) |*.pdf|"+"All files(*.*)|*.*";
            
            string fisier_selectat = ofd.FileName;      
        }

        

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    
        //}

        

        private void button2_Click(object sender, EventArgs e)
        {
            Main f11 = new Main();
            f11.Show();
            Visible = false;
        }
    }
}
