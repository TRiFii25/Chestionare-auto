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
    
    public partial class examen : Form
    {
        int j = 0;
        int nrc = 0;
        int nrg = 0;
        int k = 1;
        int okk;
        int ok3 = 1;
        int r = 1;
        int pcd;
        public string username;
        
        public examen()
        {         
            InitializeComponent();
            tabControl1.SelectedTab = tabPage1;
            
            string user = Login.SetValueForText1;
            label8.Text = "";
            label9.Text = "";
            
            label13.Text = "";
            label14.Text = "";
            utilizatoriTableAdapter.Fill(db1DataSet.Utilizatori);
            DataTable k=db1DataSet.Utilizatori;
            
            DataTable g = db1DataSet.punctaj;
            punctajTableAdapter.Fill(db1DataSet.punctaj);
            if (user != null)
            {
                pcd = int.Parse(utilizatoriTableAdapter.aflareutilizator(user).ToString()); 
                label8.Text+=k.Rows[pcd-1]["nrtesteadmise"].ToString();
                label9.Text+=k.Rows[pcd-1 ]["nrtestepicate"].ToString();
                label13.Text += g.Rows[pcd - 1]["punctajmaxim"].ToString();
                label14.Text += g.Rows[pcd - 1]["punctajminim"].ToString();
                
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Main f17 = new Main();
            f17.Show();
            Visible = false;
        }  
        static Random _random = new Random();
        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        private int counter = 1800;
        private void timer1_Tick(object sender, EventArgs e)
        {
            utilizatoriTableAdapter.Fill(db1DataSet.Utilizatori);
            DataTable k = db1DataSet.Utilizatori;
            counter--;
            if (counter == 0)
            {
           timer1.Stop();
           MessageBox.Show("N-ai valoare...", "Boss...", MessageBoxButtons.OK, MessageBoxIcon.Error);      
           int nrtp = int.Parse(k.Rows[pcd - 1]["nrtestepicate"].ToString());
           utilizatoriTableAdapter.updateTestePicate((nrtp + 1).ToString(), pcd);
           Main f10 = new Main();
           f10.Show();
           Visible = false;
            }
            label4.Text = (counter/60+" minute si "+counter%60+ " secunde ").ToString();
        }
        int[] sir = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45};
        int i = 0;
        int[] array = new int[26];
        private void button1_Click(object sender, EventArgs e)
        {            
            tabControl1.SelectedTab = tabPage2;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";
            labelintrebare.Text = "";
            labelraspuns1.Text = "";
            labelraspuns2.Text = "";
            labelraspuns3.Text = "";
            labelraspcorecte.Text = "";
            labelraspgresite.Text = "";
            labelintrebare.Text = "";
            labelraspuns.Text = "";
            
            int counter = 30;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 secunda
            timer1.Start();
            label4.Text = counter.ToString()+" de minute";
            /////////////////////////
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;  
            Shuffle(sir);          
            for (i = 0; i < 26; i++)
            {
                array[i] = sir[i];
            }
            labelintrebare.Text = t.Rows[array[j]-1]["intrebare"].ToString();      
            checkBox1.Text += t.Rows[array[j]-1]["variantaA"].ToString();
            checkBox2.Text += t.Rows[array[j]-1]["variantaB"].ToString();
            checkBox3.Text += t.Rows[array[j]-1]["variantaC"].ToString();
            if (okk == 0 && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            {
                if (t.Rows[array[j] - 1]["pozaintrebare"].ToString().Length != 0)
                {
                    string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                    Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[array[j] - 1]["pozaintrebare"].ToString());
                    pictureBox1.Visible = true;
                    pictureBox1.Image = (Image)image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }     
            }
            else
            {
                MessageBox.Show("Pentru a ajunge la următoarea întrebare trebuie să apăsați butonul 'Trimite'!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (t.Rows[array[j] - 1]["pozaintrebare"].ToString().Length != 0)
                {
                    string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                    Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[array[j] - 1]["pozaintrebare"].ToString());
                    pictureBox1.Visible = true;
                    pictureBox1.Image = (Image)image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                } 
            }
            j++;
            okk = 1;
             
        }
        private void examen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.intrebare' table. You can move, or remove it, as needed.
            this.intrebareTableAdapter.Fill(this.db1DataSet.intrebare);
            // TODO: This line of code loads data into the 'db1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.db1DataSet.Utilizatori);
            // TODO: This line of code loads data into the 'db1DataSet.punctaj' table. You can move, or remove it, as needed.
            this.punctajTableAdapter.Fill(this.db1DataSet.punctaj);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            labelraspuns1.Text = "";
            labelraspuns2.Text = "";
            labelraspuns3.Text = "";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            labelraspuns.Text = "";  
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            if (okk == 0 &&(checkBox1.Checked==true || checkBox2.Checked==true || checkBox3.Checked==true))
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    MessageBox.Show("Pentru a putea merge la următoarea întrebare trebuie să selectezi un răspuns!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (t.Rows.Count > 0)
                    {
                        if (nrg <= 4 && k < 26)
                        {
                            labelintrebare.Text = t.Rows[array[j] - 1]["intrebare"].ToString();
                            checkBox1.Text = t.Rows[array[j] - 1]["variantaA"].ToString();
                            checkBox2.Text = t.Rows[array[j] - 1]["variantaB"].ToString();
                            checkBox3.Text = t.Rows[array[j] - 1]["variantaC"].ToString();
                            if (t.Rows[array[j] - 1]["pozaintrebare"].ToString().Length != 0)
                            {
                                string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                                Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[array[j] - 1]["pozaintrebare"].ToString());
                                pictureBox1.Visible = true;
                                pictureBox1.Image = (Image)image;
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            else
                            {
                                pictureBox1.Image = null;
                            }

                            j++;
                        }
                        else
                        {
                            checkBox1.Text = "";
                            checkBox2.Text = "";
                            checkBox3.Text = "";
                            labelintrebare.Text = "";
                            labelraspuns.Text = "";
                            labelraspuns1.Text = "";
                            labelraspuns2.Text = "";
                            labelraspuns3.Text = "";
                            pictureBox1.Image = null;
                           
                        }
                        k++;
                    }
                }
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;    
            }
            else
            {
                MessageBox.Show("Pentru a ajunge la următoarea întrebare trebuie să apăsați butonul 'Trimite'!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            okk = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            j--;
            labelraspuns1.Text = "";
            labelraspuns2.Text = "";
            labelraspuns3.Text = "";
            labelraspuns.Text = "";
            labelraspcorecte.Text = "";
            labelraspgresite.Text = "";
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;
            int nr = 0;
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Pentru a putea merge la următoarea întrebare trebuie să selectezi un răspuns!", "ATENȚIE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                
                    if (checkBox1.Checked == true)
                    {
                        if (t.Rows[array[j] - 1]["raspunsA"].ToString() == "1")
                        {
                            nr++;
                        }
                        else
                            if (t.Rows[array[j] - 1]["raspunsA"].ToString() == "0")
                            {
                                nr--;
                            }
                    }
                    if (checkBox2.Checked == true)
                    {
                        if (t.Rows[array[j] - 1]["raspunsB"].ToString() == "1")
                        {
                            nr++;
                        }
                        else
                            if (t.Rows[array[j] - 1]["raspunsB"].ToString() == "0")
                            {
                                nr--;
                            }
                    }
                    if (checkBox3.Checked == true)
                    {
                        if (t.Rows[array[j] - 1]["raspunsC"].ToString() == "1")
                        {
                            nr++;
                        }
                        else
                            if (t.Rows[array[j] - 1]["raspunsC"].ToString() == "0")
                            {
                                nr--;
                            }
                    }
                    if (int.Parse(t.Rows[array[j] - 1]["nrcorecte"].ToString()) == nr)
                    {
                        labelraspuns.Text += "Ați răspuns corect!";
                        labelraspuns.ForeColor = System.Drawing.Color.Green;
                        nrc++;
                        labelraspcorecte.Text += nrc.ToString();
                        labelraspgresite.Text += nrg.ToString();
                    }
                    else
                        if (int.Parse(t.Rows[array[j] - 1]["nrcorecte"].ToString()) != nr)
                        {
                            labelraspuns.Text += "Ați răspuns greșit!";
                            labelraspuns.ForeColor = System.Drawing.Color.Red;
                            nrg++;
                            labelraspcorecte.Text += nrc.ToString();
                            labelraspgresite.Text += nrg.ToString();
                        }
                    if (t.Rows[array[j] - 1]["raspunsA"].ToString() == "1")
                    {
                        labelraspuns1.Text += "Acesta este răspunsul corect!";
                        labelraspuns1.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[array[j] - 1]["raspunsA"].ToString() == "0")
                    {
                        labelraspuns1.Text += "Acesta este răspunsul greșit!";
                        labelraspuns1.ForeColor = System.Drawing.Color.Red;
                    }
                    if (t.Rows[array[j] - 1]["raspunsB"].ToString() == "1")
                    {
                        labelraspuns2.Text += "Acesta este răspunsul corect!";
                        labelraspuns2.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[array[j] - 1]["raspunsB"].ToString() == "0")
                    {
                        labelraspuns2.Text += "Acesta este răspunsul greșit!";
                        labelraspuns2.ForeColor = System.Drawing.Color.Red;
                    }
                    if (t.Rows[array[j] - 1]["raspunsC"].ToString() == "1")
                    {
                        labelraspuns3.Text += "Acesta este răspunsul corect!";
                        labelraspuns3.ForeColor = System.Drawing.Color.Green;
                    }
                    if (t.Rows[array[j] - 1]["raspunsC"].ToString() == "0")
                    {
                        labelraspuns3.Text += "Acesta este răspunsul greșit!";
                        labelraspuns3.ForeColor = System.Drawing.Color.Red;
                    }
                    utilizatoriTableAdapter.Fill(db1DataSet.Utilizatori);
                    DataTable k = db1DataSet.Utilizatori;
                    if (nrg > 4)
                    {
                        int nrtp = int.Parse(k.Rows[pcd - 1]["nrtestepicate"].ToString());
                        utilizatoriTableAdapter.updateTestePicate((nrtp + 1).ToString(),pcd);
                        MessageBox.Show("Ați picat examenul teoretic de conducere auto!", "BRUH!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int nrc2 = nrc;
                        int nrg2 = nrg;
                        punctajTableAdapter.updatePunctajMaxim(nrc2.ToString(), pcd);
                        punctajTableAdapter.updatePunctajMinim(nrg2.ToString(), pcd);
                        punctajTableAdapter.Update(db1DataSet.punctaj);
                        Main f7 = new Main();
                        f7.Show();
                        Visible = false;
                    }
                    else
                    {
                        if (nrg <= 4 && r == 26)
                        {
                            int nrta = int.Parse(k.Rows[pcd - 1]["nrtesteadmise"].ToString());
                            utilizatoriTableAdapter.updateTesteAdmise((nrta + 1).ToString(), pcd);
                        MessageBox.Show("Ați promovat examenul teoretic de conducere auto!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int nrc2 = nrc;
                        int nrg2 = nrg;
                        punctajTableAdapter.updatePunctajMaxim(nrc2.ToString(), pcd);
                        punctajTableAdapter.updatePunctajMinim(nrg2.ToString(), pcd);
                        punctajTableAdapter.Update(db1DataSet.punctaj);
                        Main f7 = new Main();
                        f7.Show();
                        Visible = false;
                        }
                    r++;
                }
                j++;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            okk = 0;
            ok3 = 0;
            
        }
        int ok = 1;
        private void button5_Click(object sender, EventArgs e)
        {
            
            button4.Enabled = true;
            labelraspuns1.Text = "";
            labelraspuns2.Text = "";
            labelraspuns3.Text = "";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            labelraspuns.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;      
            intrebareTableAdapter.Fill(db1DataSet.intrebare);
            DataTable t = db1DataSet.intrebare;      
            Array.Resize(ref array, array.Length + 1);
               array[array.Length - 1] = array[j - 1];
               if (j == 1 && ok==1)
               {
                   ok = 0;
                   labelintrebare.Text = t.Rows[array[j] - 1]["intrebare"].ToString();
                   checkBox1.Text = t.Rows[array[j] - 1]["variantaA"].ToString();
                   checkBox2.Text = t.Rows[array[j] - 1]["variantaB"].ToString();
                   checkBox3.Text = t.Rows[array[j] - 1]["variantaC"].ToString();
                   if (t.Rows[array[j] - 1]["pozaintrebare"].ToString().Length != 0)
                   {
                       string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                       Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[array[j] - 1]["pozaintrebare"].ToString());
                       pictureBox1.Visible = true;
                       pictureBox1.Image = (Image)image;
                       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                   else
                   {
                       pictureBox1.Image = null;
                   }
                   j++;
               }
               else
               { 
                   labelintrebare.Text = t.Rows[array[j] - 1]["intrebare"].ToString();
                   checkBox1.Text = t.Rows[array[j] - 1]["variantaA"].ToString();
                   checkBox2.Text = t.Rows[array[j] - 1]["variantaB"].ToString();
                   checkBox3.Text = t.Rows[array[j] - 1]["variantaC"].ToString();
                   if (t.Rows[array[j] - 1]["pozaintrebare"].ToString().Length != 0)
                   {
                       string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                       Bitmap image = new Bitmap(path + "\\pozele\\" + t.Rows[array[j] - 1]["pozaintrebare"].ToString());
                       pictureBox1.Visible = true;
                       pictureBox1.Image = (Image)image;
                       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                   else
                   {
                       pictureBox1.Image = null;
                   }
                   j++;
               }        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string mesaj = "Dacă doriți să vă întoarceți la meniul de start al simulatorului,examenul actual va fi considerat ca fiind picat!" + "\n" +"Continuați?";
            string titlu = "ATENȚIE!";
            MessageBoxButtons buttons=MessageBoxButtons.YesNo;
            MessageBoxIcon icoana = MessageBoxIcon.Error;
            DialogResult rezultat=MessageBox.Show(mesaj,titlu,buttons,icoana);
            utilizatoriTableAdapter.Fill(db1DataSet.Utilizatori);
            DataTable k = db1DataSet.Utilizatori;
            if(rezultat==DialogResult.Yes)
            {

                int nrtp = int.Parse(k.Rows[pcd - 1]["nrtestepicate"].ToString());
                utilizatoriTableAdapter.updateTestePicate((nrtp + 1).ToString(), pcd);
                Main f19 = new Main();
                f19.Show();
                Visible = false;
            }      
        }       
    }
}
