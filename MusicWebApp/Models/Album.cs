namespace MusicWebApp.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public List<Song> Songs { get; set; }
    }
}
