namespace ATM
{
    partial class RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rsa_banGiaiMa = new System.Windows.Forms.RichTextBox();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.rsa_banMaHoaGuiDen = new System.Windows.Forms.RichTextBox();
            this.rsa_BanMaHoa = new System.Windows.Forms.RichTextBox();
            this.rsa_BanRo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.soPhiN = new System.Windows.Forms.TextBox();
            this.soQ = new System.Windows.Forms.TextBox();
            this.soP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soE = new System.Windows.Forms.TextBox();
            this.soN = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rsa_TaoKhoa = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rsa_banGiaiMa
            // 
            this.rsa_banGiaiMa.Location = new System.Drawing.Point(18, 142);
            this.rsa_banGiaiMa.Margin = new System.Windows.Forms.Padding(2);
            this.rsa_banGiaiMa.Name = "rsa_banGiaiMa";
            this.rsa_banGiaiMa.Size = new System.Drawing.Size(420, 84);
            this.rsa_banGiaiMa.TabIndex = 5;
            this.rsa_banGiaiMa.Text = "";
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(353, 15);
            this.btGiaiMa.Margin = new System.Windows.Forms.Padding(2);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(85, 21);
            this.btGiaiMa.TabIndex = 4;
            this.btGiaiMa.Text = "DECRYPT";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // rsa_banMaHoaGuiDen
            // 
            this.rsa_banMaHoaGuiDen.Location = new System.Drawing.Point(20, 142);
            this.rsa_banMaHoaGuiDen.Margin = new System.Windows.Forms.Padding(2);
            this.rsa_banMaHoaGuiDen.Name = "rsa_banMaHoaGuiDen";
            this.rsa_banMaHoaGuiDen.Size = new System.Drawing.Size(415, 84);
            this.rsa_banMaHoaGuiDen.TabIndex = 3;
            this.rsa_banMaHoaGuiDen.Text = "";
            // 
            // rsa_BanMaHoa
            // 
            this.rsa_BanMaHoa.Location = new System.Drawing.Point(18, 40);
            this.rsa_BanMaHoa.Margin = new System.Windows.Forms.Padding(2);
            this.rsa_BanMaHoa.Name = "rsa_BanMaHoa";
            this.rsa_BanMaHoa.Size = new System.Drawing.Size(420, 84);
            this.rsa_BanMaHoa.TabIndex = 2;
            this.rsa_BanMaHoa.Text = "";
            // 
            // rsa_BanRo
            // 
            this.rsa_BanRo.Location = new System.Drawing.Point(20, 43);
            this.rsa_BanRo.Margin = new System.Windows.Forms.Padding(2);
            this.rsa_BanRo.Name = "rsa_BanRo";
            this.rsa_BanRo.Size = new System.Drawing.Size(415, 84);
            this.rsa_BanRo.TabIndex = 0;
            this.rsa_BanRo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rsa_banMaHoaGuiDen);
            this.groupBox3.Controls.Add(this.btMaHoa);
            this.groupBox3.Controls.Add(this.rsa_BanRo);
            this.groupBox3.Location = new System.Drawing.Point(351, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(458, 244);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ENCRYPT";
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(355, 17);
            this.btMaHoa.Margin = new System.Windows.Forms.Padding(2);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(80, 22);
            this.btMaHoa.TabIndex = 1;
            this.btMaHoa.Text = "ENCRYPT";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rsa_TaoKhoa);
            this.groupBox2.Controls.Add(this.soPhiN);
            this.groupBox2.Controls.Add(this.soQ);
            this.groupBox2.Controls.Add(this.soP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(283, 199);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // soPhiN
            // 
            this.soPhiN.Location = new System.Drawing.Point(66, 106);
            this.soPhiN.Margin = new System.Windows.Forms.Padding(2);
            this.soPhiN.Name = "soPhiN";
            this.soPhiN.Size = new System.Drawing.Size(203, 20);
            this.soPhiN.TabIndex = 1;
            // 
            // soQ
            // 
            this.soQ.Location = new System.Drawing.Point(66, 78);
            this.soQ.Margin = new System.Windows.Forms.Padding(2);
            this.soQ.Name = "soQ";
            this.soQ.Size = new System.Drawing.Size(203, 20);
            this.soQ.TabIndex = 1;
            // 
            // soP
            // 
            this.soP.Location = new System.Drawing.Point(66, 48);
            this.soP.Margin = new System.Windows.Forms.Padding(2);
            this.soP.Name = "soP";
            this.soP.Size = new System.Drawing.Size(205, 20);
            this.soP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phi N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "N";
            // 
            // soE
            // 
            this.soE.Location = new System.Drawing.Point(45, 67);
            this.soE.Margin = new System.Windows.Forms.Padding(2);
            this.soE.Name = "soE";
            this.soE.Size = new System.Drawing.Size(224, 20);
            this.soE.TabIndex = 1;
            // 
            // soN
            // 
            this.soN.Location = new System.Drawing.Point(44, 30);
            this.soN.Margin = new System.Windows.Forms.Padding(2);
            this.soN.Name = "soN";
            this.soN.Size = new System.Drawing.Size(225, 20);
            this.soN.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.soE);
            this.groupBox4.Controls.Add(this.soN);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(18, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(283, 98);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PUBLIC KEY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "E";
            // 
            // soD
            // 
            this.soD.Location = new System.Drawing.Point(17, 61);
            this.soD.Margin = new System.Windows.Forms.Padding(2);
            this.soD.Name = "soD";
            this.soD.Size = new System.Drawing.Size(239, 20);
            this.soD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "D";
            // 
            // rsa_TaoKhoa
            // 
            this.rsa_TaoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsa_TaoKhoa.Location = new System.Drawing.Point(16, 17);
            this.rsa_TaoKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.rsa_TaoKhoa.Name = "rsa_TaoKhoa";
            this.rsa_TaoKhoa.Size = new System.Drawing.Size(255, 19);
            this.rsa_TaoKhoa.TabIndex = 2;
            this.rsa_TaoKhoa.Text = "GENERATE KEY:";
            this.rsa_TaoKhoa.UseVisualStyleBackColor = true;
            this.rsa_TaoKhoa.Click += new System.EventHandler(this.rsa_TaoKhoa_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.soD);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(18, 366);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(283, 109);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PRIVATE KEY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(320, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE KEY";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rsa_BanMaHoa);
            this.groupBox6.Controls.Add(this.rsa_banGiaiMa);
            this.groupBox6.Controls.Add(this.btGiaiMa);
            this.groupBox6.Location = new System.Drawing.Point(351, 272);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(458, 244);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DECRYPT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "1. p and q are two large prime number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "2. n = p x q.n is used as the modulus for both ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "the public and private keys.";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RSA";
            this.Text = "RSA";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rsa_banGiaiMa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.RichTextBox rsa_banMaHoaGuiDen;
        private System.Windows.Forms.RichTextBox rsa_BanMaHoa;
        private System.Windows.Forms.RichTextBox rsa_BanRo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox soPhiN;
        private System.Windows.Forms.TextBox soQ;
        private System.Windows.Forms.TextBox soP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soE;
        private System.Windows.Forms.TextBox soN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rsa_TaoKhoa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}