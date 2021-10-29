using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Utils
{
    public class EnumClass
    {
        public enum Form
        {
           KarsilasmaDuzenle,
           KarsilasmaEkle,
           OyuncuDuzenle,
           OyuncuEkle,
           RenkDuzenle,
           RenkEkle,
           TakimDuzenle,
           TakimEkle
        };

        public enum Result
        {
            Berabere = 0,
            Team1Kazandi = 1,
            Team2Kazandi = 2
        };
    }
}
