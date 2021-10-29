using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions.Forms.Renkler
{
    public partial class RenkEkle : Form
    {
        readonly WeAreTheChampionsContext context;
        
        public RenkEkle(WeAreTheChampionsContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void btnRenkEkleRenkEkle_Click(object sender, EventArgs e)
        {
            if (context.Colors.Any(x => x.ColorName == txtRenkEkleRenkAd.Text && x.Red == (int)nudRenkEkleKirmizi.Value && x.Green == (int)nudRenkEkleYesil.Value && x.Blue == (int)nudRenkEkleMavi.Value))
            {
                MessageBox.Show("Bu renk daha önce eklenmiştir.");
            }
            else
            {
                context.Colors.Add(new Color()
                {
                    ColorName = txtRenkEkleRenkAd.Text,
                    Red = (int)nudRenkEkleKirmizi.Value,
                    Green = (int)nudRenkEkleYesil.Value,
                    Blue = (int)nudRenkEkleMavi.Value,
                });
                MessageBox.Show("Renk başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}
