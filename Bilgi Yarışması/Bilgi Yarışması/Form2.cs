using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool canJokeriUsed = false;

        int Sorusayısı = 0, Dogru = 0, yanlıs = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnB.Text;
            if (label3.Text == label4.Text)
            {
                Dogru++;
                Lbldogru.Text = Dogru.ToString();


            }
            else
            {
                yanlıs++;
                LblYanlis.Text = yanlıs.ToString();

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnC.Text;
            if (label3.Text == label4.Text)
            {
                Dogru++;
                Lbldogru.Text = Dogru.ToString();


            }
            else
            {
                yanlıs++;
                LblYanlis.Text = yanlıs.ToString();

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnD.Text;
            if (label3.Text == label4.Text)
            {
                Dogru++;
                Lbldogru.Text = Dogru.ToString();


            }
            else
            {
                yanlıs++;
                LblYanlis.Text = yanlıs.ToString();

            }
        }

        private void buttonCanJokeri_Click(object sender, EventArgs e)
        {
            BtnSonraki.Enabled = true;
            yanlıs--;
            LblYanlis.Text = yanlıs.ToString();

            canJokeriUsed = false;
            buttonCanJokeri.BackColor = Color.Red;
            buttonCanJokeri.Enabled = false;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (canJokeriUsed)
            {
                buttonCanJokeri.BackColor = Color.Red;
                buttonCanJokeri.Enabled = false;

            }
            else
            {
                buttonCanJokeri.BackColor = Color.Green;
                buttonCanJokeri.Enabled = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnA.Text;
            if (label3.Text == label4.Text)
            {
                Dogru++;
                Lbldogru.Text = Dogru.ToString();


            }
            else
            {
                yanlıs++;
                LblYanlis.Text = yanlıs.ToString();

            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            if (canJokeriUsed)
            {
                buttonCanJokeri.BackColor = Color.Red;
                buttonCanJokeri.Enabled = false;

            }
            else
            {
                buttonCanJokeri.BackColor = Color.Green;
                buttonCanJokeri.Enabled = true;
            }

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            Sorusayısı++;
            LblSoru.Text = Sorusayısı.ToString();
            if (Sorusayısı == 1)
            {
                richTextBox1.Text = "Cumhurieytin İlanı ?";
                BtnA.Text = "1923";
                BtnB.Text = "1920";
                BtnC.Text = "1917";
                BtnD.Text = "1925";
                label3.Text = "1923";
            }

            if (Sorusayısı == 2)
            {
                richTextBox1.Text = "2018-2019 Yılında STSL de Kim Şampiyon Olmuştur?";
                BtnA.Text = "FENERBAHÇE";
                BtnB.Text = "TRABZON";
                BtnC.Text = "BEŞİKTAŞ";
                BtnD.Text = "GALATASARAY";
                label3.Text = "GALATASARAY";
            }

            if (Sorusayısı == 3)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + Dogru + " \n" + "Yanlış:" + yanlıs);
            }
        }
    }
}
