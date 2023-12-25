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
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

     
        int P, Q, N, E, D, PhiN;
        public int first_D = 0;

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            if (first_D != 1)
            { MessageBox.Show("You haven't generated keys!", "Notification"); }

            else
            {
                if (rsa_BanRo.Text == "")
                {
                    MessageBox.Show("Please enter the plain text to encrypt!", "Notification");
                }

                else
                {
                    // Encrypt here
                    try
                    {
                        Encrypt(rsa_BanRo.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            if (first_D != 1)
                MessageBox.Show("You need to generate keys first.", "Notification");
            else
                try
                {
                    DECRYPT(rsa_banMaHoaGuiDen.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
        }

        private int ChooseRandomNumber()
        {
            Random rd = new Random();
            return rd.Next(11, 101);
        }

        private bool IsPrime(int number)
        {
            bool check = true;
            if (number == 2 || number == 3)
            {
                return check;
            }
            else
            {
                if (number == 1 || number % 2 == 0 || number % 3 == 0)
                {
                    check = false;
                }
                else
                {
                    for (int i = 5; i <= Math.Sqrt(number); i = i + 6)
                        if (number % i == 0 || number % (i + 2) == 0)
                        {
                            check = false;
                            break;
                        }
                }
            }
            return check;
        }

       /* private bool AreCoprime(int a, int b)
        {
            bool result;
            //Euclid
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            if (a == 1) { result = true; }
            else result = false;
            return result;
        }*/

        private int Modulo(int m, int e, int n)
        {
            int[] binaryRepresentation = new int[100];
            int k = 0;

            do
            {
                binaryRepresentation[k] = e % 2;
                k++;
                e = e / 2;
            }
            while (e != 0);

            int result = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                result = (result * result) % n;
                if (binaryRepresentation[i] == 1)
                    result = (result * m) % n;
            }

            return result;
        }

        private void rsa_TaoKhoa_Click(object sender, EventArgs e)
        {
            reset();
            P = Q = 0;
            do
            {
                P = ChooseRandomNumber();
                Q = ChooseRandomNumber();
            }
            while (P == Q || !IsPrime(P) || !IsPrime(Q));
            soP.Text = P.ToString();
            soQ.Text = Q.ToString();
            RSA_taoKhoa();
            first_D = 1;
            //create new key
            rsa_TaoKhoa.Enabled = false;

            btMaHoa.Enabled = true;
            btGiaiMa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soD.Clear();
            soQ.Clear();
            soN.Clear();
            soE.Clear();
            soPhiN.Clear();
            rsa_banGiaiMa.Clear();
            rsa_BanMaHoa.Clear();
            rsa_banMaHoaGuiDen.Clear();
            soP.Clear();
            rsa_BanRo.Clear();
        }

        private bool AreCoprime(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return a == 1;
        }

        private void RSA_taoKhoa()
        {
            //n=p*q
            N = P * Q;
            soN.Text = N.ToString();
            //Phi(n)=(p-1)*(q-1)
            PhiN = (P - 1) * (Q - 1);
            soPhiN.Text = PhiN.ToString();
            //e is random number which 0< e <phi(n) and is coProme with Phi(n)
            do
            {
                if (soE.Text == "")
                {
                    Random RSA_rd = new Random();
                    E = RSA_rd.Next(2, PhiN);
                }
                else
                {
                    E = int.Parse(soE.Text);
                }

            }
            while (!AreCoprime(E, PhiN));
            soE.Text = E.ToString();

            //d = revert of e
            D = 0;
            int i = 2;
            while (((1 + i * PhiN) % E) != 0 || D <= 0)
            {
                i++;
                D = (1 + i * PhiN) / E;
            }
            soD.Text = D.ToString();
        }
        public void Encrypt(string Str)
        {
            // String to unicode
            byte[] tmp = Encoding.Unicode.GetBytes(Str);
            string base64 = Convert.ToBase64String(tmp);

            int[] tmp2 = new int[base64.Length];
            for (int i = 0; i < base64.Length; i++)
            {
                tmp2[i] = (int)base64[i];
            }

            //All ecrypted data will store in array a
            int[] mh_temp3 = new int[tmp2.Length];
            for (int i = 0; i < tmp2.Length; i++)
            {
                mh_temp3[i] = Modulo(tmp2[i], E, N); // encrypt
            }

            //Convert into character in Unicode
            string str = "";
            for (int i = 0; i < mh_temp3.Length; i++)
            {
                str = str + (char)mh_temp3[i];
            }
            byte[] data = Encoding.Unicode.GetBytes(str);
            string a = Convert.ToBase64String(data);
            rsa_BanMaHoa.Text = a;
            rsa_banMaHoaGuiDen.Text = rsa_BanMaHoa.Text;
        }

        public void DECRYPT(string Str)
        {
            byte[] tmp = Convert.FromBase64String(Str);
            string deCrypt = Encoding.Unicode.GetString(tmp);

            int[] b = new int[deCrypt.Length];
            for (int i = 0; i < deCrypt.Length; i++)
            {
                b[i] = (int)deCrypt[i];
            }

            //Decrypt here
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Modulo(b[i], D, N);
            }

            string str = "";
            for (int i = 0; i < c.Length; i++)
            {
                str = str + (char)c[i];
            }
            byte[] data2 = Convert.FromBase64String(str);
            rsa_banGiaiMa.Text = Encoding.Unicode.GetString(data2);
        }

        private void reset()
        {
            soP.Text = soQ.Text = soPhiN.Text = soN.Text = soE.Text = soD.Text = string.Empty;
        }
    }
}
