namespace SongManager.Core.Domain
{
    public class Song : Entity
    {
        public virtual string Title { get; set; }
        public virtual Singer Singer { get; set; }
        //public virtual Production Production { get; set; }
        //public virtual SongType SongType { get; set; }
        public virtual Album Album { get; set; }
        public virtual Cadence Cadence { get; set; }
        public virtual FileType FileType { get; set; }
        public virtual string Path { get; set; }
    }
}
