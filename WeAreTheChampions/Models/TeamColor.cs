using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class TeamColor
    {
        public int Id { get; set; }

        public int TeamId { get; set; }

        public int ColorId { get; set; }

        public Team Team { get; set; }

        public Color Color { get; set; }
    }
}
