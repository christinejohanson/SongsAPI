using System.ComponentModel.DataAnnotations;

namespace SongsAPI.Models
{

    public class Song
    {
        //properties
        public int SongId { get; set; }
        [Required]
        public string? SongArtist { get; set; }
        [Required]
        public string? SongName { get; set; }
        [Required]
        public int SongLength { get; set; }
        [Required]
        public string? Category { get; set; }
    }


}