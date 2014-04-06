using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongManager.Core.Model
{
    public class SongModel
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Singer { get; set; }
        public virtual string Production { get; set; }
        public virtual string SongType { get; set; }
        public virtual int AlbumNum { get; set; }
        public virtual string Cadence { get; set; }
        public virtual string FileType { get; set; }
        public virtual string Path { get; set; }
    }
}
