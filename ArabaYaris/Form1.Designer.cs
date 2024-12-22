using System.Drawing;
using System.Windows.Forms;
namespace ArabaYaris
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Timer timer1;
        private PictureBox araba;
        private PictureBox engel1;
        private PictureBox engel2;
        private Label lblSkor;
        private Button btnYenidenBaslat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSkor = new System.Windows.Forms.Label();
            this.btnYenidenBaslat = new System.Windows.Forms.Button();
            this.engel2 = new System.Windows.Forms.PictureBox();
            this.engel1 = new System.Windows.Forms.PictureBox();
            this.araba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSkor.Location = new System.Drawing.Point(10, 10);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(78, 24);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "Skor: 0";
            // 
            // btnYenidenBaslat
            // 
            this.btnYenidenBaslat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnYenidenBaslat.Location = new System.Drawing.Point(151, 231);
            this.btnYenidenBaslat.Name = "btnYenidenBaslat";
            this.btnYenidenBaslat.Size = new System.Drawing.Size(100, 40);
            this.btnYenidenBaslat.TabIndex = 0;
            this.btnYenidenBaslat.Text = "Yeniden Başlat";
            this.btnYenidenBaslat.Visible = false;
            this.btnYenidenBaslat.Click += new System.EventHandler(this.btnYenidenBaslat_Click);
            // 
            // engel2
            // 
            this.engel2.Image = global::ArabaYaris.Properties.Resources.engel2;
            this.engel2.Location = new System.Drawing.Point(120, -150);
            this.engel2.Name = "engel2";
            this.engel2.Size = new System.Drawing.Size(40, 70);
            this.engel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel2.TabIndex = 2;
            this.engel2.TabStop = false;
            // 
            // engel1
            // 
            this.engel1.Image = global::ArabaYaris.Properties.Resources.engel1;
            this.engel1.Location = new System.Drawing.Point(50, 50);
            this.engel1.Name = "engel1";
            this.engel1.Size = new System.Drawing.Size(40, 70);
            this.engel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel1.TabIndex = 3;
            this.engel1.TabStop = false;
            // 
            // araba
            // 
            this.araba.Image = global::ArabaYaris.Properties.Resources.araba;
            this.araba.Location = new System.Drawing.Point(90, 300);
            this.araba.Name = "araba";
            this.araba.Size = new System.Drawing.Size(40, 70);
            this.araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba.TabIndex = 4;
            this.araba.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.btnYenidenBaslat);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.engel2);
            this.Controls.Add(this.engel1);
            this.Controls.Add(this.araba);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

