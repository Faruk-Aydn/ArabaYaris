using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYaris
{
    public partial class Form1 : Form
    {
        private int yolHizi = 7;
        private int arabaHizi = 10;
        private int skor = 0;
        private Random random = new Random();
        private bool oyunDevam = true;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true; // Klavye olaylarını form yakalar
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!oyunDevam) return;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (araba.Left > 0) // Sol sınır
                        araba.Left -= arabaHizi;
                    break;
                case Keys.Right:
                    if (araba.Right < ClientSize.Width) // Sağ sınır
                        araba.Left += arabaHizi;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Şeritlerin yeniden çizimi
            Invalidate();

            // Engelleri hareket ettir
            hareketEt(engel1);
            hareketEt(engel2);

            // Çarpışma kontrolü
            if (araba.Bounds.IntersectsWith(engel1.Bounds) || araba.Bounds.IntersectsWith(engel2.Bounds))
            {
                oyunBitti();
            }

            // Skoru güncelle
            skor++;
            lblSkor.Text = $"Skor: {skor}";
        }

        private void hareketEt(PictureBox engel)
        {
            engel.Top += yolHizi;

            if (engel.Top >= ClientSize.Height)
            {
                engel.Top = -random.Next(50, 150);
                engel.Left = random.Next(50, ClientSize.Width - engel.Width - 50);
            }
        }

        private void oyunBitti()
        {
            oyunDevam = false;
            timer1.Stop();
            MessageBox.Show("Oyun Bitti!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnYenidenBaslat.Visible = true;
        }

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            oyunDevam = true;
            skor = 0;
            lblSkor.Text = $"Skor: {skor}";
            araba.Left = ClientSize.Width / 2 - araba.Width / 2;
            engel1.Top = -random.Next(100, 300);
            engel2.Top = -random.Next(300, 500);
            btnYenidenBaslat.Visible = false;
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Yol arka planı
            g.FillRectangle(Brushes.Gray, new Rectangle(50, 0, ClientSize.Width - 100, ClientSize.Height));

            // Yol şeritleri
            for (int i = 0; i < ClientSize.Height; i += 50)
            {
                g.FillRectangle(Brushes.White, new Rectangle(ClientSize.Width / 2 - 5, i, 10, 30));
            }
        }
    }
}