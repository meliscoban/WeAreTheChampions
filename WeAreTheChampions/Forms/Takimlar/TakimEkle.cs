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
            //cboTakimEkleTakimRenk.DisplayMember = "ColorName";
            //cboTakimEkleTakimRenk.ValueMember = "Id";
            //cboTakimEkleTakimRenk.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();

            cklTakimEkleRenkler.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
            cklTakimEkleRenkler.DisplayMember = "ColorName";
            cklTakimEkleRenkler.ValueMember = "Id";

        }

        private void btnTakimEkleTakimRenkEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTakimEkleTakimEkle_Click(object sender, EventArgs e)
        {
            if (cklTakimEkleRenkler.CheckedItems.Count == 0)
            {
                context.Teams.Add(new Team()
                {
                    TeamName = txtTakimEkleTakimAd.Text,
                });
                context.SaveChanges();
                Close();
            }
            else
            {
                List<ColorDTO> teamColorsList = new List<ColorDTO>();
                for (int i = 0; i < cklTakimEkleRenkler.CheckedItems.Count; i++)
                {
                    teamColorsList.Add((ColorDTO)cklTakimEkleRenkler.CheckedItems[i]);
                    

                    //context.TeamColors.Add(new TeamColor() { ColorId = cklTakimEkleRenkler.CheckedItems[i], Team = new Team() { TeamName = txtTakimEkleTakimAd.Text } });
                }


                foreach (object itemChecked in cklTakimEkleRenkler.CheckedItems)
                {
                    teamColorsList.Add((ColorDTO)cklTakimEkleRenkler.SelectedValue);

                }

                //context.Teams.Add(new Team()
                //{
                //    TeamName = txtTakimEkleTakimAd.Text,
                //    TeamColors = teamColorsList
                //});

                //context.TeamColors.Add(new TeamColor()
                //{
                //    TeamId = 
                //    ColorId = teamColorsList
                //});

                context.SaveChanges();
                Close();
            }

            //if (context.Teams.Any(x => x.TeamName == txtTakimEkleTakimAd.Text))
            //{
            //    MessageBox.Show("Bu takım daha önce eklenmiştir.");
            //}
            //else
            //{
            //    context.Teams.Add(new Team()
            //    {
            //        TeamName = txtTakimEkleTakimAd.Text,
            //        TeamColors = lstTakimEkleTakimRenkler,
            //    });
            //    context.SaveChanges();
            //    Close();
            //}


        }
    }
}
