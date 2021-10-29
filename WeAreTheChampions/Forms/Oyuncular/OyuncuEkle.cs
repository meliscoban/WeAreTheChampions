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
            cboOyuncuEkleTakimAd.Enabled = false;
        }

        private void btnOyuncuEkleOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (chkOyuncuEkleTakim.Checked == true)
            {
                context.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuEkleOyuncuAd.Text,
                    TeamId = (int)cboOyuncuEkleTakimAd.SelectedValue
                });
                MessageBox.Show("Oyuncu başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
            else
            {
                context.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuEkleOyuncuAd.Text,
                });
                MessageBox.Show("Oyuncu başarıyla eklenmiştir.");
                context.SaveChanges();
                Close();
            }
        }

        private void chkOyuncuEkleTakim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOyuncuEkleTakim.Checked == true)
            {
                cboOyuncuEkleTakimAd.Enabled = true;
            }
            else if (chkOyuncuEkleTakim.Checked == false)
            {
                cboOyuncuEkleTakimAd.Enabled = false;
            }
        }
    }
}
