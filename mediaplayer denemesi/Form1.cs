using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaplayer_denemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        int sayac = 0;
        int sayac2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac2 = 0;
            if (sayac2 == sayac)
            {
                MessageBox.Show("lütfen önce kayıt olunuz.");
            }
            else
            {

                if (textBox1.Text == k_adi[sayac2] && textBox2.Text == sifre[sayac2])
                {
                    MessageBox.Show("Giriş Başarılı.");
                    Form2 formm = new Form2();
                    formm.ShowDialog();
                    this.Close();
                    //sayac2++;
                }
                else
                    MessageBox.Show("Hatalı Giriş!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Clear();
                textBox2.Clear();

            }

        }
        string[] k_adi = new string[1];
        string[] sifre = new string[1];

        private void button2_Click(object sender, EventArgs e)
        {
            sayac= 0;
            if (textBox4.Text != "" && textBox3.Text != "")
            {
                k_adi[sayac] = textBox4.Text;
                sifre[sayac] = textBox3.Text;
                sayac++;
                textBox3.Clear();
                textBox4.Clear();
                button2.Enabled = false;
                MessageBox.Show("kayıt başarılı, giriş yapabilirsiniz.");

            }
            else
                MessageBox.Show("kullanıcı adı veya şifre hatalı");


        }
      
    }
}
