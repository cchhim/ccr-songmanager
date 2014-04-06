using System.Collections.Generic;

namespace SongManager.Core.Domain
{
    public class Production : Entity
    {
        public const string ProductionNameDisplay = "ProductionName";
        public const string ProductionDisplay = "Production";
        public virtual string ProductionName { get; set; }
        public virtual IList<Album> Albums { get; set; }
      //  public virtual IList<Song> Songs { get; set; }
        
    }
}
