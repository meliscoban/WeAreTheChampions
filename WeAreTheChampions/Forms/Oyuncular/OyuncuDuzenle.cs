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
    public partial class OyuncuDuzenle : Form
    {
        readonly WeAreTheChampionsContext context;
        readonly PlayerDTO playerDTO;

        public OyuncuDuzenle(WeAreTheChampionsContext context, PlayerDTO playerDTO)
        {
            this.context = context;
            this.playerDTO = playerDTO;
            InitializeComponent();
            TakimlariGetir();
        }

        private void TakimlariGetir()
        {
            cboOyuncuDuzenleTakimAd.DisplayMember = "TeamName";
            cboOyuncuDuzenleTakimAd.ValueMember = "Id";
            cboOyuncuDuzenleTakimAd.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }

        private void btnOyuncuDuzenleOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (context.Players.Any(x => x.PlayerName == txtOyuncuDuzenleOyuncuAd.Text && x.Team.TeamName == cboOyuncuDuzenleTakimAd.Text))
            {
                MessageBox.Show("Bu karşılaşma daha önce eklenmiştir.");
            }
            else
            {
                Player player = context.Players.FirstOrDefault(x => x.Id.Equals(playerDTO.Id));

                player.PlayerName = txtOyuncuDuzenleOyuncuAd.Text;
                player.Team.TeamName = cboOyuncuDuzenleTakimAd.Text;
                MessageBox.Show("Karşılaşma başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}
