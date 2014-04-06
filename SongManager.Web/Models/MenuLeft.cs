using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SongManager.Core.Domain;

namespace SongManager.Web.Models
{
    public class MenuLeft
    { 
        public List<Production> Productions { get; set; }
        public List<SongType> SongTypes { get; set; }
    }
}