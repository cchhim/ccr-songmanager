using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface IAlbumView
    {
        Album Album { set; }
        void UpdateValueOn(Album album);
        IList<Album> Albums { set; }
    }
}
