using mediaplayer_denemesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
{
    if (label7.Text == "Fenerbahçe")
    {
        Form4 yenisi = new Form4("Fenerbahçe");

    }
    else if (label7.Text == "Galatasaray")
    {
        Form4 yenisi = new Form4("Galatasaray");
    }
    else if (label7.Text == "Beşiktaş")
    {
        Form4 yenisi = new Form4("Beşiktaş");
    }
    else if (label7.Text == "Urfaspor")
    {
        Form4 yenisi = new Form4("Urfaspor");
    }


}
else if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
{
    if (label6.Text == "Fenerbahçe")
    {
        Form4 yenisi = new Form4("Fenerbahçe");

    }
    else if (label6.Text == "Galatasaray")
    {
        Form4 yenisi = new Form4("Galatasaray");
    }
    else if (label6.Text == "Beşiktaş")
    {
        Form4 yenisi = new Form4("Beşiktaş");
    }
    else if (label6.Text == "Urfaspor")
    {
        Form4 yenisi = new Form4("Urfaspor");
    }
}
else
{
    MessageBox.Show("BERABERE !!!");
}
*/

namespace mediaplayer_denemesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*this.WindowState =*/ CenterToScreen();
        }
        Random rnd = new Random();
        int gs = 0, fb = 0, bjk = 0, us = 0;

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                if (label7.Text == "Fenerbahçe")
                {
                   
                    Form4 yenisi = new Form4("Fenerbahçe");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    //this.Hide();

                }
                else if (label7.Text == "Galatasaray")
                {
                    Form4 yenisi = new Form4("Galatasaray");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                   // this.Hide();
                }
                else if (label7.Text == "Beşiktaş")
                {
                    Form4 yenisi = new Form4("Beşiktaş");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    // this.Hide();
                }
                else if (label7.Text == "Urfaspor")
                {
                    Form4 yenisi = new Form4("Urfaspor");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    //this.Hide();
                }


            }
            else if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                if (label6.Text == "Fenerbahçe")
                {
                    Form4 yenisi = new Form4("Fenerbahçe");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    // this.Hide();

                }
                else if (label6.Text == "Galatasaray")
                {
                    Form4 yenisi = new Form4("Galatasaray");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    // this.Hide();
                }
                else if (label6.Text == "Beşiktaş")
                {
                    Form4 yenisi = new Form4("Beşiktaş");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    // this.Hide();
                }
                else if (label6.Text == "Urfaspor")
                {
                    Form4 yenisi = new Form4("Urfaspor");
                    yenisi.StartPosition = FormStartPosition.CenterScreen;
                    yenisi.Show();
                    // this.Hide();
                }
            }
            else
            {
                MessageBox.Show("BERABERE !!!");
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                groupBox5.Visible = true;
                int[] puan = new int[4];
                int puangs = Convert.ToInt32(labelgspuan.Text);
                int puanfb = Convert.ToInt32(labelfbpuan.Text);
                int puanbjk = Convert.ToInt32(labelbjkpuan.Text);
                int puanus = Convert.ToInt32(labeluspuan.Text);
                puan[0] = puangs;
                puan[1] = puanfb;
                puan[2] = puanbjk;
                puan[3] = puanus;
                int bir, iki,bos = 0;
                for(int i = 0; i<4; i++)
                {
                    for(int j = 0; j<4; j++)
                    {
                        if (puan[i] > puan[j])
                        {
                            bos = puan[i];
                            puan[i] = puan[j];
                            puan[j] = bos;
                        }
                    }
                }
                bir = puan[0];
                iki = puan[1];
                if(bir == puangs)
                {
                    label7.Text = "Galatasaray";
                    label5.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\gs2.jpg");
                    pictureBox17.Image = myimage;
                }
                else if(bir == puanfb)
                {
                    label7.Text = "Fenerbahçe";
                    label5.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\fb2.jpg");
                    pictureBox17.Image = myimage;
                }
                else if(bir == puanbjk)
                {
                    label7.Text = "Beşiktaş";
                    label5.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\bjk2.jpg");
                    pictureBox17.Image = myimage;
                }
                else
                {
                    label7.Text = "Urfaspor";
                    label5.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\us.png");
                    pictureBox17.Image = myimage;
                }

                if (iki == puangs)
                {
                    label6.Text = "Galatasaray";
                    label4.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\gs2.jpg");
                    pictureBox18.Image = myimage;
                }
                else if (iki == puanfb)
                {
                    label6.Text = "Fenerbahçe";
                    label4.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\fb2.jpg");
                    pictureBox18.Image = myimage;
                }
                else if (iki == puanbjk)
                {
                    label6.Text = "Beşiktaş";
                    label4.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\bjk2.jpg");
                    pictureBox18.Image = myimage;
                }
                else
                {
                    label6.Text = "Urfaspor";
                    label4.Text = Convert.ToString(rnd.Next(1, 7));
                    Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\us.png");
                    pictureBox18.Image = myimage;
                }
            button5.Visible = true;
                button4.Enabled = false;
            }
            else
                MessageBox.Show("ÖNCE 1,2 VE 3. HAFTALARIN MAÇLARI OYNANMALI !");
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            labelgs3.Text = Convert.ToString(rnd.Next(1, 7));
            labelfb3.Text = Convert.ToString(rnd.Next(1, 7));
            labelbjk3.Text = Convert.ToString(rnd.Next(1, 7));
            labelus3.Text = Convert.ToString(rnd.Next(1, 7));
            button1.Enabled = false;
            if(Convert.ToInt32(labelfb3.Text) > Convert.ToInt32(labelbjk3.Text))
            {
                fb += 3;
                labelfbpuan.Text = Convert.ToString(fb);
            }
            else if (Convert.ToInt32(labelbjk3.Text) > Convert.ToInt32(labelfb3.Text))
            {
                bjk += 3;
                labelbjkpuan.Text = Convert.ToString(bjk);
            }
            else
            {
                fb += 1;
                labelfbpuan.Text = Convert.ToString(fb);
                bjk += 1;
                labelbjkpuan.Text = Convert.ToString(bjk);
            }

            if(Convert.ToInt32(labelgs3.Text) > Convert.ToInt32(labelus3.Text))
            {
                gs += 3;
                labelgspuan.Text = Convert.ToString(gs);
            }
            else if(Convert.ToInt32(labelus3.Text) > Convert.ToInt32(labelgs3.Text))
            {
                us += 3;
                labeluspuan.Text = Convert.ToString(us);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelgs2.Text = Convert.ToString(rnd.Next(1, 7));
            labelfb2.Text = Convert.ToString(rnd.Next(1, 7));
            labelbjk2.Text = Convert.ToString(rnd.Next(1, 7));
            labelus2.Text = Convert.ToString(rnd.Next(1, 7));
            button2.Enabled = false;
            if(Convert.ToInt32(labelgs2.Text) > Convert.ToInt32(labelbjk2.Text))
            {
                gs += 3;
                labelgspuan.Text = Convert.ToString(gs);
            }
            else if (Convert.ToInt32(labelbjk2.Text) > Convert.ToInt32(labelgs2.Text))
            {
                bjk += 3;
                labelbjkpuan.Text = Convert.ToString(bjk);
            }
            else
            {
                gs += 1;
                labelgspuan.Text = Convert.ToString(gs);
                bjk += 1;
                labelbjkpuan.Text = Convert.ToString(bjk);
            }

            if(Convert.ToInt32(labelfb2.Text) > Convert.ToInt32(labelus2.Text))
            {
                fb += 3;
                labelfbpuan.Text = Convert.ToString(fb);
            }
            else if (Convert.ToInt32(labelus2.Text) > Convert.ToInt32(labelfb2.Text))
            {
                us += 3;
                labeluspuan.Text = Convert.ToString(us);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            labelgs1.Text = Convert.ToString(rnd.Next(1, 7));
            labelfb1.Text = Convert.ToString(rnd.Next(1, 7));
            labelbjk1.Text = Convert.ToString(rnd.Next(1, 7));
            labelus1.Text = Convert.ToString(rnd.Next(1, 7));
            button3.Enabled = false;

            if (Convert.ToInt32(labelgs1.Text) > Convert.ToInt32(labelfb1.Text))
            {
                gs += 3;
                labelgspuan.Text = Convert.ToString(gs);
            }
            else if (Convert.ToInt32(labelfb1.Text) > Convert.ToInt32(labelgs1.Text))
            {
                fb += 3;
                labelfbpuan.Text = Convert.ToString(fb);
            }
            else
            {
                gs += 1;
                fb += 1;
                labelgspuan.Text = Convert.ToString(gs);
                labelfbpuan.Text = Convert.ToString(fb);

            }
            if (Convert.ToInt32(labelbjk1.Text) > Convert.ToInt32(labelus1.Text))
            {
                bjk += 3;
                labelbjkpuan.Text = Convert.ToString(bjk);
            }
            else if (Convert.ToInt32(labelus1.Text) > Convert.ToInt32(labelbjk1.Text))
            {
                us += 3;
                labeluspuan.Text = Convert.ToString(us);
            }
            else
            {
                bjk += 1;
                us += 1;
                labelbjkpuan.Text = Convert.ToString(bjk);
                labeluspuan.Text = Convert.ToString(us);

               
            }
        }
    }
}
