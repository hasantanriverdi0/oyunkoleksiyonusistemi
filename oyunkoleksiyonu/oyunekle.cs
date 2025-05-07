using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunkoleksiyonu
{
    public partial class oyunekle : Form
    {
        public oyunekle()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string oyunIsmi = textBox1.Text.Trim();  // Oyun adı
            string oyunIcerigi = textBox2.Text.Trim();  // Oyun içeriği

            // Oyun ismi ve içerik boş değilse ana veri yapısına ekliyoruz
            if (!string.IsNullOrEmpty(oyunIsmi) && !string.IsNullOrEmpty(oyunIcerigi))
            {
                // Ana veri yapısına yeni oyun ekleyelim
                if (!OyunVeritabanı.oyunveri.oyunIcerikleri.ContainsKey(oyunIsmi))
                {
                    OyunVeritabanı.oyunveri.oyunIsimleri.Add(oyunIsmi);
                    OyunVeritabanı.oyunveri.oyunIcerikleri.Add(oyunIsmi, oyunIcerigi);

                    MessageBox.Show("Oyun başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizleyelim
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu oyun zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Oyun ismi ve içeriği boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(); // anasayfa'ya yönlendirme
            anasayfa.Show();
            this.Hide();
        }
    }
}
