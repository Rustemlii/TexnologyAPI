using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class TexnoModel:Base
    {
        public string? Model { get; set; }
        [Range(1, 100)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }
        public string About { get; set; }
        public int TexnoMarkaID { get; set; }
        public virtual TexnoMarka? TexnoMarka { get; set; }
    }
}
