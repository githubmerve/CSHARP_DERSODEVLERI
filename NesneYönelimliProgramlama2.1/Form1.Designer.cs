using System;

namespace NesneYönelimliProgramlama2._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mesaiTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unvanTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // adTxt
            // 
            this.adTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adTxt.Location = new System.Drawing.Point(190, 40);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 22);
            this.adTxt.TabIndex = 3;
            this.adTxt.Text = " Merve Subaşı";
            this.adTxt.TextChanged += new System.EventHandler(this.adTxt_TextChanged);
            // 
            // adresTxt
            // 
            this.adresTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adresTxt.Location = new System.Drawing.Point(190, 133);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(100, 22);
            this.adresTxt.TabIndex = 4;
            this.adresTxt.Text = "Kocaeli";
            // 
            // yasTxt
            // 
            this.yasTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yasTxt.Location = new System.Drawing.Point(190, 86);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(100, 22);
            this.yasTxt.TabIndex = 5;
            this.yasTxt.Text = "18";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(190, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Personel Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesai Saati";
            // 
            // mesaiTxt
            // 
            this.mesaiTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mesaiTxt.Location = new System.Drawing.Point(190, 180);
            this.mesaiTxt.Name = "mesaiTxt";
            this.mesaiTxt.Size = new System.Drawing.Size(100, 22);
            this.mesaiTxt.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // unvanTxt
            // 
            this.unvanTxt.AutoSize = true;
            this.unvanTxt.Location = new System.Drawing.Point(66, 244);
            this.unvanTxt.Name = "unvanTxt";
            this.unvanTxt.Size = new System.Drawing.Size(46, 16);
            this.unvanTxt.TabIndex = 10;
            this.unvanTxt.Text = "Ünvan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unvanTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mesaiTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yasTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void adTxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mesaiTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label unvanTxt;
    }
}

