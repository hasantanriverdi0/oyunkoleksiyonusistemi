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
    public partial class oyunkoleksiyon : Form
    {
        public oyunkoleksiyon()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(); // anasayfaya yönlendirme
            anasayfa.Show();
            this.Hide();
        }

        private void oyunkoleksiyon_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = OyunVeritabanı.oyunveri.oyunIsimleri;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOyun = comboBox1.SelectedItem.ToString();

            // Seçilen oyunun içeriğini TextBox'a yazdıralım
            if (OyunVeritabanı.oyunveri.oyunIcerikleri.ContainsKey(secilenOyun))
            {
                // TextBox'a içeriği yazalım
                textBox1.Text = OyunVeritabanı.oyunveri.oyunIcerikleri[secilenOyun];

                // TextBox'ın özelliklerini ayarlayalım
                textBox1.Multiline = true;       // Birden fazla satırda gösterim sağlanacak
                textBox1.ScrollBars = ScrollBars.Vertical; // Dikey kaydırma çubuğu ekleyelim
                textBox1.ReadOnly = true;        // Sadece okuma için
            }
        }
    }
}
