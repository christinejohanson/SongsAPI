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
        public int AlbumId { get; set; }
        public Album? Album { get; set; }
    }

    public class Album
    {
        //properties
        public int AlbumId { get; set; }
        [Required]
        public string? AlbumName { get; set; }
        [Range(1, 10)]
        public int AlbumRate { get; set; }
        public List<Song>? Song { get; set; }

    }

}