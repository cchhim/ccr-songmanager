using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class FileType : Entity
    {
        public virtual string FileTypeName { get; set; }
        public virtual IList<Song> Songs { get; set; }
    }
}
