namespace Bilgi_Yarışması
{
    partial class Form2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.Sorusayisi = new System.Windows.Forms.Label();
            this.Doru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.Label();
            this.LblSoru = new System.Windows.Forms.Label();
            this.Lbldogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCanJokeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(206, 54);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(620, 221);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(218, 279);
            this.BtnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(298, 41);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(520, 279);
            this.BtnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(298, 41);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(218, 324);
            this.BtnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(298, 41);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(520, 324);
            this.BtnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(298, 41);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // Sorusayisi
            // 
            this.Sorusayisi.AutoSize = true;
            this.Sorusayisi.Location = new System.Drawing.Point(54, 93);
            this.Sorusayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sorusayisi.Name = "Sorusayisi";
            this.Sorusayisi.Size = new System.Drawing.Size(62, 13);
            this.Sorusayisi.TabIndex = 5;
            this.Sorusayisi.Text = "Soru Sayısı:";
            // 
            // Doru
            // 
            this.Doru.AutoSize = true;
            this.Doru.Location = new System.Drawing.Point(78, 123);
            this.Doru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Doru.Name = "Doru";
            this.Doru.Size = new System.Drawing.Size(39, 13);
            this.Doru.TabIndex = 6;
            this.Doru.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(940, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Location = new System.Drawing.Point(78, 150);
            this.hata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(38, 13);
            this.hata.TabIndex = 9;
            this.hata.Text = "Yanlış:";
            // 
            // LblSoru
            // 
            this.LblSoru.AutoSize = true;
            this.LblSoru.Location = new System.Drawing.Point(117, 93);
            this.LblSoru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(13, 13);
            this.LblSoru.TabIndex = 10;
            this.LblSoru.Text = "0";
            // 
            // Lbldogru
            // 
            this.Lbldogru.AutoSize = true;
            this.Lbldogru.Location = new System.Drawing.Point(117, 123);
            this.Lbldogru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbldogru.Name = "Lbldogru";
            this.Lbldogru.Size = new System.Drawing.Size(13, 13);
            this.Lbldogru.TabIndex = 11;
            this.Lbldogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(117, 150);
            this.LblYanlis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(13, 13);
            this.LblYanlis.TabIndex = 12;
            this.LblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(436, 416);
            this.BtnSonraki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(142, 50);
            this.BtnSonraki.TabIndex = 13;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Jokerler";
            // 
            // buttonCanJokeri
            // 
            this.buttonCanJokeri.BackColor = System.Drawing.Color.Red;
            this.buttonCanJokeri.Enabled = false;
            this.buttonCanJokeri.Location = new System.Drawing.Point(943, 70);
            this.buttonCanJokeri.Name = "buttonCanJokeri";
            this.buttonCanJokeri.Size = new System.Drawing.Size(75, 23);
            this.buttonCanJokeri.TabIndex = 15;
            this.buttonCanJokeri.Text = "Can Jokeri";
            this.buttonCanJokeri.UseVisualStyleBackColor = false;
            this.buttonCanJokeri.Click += new System.EventHandler(this.buttonCanJokeri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1149, 601);
            this.Controls.Add(this.buttonCanJokeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.Lbldogru);
            this.Controls.Add(this.LblSoru);
            this.Controls.Add(this.hata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Doru);
            this.Controls.Add(this.Sorusayisi);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label Sorusayisi;
        private System.Windows.Forms.Label Doru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hata;
        private System.Windows.Forms.Label LblSoru;
        private System.Windows.Forms.Label Lbldogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCanJokeri;
    }
}