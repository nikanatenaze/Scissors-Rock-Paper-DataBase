using Microsoft.EntityFrameworkCore;
using Scissors_rock_and_paper.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scissors_rock_and_paper.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<GameModel> Game { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2BVUIBI;Initial Catalog=ScissorsRockPaperDb;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
