
namespace ZarOyunu
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirinciZar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIkinciZar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnRandomBasla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRandomToplam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRandomIkınciZar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRandomIlkZar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToplamRandom = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltoplamBen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblToplam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblIkinciZar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBirinciZar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ben";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnRandomBasla);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblRandomToplam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblRandomIkınciZar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblRandomIlkZar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(292, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Zar: ";
            // 
            // lblBirinciZar
            // 
            this.lblBirinciZar.AutoSize = true;
            this.lblBirinciZar.Location = new System.Drawing.Point(75, 44);
            this.lblBirinciZar.Name = "lblBirinciZar";
            this.lblBirinciZar.Size = new System.Drawing.Size(21, 24);
            this.lblBirinciZar.TabIndex = 3;
            this.lblBirinciZar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "2. Zar: ";
            // 
            // lblIkinciZar
            // 
            this.lblIkinciZar.AutoSize = true;
            this.lblIkinciZar.Location = new System.Drawing.Point(193, 44);
            this.lblIkinciZar.Name = "lblIkinciZar";
            this.lblIkinciZar.Size = new System.Drawing.Size(21, 24);
            this.lblIkinciZar.TabIndex = 5;
            this.lblIkinciZar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplam Puan: ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(156, 97);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(21, 24);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "0";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(74, 149);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(91, 41);
            this.btnBasla.TabIndex = 8;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnRandomBasla
            // 
            this.btnRandomBasla.Location = new System.Drawing.Point(91, 149);
            this.btnRandomBasla.Name = "btnRandomBasla";
            this.btnRandomBasla.Size = new System.Drawing.Size(91, 41);
            this.btnRandomBasla.TabIndex = 15;
            this.btnRandomBasla.Text = "BAŞLA";
            this.btnRandomBasla.UseVisualStyleBackColor = true;
            this.btnRandomBasla.Click += new System.EventHandler(this.btnRandomBasla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toplam Puan: ";
            // 
            // lblRandomToplam
            // 
            this.lblRandomToplam.AutoSize = true;
            this.lblRandomToplam.Location = new System.Drawing.Point(173, 97);
            this.lblRandomToplam.Name = "lblRandomToplam";
            this.lblRandomToplam.Size = new System.Drawing.Size(21, 24);
            this.lblRandomToplam.TabIndex = 14;
            this.lblRandomToplam.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "2. Zar: ";
            // 
            // lblRandomIkınciZar
            // 
            this.lblRandomIkınciZar.AutoSize = true;
            this.lblRandomIkınciZar.Location = new System.Drawing.Point(210, 44);
            this.lblRandomIkınciZar.Name = "lblRandomIkınciZar";
            this.lblRandomIkınciZar.Size = new System.Drawing.Size(21, 24);
            this.lblRandomIkınciZar.TabIndex = 12;
            this.lblRandomIkınciZar.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "1. Zar: ";
            // 
            // lblRandomIlkZar
            // 
            this.lblRandomIlkZar.AutoSize = true;
            this.lblRandomIlkZar.Location = new System.Drawing.Point(92, 44);
            this.lblRandomIlkZar.Name = "lblRandomIlkZar";
            this.lblRandomIlkZar.Size = new System.Drawing.Size(21, 24);
            this.lblRandomIlkZar.TabIndex = 10;
            this.lblRandomIlkZar.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblToplamRandom);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbltoplamBen);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(22, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oyuncu Puan Tablosu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "2.  Oyuncu: ";
            // 
            // lblToplamRandom
            // 
            this.lblToplamRandom.AutoSize = true;
            this.lblToplamRandom.Location = new System.Drawing.Point(425, 48);
            this.lblToplamRandom.Name = "lblToplamRandom";
            this.lblToplamRandom.Size = new System.Drawing.Size(21, 24);
            this.lblToplamRandom.TabIndex = 12;
            this.lblToplamRandom.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "1.  Oyuncu: ";
            // 
            // lbltoplamBen
            // 
            this.lbltoplamBen.AutoSize = true;
            this.lbltoplamBen.Location = new System.Drawing.Point(198, 44);
            this.lbltoplamBen.Name = "lbltoplamBen";
            this.lbltoplamBen.Size = new System.Drawing.Size(21, 24);
            this.lbltoplamBen.TabIndex = 10;
            this.lbltoplamBen.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(572, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIkinciZar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirinciZar;
        private System.Windows.Forms.Button btnRandomBasla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRandomToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRandomIkınciZar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRandomIlkZar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblToplamRandom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltoplamBen;
    }
}

