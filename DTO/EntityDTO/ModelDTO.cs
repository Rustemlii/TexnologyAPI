using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.EntityDTO
{
    public class ModelDTO
    {
        public string? Model { get; set; }
        public decimal? Price { get; set; }
        public string About { get; set; }
        public int TexnoMarkaID { get; set; }
        public DateTime Time {  get; set; }
        //public virtual TexnoMarka? TexnoMarka { get; set; }
    }
}
