using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLAYFAIR playfair = new PLAYFAIR();
            playfair.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            rsa.Show();
        }
    }
}
