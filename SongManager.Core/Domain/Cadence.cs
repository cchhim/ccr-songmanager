using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class Cadence : Entity
    {
        public const string CadenceNameDisplay = "CadenceName";
        public virtual string CadenceName { get; set; }
        public virtual IList<Song> Songs { get; set; }
    }
}
