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
    public partial class TakimOyunculari : Form
    {
        readonly WeAreTheChampionsContext context;
        
        public TakimOyunculari(WeAreTheChampionsContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void btnTakimOyunculariOyuncuSil_Click(object sender, EventArgs e)
        {

        }
    }
}
