using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class ColorDTO
    {
        public int Id { get; set; }

        public string ColorName { get; set; }

        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }
    }
}
