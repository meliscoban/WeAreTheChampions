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

namespace WeAreTheChampions.Forms.Takimlar
{
    public partial class TakimEkle : Form
    {
        readonly WeAreTheChampionsContext context;

        public TakimEkle(WeAreTheChampionsContext context)
        {
            this.context = context;
            InitializeComponent();
            RenkleriGetir();
        }


        private void RenkleriGetir()
        {
            cklTakimEkleRenkler.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
            cklTakimEkleRenkler.DisplayMember = "ColorName";
            cklTakimEkleRenkler.ValueMember = "Id";
        }

        private void btnTakimEkleTakimEkle_Click(object sender, EventArgs e)
        {
            if (cklTakimEkleRenkler.CheckedItems.Count == 0)
            {
                context.Teams.Add(new Team()
                {
                    TeamName = txtTakimEkleTakimAd.Text,
                });
                MessageBox.Show("Takım başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
            else
            {
                List<TeamColor> teamColorList = new List<TeamColor>();
                for (int i = 0; i < cklTakimEkleRenkler.CheckedItems.Count; i++)
                {
                    teamColorList.Add(new TeamColor() { ColorId = ((ColorDTO)cklTakimEkleRenkler.CheckedItems[i]).Id });
                }

                context.Teams.Add(new Team()
                {
                    TeamName = txtTakimEkleTakimAd.Text,
                    TeamColors = teamColorList
                });
                MessageBox.Show("Takım başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}
