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
            
        }

        private void btnTakimDuzenleTakimDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
