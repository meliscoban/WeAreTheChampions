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
    public partial class KarsilasmaDuzenle : Form
    {
        readonly WeAreTheChampionsContext context;
        readonly MatchDTO matchDTO;

        public KarsilasmaDuzenle(WeAreTheChampionsContext context, MatchDTO matchDTO)
        {
            this.context = context;
            this.matchDTO = matchDTO;
            InitializeComponent();
            TakimlariGetir();
        }

        private void btnKarsilasmaDuzenleKarsilasmaDuzenle_Click(object sender, EventArgs e)
        {
            if (cboKarsilasmaDuzenleTakim1.SelectedIndex == cboKarsilasmaDuzenleTakim2.SelectedIndex)
            {
                MessageBox.Show("Lütfen 1.Takımı ve 2.Takımı farklı takımlar giriniz.");
            }
            else if (context.Matches.Any(x => x.MatchTime == dtpKarsilasmaDuzenleTarih.Value && x.Team1Id == cboKarsilasmaDuzenleTakim1.SelectedIndex && x.Team2Id == cboKarsilasmaDuzenleTakim2.SelectedIndex && x.Score1 == nudKarsilasmaDuzenleSkor1.Value && x.Score2 == nudKarsilasmaDuzenleSkor2.Value))
            {
                MessageBox.Show("Bu karşılaşma daha önce eklenmiştir.");
            }
            else
            {
                Match match = context.Matches.FirstOrDefault(x => x.Id.Equals(matchDTO.Id));

                match.MatchTime = new DateTime(dtpKarsilasmaDuzenleTarih.Value.Year, dtpKarsilasmaDuzenleTarih.Value.Month, dtpKarsilasmaDuzenleTarih.Value.Day, dtpKarsilasmaDuzenleSaat.Value.Hour, dtpKarsilasmaDuzenleSaat.Value.Minute, dtpKarsilasmaDuzenleSaat.Value.Second);
                match.Score1 = (int)nudKarsilasmaDuzenleSkor1.Value;
                match.Score2 = (int)nudKarsilasmaDuzenleSkor2.Value;
                match.Team1Id = (int)cboKarsilasmaDuzenleTakim1.SelectedValue;
                match.Team2Id = (int)cboKarsilasmaDuzenleTakim2.SelectedValue;
                MessageBox.Show("Karşılaşma başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
        }

        private void TakimlariGetir()
        {
            cboKarsilasmaDuzenleTakim1.DisplayMember = "TeamName";
            cboKarsilasmaDuzenleTakim1.ValueMember = "Id";
            cboKarsilasmaDuzenleTakim1.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();

            cboKarsilasmaDuzenleTakim2.DisplayMember = "TeamName";
            cboKarsilasmaDuzenleTakim2.ValueMember = "Id";
            cboKarsilasmaDuzenleTakim2.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }
    }
}
