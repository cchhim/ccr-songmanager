using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class Album : Entity
    {
        public const string AlbumNumDisplay = "AlbumNum";
        public virtual int AlbumNum { get; set; }
        public virtual Production Production { get; set; }
        public virtual SongType SongType { get; set; }
        public virtual IList<Song> Songs { get; set; }
    }
}
