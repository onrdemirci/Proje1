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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(275, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(826, 271);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(290, 343);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(398, 50);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(694, 343);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(398, 50);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(290, 399);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(398, 50);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(694, 399);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(398, 50);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // Sorusayisi
            // 
            this.Sorusayisi.AutoSize = true;
            this.Sorusayisi.Location = new System.Drawing.Point(72, 115);
            this.Sorusayisi.Name = "Sorusayisi";
            this.Sorusayisi.Size = new System.Drawing.Size(83, 17);
            this.Sorusayisi.TabIndex = 5;
            this.Sorusayisi.Text = "Soru Sayısı:";
            // 
            // Doru
            // 
            this.Doru.AutoSize = true;
            this.Doru.Location = new System.Drawing.Point(104, 151);
            this.Doru.Name = "Doru";
            this.Doru.Size = new System.Drawing.Size(51, 17);
            this.Doru.TabIndex = 6;
            this.Doru.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1253, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1253, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Location = new System.Drawing.Point(104, 184);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(50, 17);
            this.hata.TabIndex = 9;
            this.hata.Text = "Yanlış:";
            // 
            // LblSoru
            // 
            this.LblSoru.AutoSize = true;
            this.LblSoru.Location = new System.Drawing.Point(156, 115);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(16, 17);
            this.LblSoru.TabIndex = 10;
            this.LblSoru.Text = "0";
            // 
            // Lbldogru
            // 
            this.Lbldogru.AutoSize = true;
            this.Lbldogru.Location = new System.Drawing.Point(156, 151);
            this.Lbldogru.Name = "Lbldogru";
            this.Lbldogru.Size = new System.Drawing.Size(16, 17);
            this.Lbldogru.TabIndex = 11;
            this.Lbldogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(156, 184);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(16, 17);
            this.LblYanlis.TabIndex = 12;
            this.LblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(582, 512);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(190, 61);
            this.BtnSonraki.TabIndex = 13;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1532, 740);
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
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}