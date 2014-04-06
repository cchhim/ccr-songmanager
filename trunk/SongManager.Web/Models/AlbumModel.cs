using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SongManager.Core.Domain;

namespace SongManager.Web.Models
{
    public class AlbumModel
    {
        public IList<Album> AlbumVCDs { get; set; }
        public IList<Album> AlbumCDs { get; set; }
    }
}