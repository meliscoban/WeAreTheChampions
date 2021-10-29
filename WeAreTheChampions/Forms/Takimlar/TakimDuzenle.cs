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
    public partial class TakimDuzenle : Form
    {
        readonly WeAreTheChampionsContext context;
        readonly TeamDTO teamDTO; 
        
        public TakimDuzenle(WeAreTheChampionsContext context, TeamDTO teamDTO)
        {
            this.context = context;
            this.teamDTO = teamDTO;
            InitializeComponent();
            RenkleriGetir();
        }

        private void RenkleriGetir()
        {
            cklTakimDuzenleRenkler.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
            cklTakimDuzenleRenkler.DisplayMember = "ColorName";
            cklTakimDuzenleRenkler.ValueMember = "Id";
        }

        private void btnTakimDuzenleTakimDuzenle_Click(object sender, EventArgs e)
        {
            Team team = context.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO.Id));

            if (cklTakimDuzenleRenkler.CheckedItems.Count == 0)
            {
                team.TeamName = txtTakimDuzenleTakimAd.Text;
                team.TeamColors = null;
                MessageBox.Show("Takım başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
            else
            {
                List<TeamColor> teamColorList = new List<TeamColor>();

                for (int i = 0; i < cklTakimDuzenleRenkler.CheckedItems.Count; i++)
                {
                    teamColorList.Add(new TeamColor() { ColorId = ((ColorDTO)cklTakimDuzenleRenkler.CheckedItems[i]).Id });
                }

                team.TeamName = txtTakimDuzenleTakimAd.Text;
                team.TeamColors = teamColorList;

                MessageBox.Show("Takım başarıyla güncellenmiştir.");
                context.SaveChanges();
                Close();
            }
        }
    }
}
