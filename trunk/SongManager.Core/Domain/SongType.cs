using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class SongType : Entity
    {
        public const string DisplaySongTypeName = "SongTypeName";
        public const string DisplaySongType = "SongType";
        public virtual string SongTypeName { get; set; }
        public virtual IList<Album> Albums { get; set; }
     //   public virtual IList<Song> Songs { get; set; }       
    }
}
