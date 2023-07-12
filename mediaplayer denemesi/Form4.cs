using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaplayer_denemesi
{
    public partial class Form4 : Form
    {
        public Form4(string takim)
        {
            InitializeComponent();
            ReallyCenterToScreen();
            
            calistirma(takim);
        }
        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        public void calistirma (string takimlar)
        {


            label1.Text = "KAZANAN  " + takimlar.ToString() + " TEBRİKLER :)";
            if (takimlar == "Galatasaray")
            {
                Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\gs.png");
                this.BackgroundImage = myimage;
            }
            else if (takimlar == "Fenerbahçe")
            {
                Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\fb.jpg");
                this.BackgroundImage = myimage;
            }
            else if (takimlar == "Beşiktaş")
            {
                Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\bjk.jpg");
                this.BackgroundImage = myimage;
            }
            else if (takimlar == "Urfaspor")
            {
                Image myimage = new Bitmap("C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\us.png");
                this.BackgroundImage = myimage;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(label1.Text== "KAZANAN  Fenerbahçe TEBRİKLER :)")
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\fbmarş.mp4";
            }
            else if(label1.Text == "KAZANAN  Galatasaray TEBRİKLER :)")
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\gsmarş.mp3";
            }
            else if(label1.Text == "KAZANAN  Beşiktaş TEBRİKLER :)")
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\bjkmarş.mp3";
            }
            else if(label1.Text == "KAZANAN  Urfaspor TEBRİKLER :)")
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\iseli\\OneDrive\\Masaüstü\\takımlar\\urfamarş.mp3";
            }
           
        }
    }
}
