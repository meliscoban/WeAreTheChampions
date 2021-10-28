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
    public partial class RenkDuzenle : Form
    {
        readonly WeAreTheChampionsContext context;
        readonly ColorDTO colorDTO;

        public RenkDuzenle(WeAreTheChampionsContext context, ColorDTO colorDTO)
        {
            this.context = context;
            this.colorDTO = colorDTO;
            InitializeComponent();
        }

        private void btnRenkDuzenleRenkDuzenle_Click(object sender, EventArgs e)
        {
            if (context.Colors.Any(x => x.ColorName == txtRenkDuzenleRenkAd.Text && x.Red == (int)nudRenkDuzenleKirmizi.Value && x.Green == (int)nudRenkDuzenleYesil.Value && x.Blue == (int)nudRenkDuzenleMavi.Value))
            {
                MessageBox.Show("Bu renk daha önce eklenmiştir.");
            }
            else
            {
                Color color = context.Colors.FirstOrDefault(x => x.Id.Equals(colorDTO.Id));

                color.ColorName = txtRenkDuzenleRenkAd.Text;
                color.Red = (int)nudRenkDuzenleKirmizi.Value;
                color.Green = (int)nudRenkDuzenleYesil.Value;
                color.Blue = (int)nudRenkDuzenleMavi.Value;

                MessageBox.Show("Renk başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}