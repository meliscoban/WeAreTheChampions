using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Forms.Oyuncular;
using WeAreTheChampions.Forms.Renkler;
using WeAreTheChampions.Forms.Takimlar;
using WeAreTheChampions.Models;
using WeAreTheChampions.Utils;

namespace WeAreTheChampions
{
    public partial class AnaSayfa : Form
    {
        readonly WeAreTheChampionsContext context = new WeAreTheChampionsContext();
        readonly MatchDTO matchDTO = new MatchDTO();
        readonly PlayerDTO playerDTO = new PlayerDTO();
        readonly ColorDTO colorDTO = new ColorDTO();
        readonly TeamDTO teamDTO = new TeamDTO();

        public AnaSayfa()
        {
            InitializeComponent();
            KarsilasmalariListele();
            OyunculariListele();
            RenkleriListele();
            TakimlariListele();
        }

        #region Karşılaşmalar
        
        private void KarsilasmalariListele()
        {
            dgvKarsilasmalarKarsilasmalar.AutoGenerateColumns = false;

            dgvKarsilasmalarKarsilasmalar.DataSource = context.Matches.Select(x => new MatchDTO() { Id = x.Id, MatchTime = x.MatchTime, Team1Name = x.Team1.TeamName, Team2Name = x.Team2.TeamName, Score1 = x.Score1, Score2 = x.Score2, Result = x.Result }).ToList();
        }
        
        private void btnKarsilasmalarKarsilasmaDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalarKarsilasmalar.SelectedRows.Count == 1)
            {
                FormOlustur(EnumClass.Form.KarsilasmaDuzenle);
                KarsilasmalariListele();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz karşılaşmayı seçiniz.");
            }
        }

        private void btnKarsilasmalarKarsilasmaEkle_Click(object sender, EventArgs e)
        {
            FormOlustur(EnumClass.Form.KarsilasmaEkle);
            KarsilasmalariListele();
        }

        private void btnKarsilasmalarKarsilasmaSil_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalarKarsilasmalar.SelectedRows.Count == 1)
            {
                MatchDTO matchDTO = (MatchDTO)dgvKarsilasmalarKarsilasmalar.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Seçili karşılaşmayı silmek istediğinize emin misiniz?", "Karşılaşmayı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
                
                Match match = context.Matches.FirstOrDefault(x => x.Id.Equals(matchDTO.Id));
                
                context.Matches.Remove(match);
                context.SaveChanges();

                MessageBox.Show("Karşılaşma başarıyla silinmiştir.");
                KarsilasmalariListele();
            }
        }

        #endregion

        #region Oyuncular
        private void cboOyuncularTakimlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOyuncularTakimlar.SelectedIndex == -1)
            {
                dgvOyuncularOyuncular.DataSource = null;
            }
            else if (cboOyuncularTakimlar.SelectedIndex == 0)
            {
                dgvOyuncularOyuncular.DataSource = context.Players.Select(x => new PlayerDTO() { Id = x.Id, TeamId = x.TeamId, PlayerName = x.PlayerName, TeamName = x.Team.TeamName }).ToList();
            }
            else
            {
                TeamDTO teamDTO = (TeamDTO)cboOyuncularTakimlar.SelectedItem;
                dgvOyuncularOyuncular.DataSource = context.Players.Select(x => new PlayerDTO() { Id = x.Id, TeamId = x.TeamId, PlayerName = x.PlayerName, TeamName = x.Team.TeamName }).Where(y => y.TeamName.Equals(teamDTO.TeamName)).ToList();
            }
        }

        private void OyunculariListele()
        {
            dgvOyuncularOyuncular.AutoGenerateColumns = false;

            cboOyuncularTakimlar.DisplayMember = "TeamName";
            cboOyuncularTakimlar.ValueMember = "Id";
            var takimlarList = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
            takimlarList.Insert(0, new TeamDTO() { TeamName = "Bütün Takımlar" });
            cboOyuncularTakimlar.DataSource = takimlarList;

            dgvOyuncularOyuncular.DataSource = context.Players.Select(x => new PlayerDTO() { Id = x.Id, TeamId = x.TeamId, TeamName = x.Team.TeamName, PlayerName = x.PlayerName }).ToList();
        }

        private void btnOyuncularOyuncuDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOyuncularOyuncular.SelectedRows.Count == 1)
            {
                FormOlustur(EnumClass.Form.OyuncuDuzenle);
                OyunculariListele();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz oyuncuyu seçiniz.");
            }
        }

        private void btnOyuncularOyuncuEkle_Click(object sender, EventArgs e)
        {
            FormOlustur(EnumClass.Form.OyuncuEkle);
            OyunculariListele();
        }

        private void btnOyuncularOyuncuSil_Click(object sender, EventArgs e)
        {
            if (dgvOyuncularOyuncular.SelectedRows.Count == 1)
            {
                PlayerDTO playerDTO = (PlayerDTO)dgvOyuncularOyuncular.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Seçili oyuncuyu silmek istediğinize emin misiniz?", "Oyuncuyu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                Player player = context.Players.FirstOrDefault(x => x.Id.Equals(playerDTO.Id));

                context.Players.Remove(player);
                context.SaveChanges();

                MessageBox.Show("Oyuncu başarıyla silinmiştir.");
                OyunculariListele();
            }
        }
        #endregion

        #region Renkler

        private void RenkleriListele()
        {
            dgvRenklerRenkler.AutoGenerateColumns = false;

            dgvRenklerRenkler.DataSource = context.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName, Red = x.Red, Green = x.Green, Blue = x.Blue }).ToList();
        }

        private void btnRenklerRenkDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvRenklerRenkler.SelectedRows.Count == 1)
            {
                FormOlustur(EnumClass.Form.RenkDuzenle);
                RenkleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz rengi seçiniz.");
            }
        }

        private void btnRenklerRenkEkle_Click(object sender, EventArgs e)
        {
            FormOlustur(EnumClass.Form.RenkEkle);
            RenkleriListele();
        }

        private void btnRenklerRenkSil_Click(object sender, EventArgs e)
        {
            if (dgvRenklerRenkler.SelectedRows.Count == 1)
            {
                ColorDTO colorDTO = (ColorDTO)dgvRenklerRenkler.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Seçili rengi silmek istediğinize emin misiniz?", "Rengi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                Color color = context.Colors.FirstOrDefault(x => x.Id.Equals(colorDTO.Id));
                context.Colors.Remove(color);
                context.SaveChanges();
                
                MessageBox.Show("Renk başarıyla silinmiştir.");
                RenkleriListele();
            }
        }
        #endregion

        #region Takımlar
        private void TakimlariListele()
        {
            dgvTakimlarTakimlar.AutoGenerateColumns = false;

            dgvTakimlarTakimlar.DataSource = context.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName}).ToList();
        }
        
        private void btnTakimlarTakimDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvTakimlarTakimlar.SelectedRows.Count == 1)
            {
                FormOlustur(EnumClass.Form.TakimDuzenle);
                TakimlariListele();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz takımı seçiniz.");
            }
        }

        private void btnTakimlarTakimEkle_Click(object sender, EventArgs e)
        {
            FormOlustur(EnumClass.Form.TakimEkle);
            TakimlariListele();
        }

        private void btnTakimlarTakimSil_Click(object sender, EventArgs e)
        {
            if (dgvTakimlarTakimlar.SelectedRows.Count == 1)
            {
                TeamDTO teamDTO = (TeamDTO)dgvTakimlarTakimlar.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Seçili takımı silmek istediğinize emin misiniz?", "Takımı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                Team team = context.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO.Id));

                context.Teams.Remove(team);
                context.SaveChanges();
                MessageBox.Show("Takım başarıyla silinmiştir.");
                KarsilasmalariListele();
                TakimlariListele();
            }
        }

        private void btnTakimlarTakimOyunculari_Click(object sender, EventArgs e)
        {
            if (dgvTakimlarTakimlar.SelectedRows.Count == 1)
            {
                FormOlustur(EnumClass.Form.TakimOyunculari);
            }
            else
            {
                MessageBox.Show("Lütfen oyuncularını görmek istediğiniz takımı seçiniz.");
            }
        }
        #endregion
        
        private void FormOlustur(EnumClass.Form formEnum)
        {
            Form form;
            switch (formEnum)
            {
                case EnumClass.Form.KarsilasmaDuzenle:
                    MatchDTO matchDTO = (MatchDTO)dgvKarsilasmalarKarsilasmalar.SelectedRows[0].DataBoundItem;
                    form = new KarsilasmaDuzenle(context, matchDTO); 
                    break;
                case EnumClass.Form.KarsilasmaEkle: 
                    form = new KarsilasmaEkle(context); 
                    break;
                case EnumClass.Form.OyuncuDuzenle:
                    PlayerDTO playerDTO = (PlayerDTO)dgvOyuncularOyuncular.SelectedRows[0].DataBoundItem;
                    form = new OyuncuDuzenle(context, playerDTO);
                    break;
                case EnumClass.Form.OyuncuEkle:
                    form = new OyuncuEkle(context);
                    break;
                case EnumClass.Form.RenkDuzenle:
                    ColorDTO colorDTO = (ColorDTO)dgvRenklerRenkler.SelectedRows[0].DataBoundItem;
                    form = new RenkDuzenle(context, colorDTO);
                    break;
                case EnumClass.Form.RenkEkle:
                    form = new RenkEkle(context);
                    break;
                case EnumClass.Form.TakimDuzenle:
                    TeamDTO teamDTO = (TeamDTO)dgvKarsilasmalarKarsilasmalar.SelectedRows[0].DataBoundItem;
                    form = new TakimDuzenle(context, teamDTO);
                    break;
                case EnumClass.Form.TakimEkle:
                    form = new TakimEkle(context);
                    break;
                default: 
                    form = new TakimOyunculari(context);
                    break;
            }
            form.ShowDialog();
        }
    }
}
