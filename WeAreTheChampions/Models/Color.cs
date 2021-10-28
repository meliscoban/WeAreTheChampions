using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class Color
    {
        public int Id { get; set; }

        [Required, MaxLength(50)] 
        public string ColorName { get; set; }

        [Range(0, 255, ErrorMessage = "Girilen değer 0 ile 255 arasında olmalıdır.")]
        public int Red { get; set; }

        [Range(0, 255, ErrorMessage = "Girilen değer 0 ile 255 arasında olmalıdır.")]
        public int Green { get; set; }

        [Range(0, 255, ErrorMessage = "Girilen değer 0 ile 255 arasında olmalıdır.")]
        public int Blue { get; set; }

        public virtual ICollection<TeamColor> TeamColors { get; set; } = new HashSet<TeamColor>();

        public override string ToString() => ColorName;
    }
}
