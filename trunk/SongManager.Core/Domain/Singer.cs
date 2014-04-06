using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class Singer : Entity
    {
        public const string SingerNameDisplay = "SingerName";
        public virtual string SingerName {  get; set; }
        public virtual IList<Song> Songs { get; set; }
    }
}
