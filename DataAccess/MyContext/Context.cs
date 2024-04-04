using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MyContext
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<TexnoMarka> TexnoMarkas { get; set; }
        public DbSet<TexnoModel> TexnoModels { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

    }
}
