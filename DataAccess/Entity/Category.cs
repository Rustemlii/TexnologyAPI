﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category:Base
    {
        public string? Name { get; set; }
        public virtual List<TexnoMarka>? TexnoMarkas { get; set; }
    }
}
