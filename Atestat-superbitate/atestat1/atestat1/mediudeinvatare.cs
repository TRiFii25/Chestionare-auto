using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace atestat1
{
    public partial class mediudeinvatare : Form
    {
        int idp=0;
        int indice = 1;
        int nrc = 0;
        int nrg = 0;
        

        public mediudeinvatare()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tabPage2;
            label1.Text = "";
            label7.Text ="";
            label9.Text ="";
            labelraspuns.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main f= new Main();
            f.Show();
            Visible=false;
        }
        

        

        private void mediudeinvatare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.intrebare' table. You can move, or remove it, as needed.
            this.intrebareTableAdapter.Fill(this.db1DataSet.intrebare);
            // TODO: This line of code loads data into the 'db1DataSet1.intrebare' table. You can move, or remove it, as needed.
            this.intrebareTableAdapter.Fill(this.db1DataSet1.intrebare);
            // TODO: This line of code loads data into the 'db1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.db1DataSet.Utilizatori);
            // TODO: This line of code loads data into the 'db1DataSet.punctaj' table. You can move, or remove it, as needed.
            this.punctajTableAdapter.Fill(this.db1DataSet.punctaj);
            // TODO: This line of code loads data into the 'db1DataSet.intrebari' table. You can move, or remove it, as needed.
            db1DataSet.EnforceConstraints = false;

        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            
            raspuns1.Text = "";
            raspuns2.Text = "";
            raspuns3.Text = "";
            
            tabControl1.SelectedTab = tabPage1;
            labelintrebare.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            checkBox1.Text = t.Rows[idp]["variantaA"].ToString();
            checkBox2.Text = t.Rows[idp]["variantaB"].ToString();
            checkBox3.Text = t.Rows[idp]["variantaC"].ToString();
                labelintrebare.Text = t.Rows[idp]["intrebare"].ToString();
                label11.Text = indice.ToString();
                if (t.Rows[idp]["pozaintrebare"].ToString().Length != 0)
                {
                    string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                    Bitmap image=new Bitmap(path+ "\\pozele\\" +t.Rows[idp]["pozaintrebare"].ToString());
                    pictureBox1.Visible=true;
                    pictureBox1.Image=(Image)image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image=null;
                }
 
                idp++;
            
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            raspuns1.Text = "";
            raspuns2.Text = "";
            raspuns3.Text = "";
            label7.Text = "";
            label9.Text = "";
            labelraspuns.Text = "";
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            
                int nr = 0;
                label1.Text = "";
                /*label1.Text += t.Rows[idp]["raspunsA"].ToString() +
                    " " + t.Rows[idp]["raspunsB"].ToString() + " " +
                    t.Rows[idp]["raspunsC"].ToString() + " " +
                    " " + t.Rows[idp]["nrcorecte"].ToString();*/
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    MessageBox.Show("Trebuie să selectați un răspuns!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        if (t.Rows[idp - 1]["raspunsA"].ToString() == "1")
                        {

                            nr++;

                        }
                        else
                            if (t.Rows[idp - 1]["raspunsA"].ToString() == "0")
                            {
                                nr--;
                            }
                    }

                    if (checkBox2.Checked == true)
                    {
                        if (t.Rows[idp - 1]["raspunsB"].ToString() == "1")
                        {
                            nr++;
                        }
                        else
                            if (t.Rows[idp - 1]["raspunsB"].ToString() == "0")
                            {
                                nr--;
                            }
                    }

                    if (checkBox3.Checked == true)
                    {
                        if (t.Rows[idp - 1]["raspunsC"].ToString() == "1")
                        {
                            nr++;
                        }
                        else
                            if (t.Rows[idp - 1]["raspunsC"].ToString() == "0")
                            {
                                nr--;
                            }
                    }

                    if (int.Parse(t.Rows[idp - 1]["nrcorecte"].ToString()) == nr)
                    {
                        labelraspuns.Text += "Ați răspuns corect!";
                        labelraspuns.ForeColor = System.Drawing.Color.Green;
                        nrc++;
                        label7.Text += nrc.ToString();
                        label9.Text += nrg.ToString();


                    }
                    else
                        if (int.Parse(t.Rows[idp - 1]["nrcorecte"].ToString()) != nr)
                        {

                            labelraspuns.Text += "Ați răspuns greșit!";
                            labelraspuns.ForeColor = System.Drawing.Color.Red;
                            nrg++;
                            label7.Text += nrc.ToString();
                            label9.Text += nrg.ToString();
                        }
                    if (t.Rows[idp - 1]["raspunsA"].ToString() == "1")
                    {
                        raspuns1.Text += "Acesta este răspunsul corect!";
                        raspuns1.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[idp - 1]["raspunsA"].ToString() == "0")
                    {
                        raspuns1.Text += "Acesta este răspunsul greșit!";
                        raspuns1.ForeColor = System.Drawing.Color.Red;
                    }
                    if (t.Rows[idp - 1]["raspunsB"].ToString() == "1")
                    {
                        raspuns2.Text += "Acesta este răspunsul corect!";
                        raspuns2.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[idp - 1]["raspunsB"].ToString() == "0")
                    {
                        raspuns2.Text += "Acesta este răspunsul greșit!";
                        raspuns2.ForeColor = System.Drawing.Color.Red;
                    }
                    if (t.Rows[idp - 1]["raspunsC"].ToString() == "1")
                    {
                        raspuns3.Text += "Acesta este răspunsul corect!";
                        raspuns3.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[idp - 1]["raspunsC"].ToString() == "0")
                    {
                        raspuns3.Text += "Acesta este răspunsul greșit!";
                        raspuns3.ForeColor = System.Drawing.Color.Red;
                    }
                    

                    button5.Enabled = false;
                }
                
                    

          }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            raspuns1.Text = "";
            raspuns2.Text = "";
            raspuns3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            labelintrebare.Text = "";
            labelraspuns.Text = "";
            label11.Text = "";
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            indice++;
            button7.Enabled = true;
            
            if (idp < int.Parse(intrebareTableAdapter.numarintrebari().ToString()))
            {
                
                labelintrebare.Text = t.Rows[idp]["intrebare"].ToString();
                label11.Text += indice.ToString();
                checkBox1.Text = t.Rows[idp]["variantaA"].ToString();
                checkBox2.Text = t.Rows[idp]["variantaB"].ToString();
                checkBox3.Text = t.Rows[idp]["variantaC"].ToString();

                
                if (t.Rows[idp]["pozaintrebare"].ToString().Length != 0)
                {
                    string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                    Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[idp]["pozaintrebare"].ToString());
                    pictureBox1.Visible = true;
                    pictureBox1.Image = (Image)image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }
                idp++;
            
            }
                
            else
            {
                checkBox1.Text = "";
                checkBox2.Text = "";
                checkBox3.Text = "";
                pictureBox1.Image = null;
                MessageBox.Show("Ați parcurs mediul de invățare în întregime!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
                Visible = false;
                Main f7 = new Main();
                f7.ShowDialog();
            }

            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            raspuns1.Text = "";
            raspuns2.Text = "";
            raspuns3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            labelintrebare.Text = "";
            label11.Text = "";
            labelraspuns.Text = "";
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            idp--;
            indice--;     
            if (idp <= 0)
            {
                idp = 0;
                indice = 0;
                labelintrebare.Text = "";
                checkBox1.Text = "";
                checkBox2.Text = "";
                checkBox3.Text = "";
                pictureBox1.Image = null;
                button7.Enabled = false;
            }

            if (idp > 0)
            { 
                labelintrebare.Text = t.Rows[idp-1]["intrebare"].ToString();
                label11.Text += indice.ToString(); ;
                checkBox1.Text = t.Rows[idp-1]["variantaA"].ToString();
                checkBox2.Text = t.Rows[idp-1]["variantaB"].ToString();
                checkBox3.Text = t.Rows[idp-1]["variantaC"].ToString();
                if (t.Rows[idp-1]["pozaintrebare"].ToString().Length != 0)
                {
                    string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                    Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[idp-1]["pozaintrebare"].ToString());
                    pictureBox1.Visible = true;
                    pictureBox1.Image = (Image)image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main f10 = new Main();
            f10.Show();
            Visible = false;
        }
        }
   }

