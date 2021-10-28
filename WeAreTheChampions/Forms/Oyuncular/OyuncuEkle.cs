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

namespace WeAreTheChampions.Forms.Oyuncular
{
    public partial class OyuncuEkle : Form
    {
        readonly WeAreTheChampionsContext context;

        public OyuncuEkle(WeAreTheChampionsContext context)
        {
            this.context = context;
            InitializeComponent();
            TakimlariGetir();
        }

        private void TakimlariGetir()
        {
            cboOyuncuEkleTakimAd.DisplayMember = "TeamName";
            cboOyuncuEkleTakimAd.ValueMember = "Id";
            cboOyuncuEkleTakimAd.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }

        private void btnOyuncuEkleOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (context.Players.Any(x => x.PlayerName == txtOyuncuEkleOyuncuAd.Text && x.TeamId == (int)cboOyuncuEkleTakimAd.SelectedValue))
            {
                MessageBox.Show("Bu oyuncu daha önce eklenmiştir.");
            }
            else
            {
                context.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuEkleOyuncuAd.Text,
                    TeamId = (int)cboOyuncuEkleTakimAd.SelectedValue
                });
                context.SaveChanges();
                Close();
            }
        }
    }
}
