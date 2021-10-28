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

namespace WeAreTheChampions
{
    public partial class KarsilasmaEkle : Form
    {
        readonly WeAreTheChampionsContext context;
        public KarsilasmaEkle(WeAreTheChampionsContext context)
        {
            this.context = context;
            InitializeComponent();
            TakimlariGetir();
        }
        private void TakimlariGetir()
        {
            cboKarsilasmaEkleTakim1.DisplayMember = "TeamName";
            cboKarsilasmaEkleTakim1.ValueMember = "Id";
            cboKarsilasmaEkleTakim1.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
            cboKarsilasmaEkleTakim2.DisplayMember = "TeamName";
            cboKarsilasmaEkleTakim2.ValueMember = "Id";
            cboKarsilasmaEkleTakim2.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }

        private void btnKarsilasmaEkleKarsilasmaEkle_Click(object sender, EventArgs e)
        {
            if (cboKarsilasmaEkleTakim1.SelectedIndex == cboKarsilasmaEkleTakim2.SelectedIndex)
            {
                MessageBox.Show("Lütfen 1.Takımı ve 2.Takımı farklı takımlar giriniz.");
            }
            else
            {
                TeamDTO teamDTO1 = (TeamDTO)cboKarsilasmaEkleTakim1.SelectedItem;
                Team team1 = context.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO1.Id));

                TeamDTO teamDTO2 = (TeamDTO)cboKarsilasmaEkleTakim2.SelectedItem;
                Team team2 = context.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO2.Id));

                context.Matches.Add(new Match()
                {
                    MatchTime = new DateTime(dtpKarsilasmaEkleTarih.Value.Year, dtpKarsilasmaEkleTarih.Value.Month, dtpKarsilasmaEkleTarih.Value.Day, dtpKarsilasmaEkleSaat.Value.Hour, dtpKarsilasmaEkleSaat.Value.Minute, dtpKarsilasmaEkleSaat.Value.Second),
                    Team1Id = (int)cboKarsilasmaEkleTakim1.SelectedValue,
                    Team1 = team1,
                    Team2Id = (int)cboKarsilasmaEkleTakim2.SelectedValue,
                    Team2 = team2
                });
                MessageBox.Show("Karşılaşma başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}
