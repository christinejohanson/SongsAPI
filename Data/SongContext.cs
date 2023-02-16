using Microsoft.EntityFrameworkCore;
using SongsAPI.Models;

namespace SongsAPI.Data
{

    //class som ärver av dbcontext
    public class SongContext : DbContext
    {
        //i den en konstruktor som skickar argument
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }
        //db set. tabellen namnges Songs och Albums
        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

    }
}