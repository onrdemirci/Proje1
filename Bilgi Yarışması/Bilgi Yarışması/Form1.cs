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
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Kayıt Oldunuz");
            frm.Show();
            this.Hide();
        }
    }
}
