using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class PlayerDTO
    {
        public int Id { get; set; }

        public int? TeamId { get; set; }

        public string TeamName { get; set; }

        public string PlayerName { get; set; }
    }
}
