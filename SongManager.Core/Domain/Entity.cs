using System;

namespace SongManager.Core.Domain
{
    public class Entity
    {
        public virtual Int32 Id { get; set; }      
        public virtual DateTime? Created { get; set; }
        public virtual DateTime? Modified { get; set; }
    }
}
