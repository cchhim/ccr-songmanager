using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongManager.Core.Model
{
    public class AlbumListModel
    {
        public virtual int Id { get; set; }
        public virtual string AlbumNum { get; set; }
        public virtual string Production { get; set; }
        public virtual string Type { get; set; }
    }
}
