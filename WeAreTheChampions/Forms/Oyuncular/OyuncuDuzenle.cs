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
            cboOyuncuDuzenleTakimAd.Enabled = false;
        }

        private void btnOyuncuDuzenleOyuncuEkle_Click(object sender, EventArgs e)
        {
            Player player = context.Players.FirstOrDefault(x => x.Id.Equals(playerDTO.Id));

            if (chkOyuncuDuzenleTakim.Checked == true)
            {
                player.PlayerName = txtOyuncuDuzenleOyuncuAd.Text;
                player.TeamId = (int)cboOyuncuDuzenleTakimAd.SelectedValue;
                MessageBox.Show("Oyuncu başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
            else
            {
                player.PlayerName = txtOyuncuDuzenleOyuncuAd.Text;
                player.TeamId = null;
                MessageBox.Show("Oyuncu başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
        }

        private void chkOyuncuDuzenleTakim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOyuncuDuzenleTakim.Checked == true)
            {
                cboOyuncuDuzenleTakimAd.Enabled = true;
            }
            else if (chkOyuncuDuzenleTakim.Checked == false)
            {
                cboOyuncuDuzenleTakimAd.Enabled = false;
            }
        }
    }
}
