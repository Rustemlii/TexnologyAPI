using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class TexnoMarka : Base
    {
        public int markaId { get; set; }
        public string? Marka { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<TexnoModel>? TexnoModels { get; set; }

    }
}
