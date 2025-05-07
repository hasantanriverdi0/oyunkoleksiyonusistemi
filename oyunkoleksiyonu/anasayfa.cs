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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            oyunekle oyunekle = new oyunekle();
            oyunekle.Show();
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            oyunkoleksiyon oyunkoleksiyon = new oyunkoleksiyon();
            oyunkoleksiyon.Show();
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
