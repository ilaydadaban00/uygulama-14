using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 25;
            sayi2 = 54;
            toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
        }
    }
}
