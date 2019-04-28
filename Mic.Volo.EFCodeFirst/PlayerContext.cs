using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.EFCodeFirst
{
    class PlayerContext:DbContext
    {
        public PlayerContext()
        {

        }
        public DbSet<Player> Players { get;set }
    }
}
