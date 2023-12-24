using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATM
{
    public partial class PLAYFAIR : Form
    {
        private int check = 5;
        private Button[,] arrayMatrix = new Button[6, 6];
        private List<string> alphabet = new List<string>();

        public PLAYFAIR()
        {
            InitializeComponent();
            InitMatrix(5);
            textBox3.KeyPress += Matrix5_KeyPress;
            radioButton1.CheckedChanged += RadioButtons_CheckedChanged;
            radioButton2.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private string DistinctString(string input)
        {
            List<char> distinctChars = input.Distinct().ToList();
            return new string(distinctChars.ToArray());
        }

        public static string RemoveUnicode(string text)
        {
            string[] fromChars = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ","đ","é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] toChars = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a","d","e","e","e","e","e","e","e","e","e","e","e","i","i","i","i","i","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","u","u","u","u","u","u","u","u","u","u","u","y","y","y","y","y",};

            for (int i = 0; i < fromChars.Length; i++)
            {
                text = text.Replace(fromChars[i], toChars[i]);
                text = text.Replace(fromChars[i].ToUpper(), toChars[i].ToUpper());
            }

            return text;
        }

        private void ModifyMatrix(Button[,] matrix, int size, int startRow, int startCol, string replacement)
        {
            bool firstLoop = false;
            int index = 0;

            List<string> newAlphabet = new List<string>(alphabet);
            foreach (char c in replacement)
                newAlphabet.Remove(c.ToString());

            for (int i = startRow; i < size; i++)
            {
                if (!firstLoop)
                {
                    for (int j = startCol; j < size; j++)
                        matrix[i, j].Text = newAlphabet[index++];
                    firstLoop = true;
                }
                else
                {
                    for (int j = 0; j < size; j++)
                        matrix[i, j].Text = newAlphabet[index++];
                }
            }
        }

        private string PreparePlainText(int size)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string modifiedText = textBox1.Text.ToUpper();
                modifiedText = RemoveUnicode(modifiedText);

                if (size == 5)
                {
                    modifiedText = Regex.Replace(modifiedText, @"[\W\d]", "");
                    modifiedText = Regex.Replace(modifiedText, @"[jJ]", "I");
                }
                else if (size == 6)
                    modifiedText = Regex.Replace(modifiedText, @"[\W]", "");

                if (modifiedText.Length % 2 != 0)
                    modifiedText += 'X';
                return modifiedText;
            }
            return string.Empty;
        }

        private void ReplaceOnMatrix(int size, string text)
        {
            text = DistinctString(text);
            int row = 0, col = 0;
            foreach (char c in text)
            {
                int indexCol = alphabet.IndexOf(c.ToString());
                int indexRow = Convert.ToInt32(c);

                arrayMatrix[row, col].Text = c.ToString();

                while (indexCol > (size - 1))
                    indexCol -= size;

                switch (size)
                {
                    case 5:
                        break;
                    case 6:
                        break;
                }
                col++;
                if (col >= size)
                {
                    col = 0;
                    row++;
                }
            }
            ModifyMatrix(arrayMatrix, size, row, col, text);
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButton1)
                {
                    panel1.Controls.Clear();
                    InitMatrix(5);
                    checkString(5);
                    check = 5;
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox3.KeyPress += Matrix5_KeyPress;
                }
                else if (((RadioButton)sender) == radioButton2)
                {
                    panel1.Controls.Clear();
                    InitMatrix(6);
                    checkString(6);
                    check = 6;
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox3.KeyPress += Matrix6_KeyPress;
                }
            }
        }

        private void Matrix5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((new Regex(@"[^jJ\W\d]")).IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Matrix6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((new Regex(@"^\w+|[\d]")).IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void InitMatrix(int size)
        {
            int charNum = 65;
            int offset = 0;
            alphabet = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, offset * 30) };
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Matrix.MATRIX_WIDTH,
                        Height = Matrix.MATRIX_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y)
                    };

                    if (charNum > 90)
                    {
                        charNum = 48;
                        btn.Text = Encoding.ASCII.GetString(new byte[] { (byte)charNum });
                        alphabet.Add(btn.Text);
                    }
                    else if (charNum == 74 && size == 5)
                    {
                        charNum = 75;
                        btn.Text = Encoding.ASCII.GetString(new byte[] { (byte)charNum });
                        alphabet.Add(btn.Text);
                    }
                    else
                    {
                        btn.Text = Encoding.ASCII.GetString(new byte[] { (byte)charNum });
                        alphabet.Add(btn.Text);
                    }

                    arrayMatrix[i, j] = btn;
                    panel1.Controls.Add(btn);
                    oldBtn = btn;
                    charNum++;
                }
                offset++;
            }
        }

        private void checkString(int size)
        {
            if (textBox3.Text != string.Empty)
            {
                switch (size)
                {
                    case 5:
                        textBox3.Text = Regex.Replace(textBox3.Text, @"[0-9jJ]", "");
                        break;
                    case 6:
                        break;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = RemoveUnicode(textBox3.Text);
            textBox3.MaxLength = 36;
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.Text = textBox3.Text.ToUpper();
        }

        private int CheckRow(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return i;
                }
            }
            return -1;
        }

        private int CheckCol(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return j;
                }
            }
            return -1;
        }

        private string Encrypt(int size, string pair)
        {
            int r0 = CheckRow(pair[0], size);
            int c0 = CheckCol(pair[0], size);
            int r1 = CheckRow(pair[1], size);
            int c1 = CheckCol(pair[1], size);

            if (c0 == c1)
            {
                if ((r0 + 1) >= size) r0 = -1;
                if ((r1 + 1) >= size) r1 = -1;

                return arrayMatrix[r0 + 1, c0].Text + arrayMatrix[r1 + 1, c0].Text;
            }

            if (r0 == r1)
            {
                if ((c0 + 1) >= size) c0 = -1;
                if ((c1 + 1) >= size) c1 = -1;

                return arrayMatrix[r0, c0 + 1].Text + arrayMatrix[r0, c1 + 1].Text;
            }

            int hC = Math.Abs(c1 - c0);

            if ((c0 + hC) >= size)
            {
                c0 = -c0;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if ((c1 + hC) >= size)
            {
                c1 = -c1;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if (c0 < c1)
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 - hC)].Text;

            return arrayMatrix[Math.Abs(r0), Math.Abs(c0 - hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
        }

        private string Decrypt(int size, string pair)
        {
            int r0 = CheckRow(pair[0], size);
            int c0 = CheckCol(pair[0], size);
            int r1 = CheckRow(pair[1], size);
            int c1 = CheckCol(pair[1], size);

            if (c0 == c1)
            {
                if ((r0 - 1) < 0) r0 = size;
                if ((r1 - 1) < 0) r1 = size;

                return arrayMatrix[r0 - 1, c0].Text + arrayMatrix[r1 - 1, c0].Text;
            }

            if (r0 == r1)
            {
                if ((c0 - 1) < 0) c0 = size;
                if ((c1 - 1) < 0) c1 = size;

                return arrayMatrix[r0, c0 - 1].Text + arrayMatrix[r0, c1 - 1].Text;
            }

            int hC = Math.Abs(c1 - c0);

            if ((c0 + hC) >= size)
            {
                c0 = -c0;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if ((c1 + hC) >= size)
            {
                c1 = -c1;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if (c0 > c1)
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 - hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;

            return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 - hC)].Text;
        }

        private List<string> SplitPairs(string text)
        {
            int index = 0;
            List<string> pairs = new List<string>();

            while (index != text.Length)
            {
                string pair = "";
                for (; index < text.Length; index++)
                {
                    if (pair.Length >= 2) break;
                    pair += text[index];
                }
                pairs.Add(pair);
            }
            return pairs;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
                ReplaceOnMatrix(check, textBox3.Text);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(check);
            List<string> pairs = SplitPairs(text);
            textBox2.Text = string.Join("", pairs.Select(pair => Encrypt(check, pair)));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(check);
            List<string> pairs = SplitPairs(text);
            textBox2.Text = string.Join("", pairs.Select(pair => Decrypt(check, pair)));
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tempText = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Clear();
        }
    }
}
