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
            cboTakimEkleTakimRenk.DisplayMember = "ColorName";
            cboTakimEkleTakimRenk.ValueMember = "Id";
            cboTakimEkleTakimRenk.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
        }

        private void btnTakimEkleTakimRenkEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTakimEkleTakimEkle_Click(object sender, EventArgs e)
        {
            //if (context.Teams.Any(x => x.TeamName == txtTakimEkleTakimAd.Text && x.TeamColors == ))
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
